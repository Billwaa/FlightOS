/*
Yu Hin Hau
Cascade PID Motor Balancer
Build On Top of MPU6050 IMU Code from Jeff Rowberg
Spring 2015

Use Keyboard to Tune PID Gains
*/


/* ============================================
I2Cdev device library code is placed under the MIT license
Copyright (c) 2012 Jeff Rowberg

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
===============================================
*/


#include "I2Cdev.h"
#include "MPU6050_6Axis_MotionApps20.h"

// Arduino Wire library is required if I2Cdev I2CDEV_ARDUINO_WIRE implementation
// is used in I2Cdev.h
#if I2CDEV_IMPLEMENTATION == I2CDEV_ARDUINO_WIRE
#include "Wire.h"
#endif

// class default I2C address is 0x68
// specific I2C addresses may be passed as a parameter here
// AD0 low = 0x68 (default for SparkFun breakout and InvenSense evaluation board)
// AD0 high = 0x69
MPU6050 mpu;

#define LED_PIN 13 // (Arduino is 13, Teensy is 11, Teensy++ is 6)
bool blinkState = false;

// MPU control/status vars
bool dmpReady = false;  // set true if DMP init was successful
uint8_t mpuIntStatus;   // holds actual interrupt status byte from MPU
uint8_t devStatus;      // return status after each device operation (0 = success, !0 = error)
uint16_t packetSize;    // expected DMP packet size (default is 42 bytes)
uint16_t fifoCount;     // count of all bytes currently in FIFO
uint8_t fifoBuffer[64]; // FIFO storage buffer

// orientation/motion vars
Quaternion q;           // [w, x, y, z]         quaternion container
VectorInt16 aa;         // [x, y, z]            accel sensor measurements
VectorInt16 aaReal;     // [x, y, z]            gravity-free accel sensor measurements
VectorInt16 aaWorld;    // [x, y, z]            world-frame accel sensor measurements
VectorFloat gravity;    // [x, y, z]            gravity vector
float euler[3];         // [psi, theta, phi]    Euler angle container
float ypr[3];           // [yaw, pitch, roll]   yaw/pitch/roll container and gravity vector


// packet structure for InvenSense teapot demo
uint8_t teapotPacket[14] = { '$', 0x02, 0, 0, 0, 0, 0, 0, 0, 0, 0x00, 0x00, '\r', '\n' };



// ================================================================
// ===               INTERRUPT DETECTION ROUTINE                ===
// ================================================================

volatile bool mpuInterrupt = false;     // indicates whether MPU interrupt pin has gone high
void dmpDataReady() {
  mpuInterrupt = true;
}

// ================================================================
// ===                     SETUP (BILLY)                 ===
// ================================================================

#include<Servo.h>
Servo motor[2];

//set throttle high... thrust pwm is not linear at early throttle
int throttle = 1350;
double roll_signal = 0.0;

int pwm_min = 1200;
int pwm_max = 1450;

double roll = 0.0;
double roll_t = 0.0;

double roll_rate = 0.0;
double roll_rate_t = 0.0;


int gyro_xyz[3];           // [yaw, pitch, roll]

#include "PID.h"
PIDController pid(0.5, 0.00, 3.3, 1, 1); // Roll_rate: 0.5, 0.02, 4, 1, 2
PIDController pid2(1.7, 0.02, 0, 1, 1); //Roll: 1.7, 0.02, 1.6

/*const int RecorderNumber = 50;
int data_roll[RecorderNumber];
int data_roll_rate[RecorderNumber];
int data_command[RecorderNumber];
float data_time[RecorderNumber];*/

float t0 = millis() / 1000.0 ;

//int counter = 0;

boolean up = true;
//int test_seq[] = {0,0,0, -5, 5, 10, -20, -30, 30, 10, 0, 25, 0, -30, 30, 0};  
int test_seq[] = {0,0,0,10,10, 10, 10, 10,10, 10, 10, 10, 10, 10, 10, 10};  
int test_index = 0;
int test_max = 16;

float tCommand = millis() / 1000.0;
int counter = 0;



// ================================================================
// ===                      INITIAL SETUP                       ===
// ================================================================

void setup() {

  Serial.begin(115200);

  // ARM MOTOR
  attachMotor(6, 7);
  writeAll(1150);
  Serial.println("ARM!");

  // join I2C bus (I2Cdev library doesn't do this automatically)
#if I2CDEV_IMPLEMENTATION == I2CDEV_ARDUINO_WIRE
  Wire.begin();
  TWBR = 24; // 400kHz I2C clock (200kHz if CPU is 8MHz)
#elif I2CDEV_IMPLEMENTATION == I2CDEV_BUILTIN_FASTWIRE
  Fastwire::setup(400, true);
#endif


  // initialize device
  Serial.println(F("Initializing I2C devices..."));
  mpu.initialize();

  // verify connection
  Serial.println(F("Testing device connections..."));
  Serial.println(mpu.testConnection() ? F("MPU6050 connection successful") : F("MPU6050 connection failed"));

  // wait for ready
  Serial.println(F("\nSend any character to begin DMP programming and demo: "));
  while (Serial.available() && Serial.read()); // empty buffer
  while (!Serial.available());                 // wait for data
  while (Serial.available() && Serial.read()); // empty buffer again

  // load and configure the DMP
  Serial.println(F("Initializing DMP..."));
  devStatus = mpu.dmpInitialize();

  // supply your own gyro offsets here, scaled for min sensitivity
  mpu.setXGyroOffset(-70);
  mpu.setYGyroOffset(-40);
  mpu.setZGyroOffset(80);
  mpu.setZAccelOffset(1788); // 1688 factory default for my test chip

  // make sure it worked (returns 0 if so)
  if (devStatus == 0) {
    // turn on the DMP, now that it's ready
    Serial.println(F("Enabling DMP..."));
    mpu.setDMPEnabled(true);

    // enable Arduino interrupt detection
    Serial.println(F("Enabling interrupt detection (Arduino external interrupt 0)..."));
    attachInterrupt(0, dmpDataReady, RISING);
    mpuIntStatus = mpu.getIntStatus();

    // set our DMP Ready flag so the main loop() function knows it's okay to use it
    Serial.println(F("DMP ready! Waiting for first interrupt..."));
    dmpReady = true;

    // get expected DMP packet size for later comparison
    packetSize = mpu.dmpGetFIFOPacketSize();
  } else {
    // ERROR!
    // 1 = initial memory load failed
    // 2 = DMP configuration updates failed
    // (if it's going to break, usually the code will be 1)
    Serial.print(F("DMP Initialization failed (code "));
    Serial.print(devStatus);
    Serial.println(F(")"));
  }

  // configure LED for output
  pinMode(LED_PIN, OUTPUT);

}



// ================================================================
// ===                    MAIN PROGRAM LOOP                     ===
// ================================================================

void loop() {
  // if programming failed, don't try to do anything
  if (!dmpReady) return;

  if (Serial.available() > 0)
  {
    char data = Serial.read();

    if (data == '0')
    {
      pid2.Kp += 0.1;
      Serial.print("Kp: ");
      Serial.println(pid2.Kp);
    }
    else if (data == ';')
    {
      pid2.Kp -= 0.1;
      Serial.print("Kp: ");
      Serial.println(pid2.Kp);
    }

    if (data == 'e')
    {
      pid2.Kd += 0.1;
      Serial.print("Kd: ");
      Serial.println(pid2.Kd);
    }
    else if (data == 'c')
    {
      pid2.Kd -= 0.1;
      Serial.print("Kd: ");
      Serial.println(pid2.Kd);
    }


    if (data == '8')
    {
      pid2.Ki += 0.01;
      Serial.print("Ki: ");
      Serial.println(pid2.Ki);
    }
    else if (data == 'k')
    {
      pid2.Ki -= 0.01;
      Serial.print("Ki: ");
      Serial.println(pid2.Ki);
    }

    if (data == '5')
    {
      roll_t += 5;
      //Serial.print("Target: ");
      //Serial.println(roll_t);
    }
    else if (data == 'g')
    {
      roll_t -= 5;
      //Serial.print("Target: ");
      //Serial.println(roll_t);
    }

    /*if (data == 'q')
      for (int i = 0; i < RecorderNumber; i++)
      {
        Serial.print(data_time[i]);
        Serial.print(" ");
        Serial.print(data_command[i]);
        Serial.print(" ");
        Serial.print(data_roll[i]);
        Serial.print(" ");
        Serial.println(data_roll_rate[i]);
      }*/
  }

  // wait for MPU interrupt or extra packet(s) available
  while (!mpuInterrupt && fifoCount < packetSize) {

    //When Data is not Available

  }

  // reset interrupt flag and get INT_STATUS byte
  mpuInterrupt = false;
  mpuIntStatus = mpu.getIntStatus();

  // get current FIFO count
  fifoCount = mpu.getFIFOCount();

  // check for overflow (this should never happen unless our code is too inefficient)
  if ((mpuIntStatus & 0x10) || fifoCount == 1024) {
    // reset so we can continue cleanly
    mpu.resetFIFO();
    Serial.println(F("FIFO overflow!"));

    // otherwise, check for DMP data ready interrupt (this should happen frequently)
  } else if (mpuIntStatus & 0x02) {
    // wait for correct available data length, should be a VERY short wait
    while (fifoCount < packetSize) fifoCount = mpu.getFIFOCount();

    // read a packet from FIFO
    mpu.getFIFOBytes(fifoBuffer, packetSize);

    // track FIFO count here in case there is > 1 packet available
    // (this lets us immediately read more without waiting for an interrupt)
    fifoCount -= packetSize;


    // display Euler angles in degrees
    mpu.dmpGetQuaternion(&q, fifoBuffer);
    mpu.dmpGetGravity(&gravity, &q);
    mpu.dmpGetYawPitchRoll(ypr, &q, &gravity);

    mpu.dmpGetGyro(gyro_xyz, fifoBuffer);

    roll = ypr[2] * 180 / M_PI;
    roll_rate = gyro_xyz[0];

    if (abs(roll) > 80 || abs(roll_rate) > 300)
      return;

    roll_rate_t = pid2.getSignal(roll_t, roll);
    roll_signal = pid.getSignal(roll_rate_t, roll_rate);
    pidOut();

    //Recorder
    /*if (counter < RecorderNumber)
    {
      data_roll[counter] = roll;
      data_roll_rate[counter] = roll_rate;
      data_command[counter] = roll_t;
      data_time[counter] = (millis() / 1000.0) - t0;;
      counter ++;
    }*/
    
    
    // Comand Ramp
    
   if ((millis()/1000.0 - tCommand) > 2)
      {
         /*if (up == true)
            roll_t += 1; 
         else if (up == false)
            roll_t -= 1;
            
         if (roll_t > 30)
           up = false;
         else if (roll_t < -30)
           up = true;*/
           
           if (test_index < test_max)
             roll_t = test_seq[test_index];
           
           test_index ++;
           
           
         tCommand = millis() / 1000.0;
      }
    
    // Print Out
    counter++;
    if (millis()/1000.0 - t0 > 0.1)
      {
        Serial.print((millis()-t0)/1000.0);
        Serial.print(" ");
        Serial.print(roll_t);
        Serial.print(" ");
        Serial.print(roll);
        Serial.print(" ");
        Serial.print(roll_rate);
        Serial.print(" ");
        Serial.print(pid2.Kp);
        Serial.print(" ");
        Serial.print(pid2.Ki);
        Serial.print(" ");
        Serial.print(pid2.Kd);
        
        double frequency = counter / 0.1;
        counter = 0;
        Serial.print(" ");
        Serial.println(frequency);
        
        t0 = millis() / 1000.0;
      }


    // blink LED to indicate activity
    blinkState = !blinkState;
    digitalWrite(LED_PIN, blinkState);
    
    
   /* if (up)
      roll_t += 0.5;
    else
      roll_t -= 0.5;
      
    if(roll_t > 30.0)
      up = false;
    else if(roll_t < -30.0)
      up = true;*/
  }
}

//////////////////////////////// BILLY FUNCTIONS /////////////////////////////////////

void attachMotor(int _m0, int _m1)
{
  motor[0].attach(_m0);
  motor[1].attach(_m1);
}

void writeChannel(int channel, int pwm)
{
  int pos = map(pwm, 1000, 2000, 0, 179);
  motor[channel].write(pos);
}

void writeAll(int pwm)
{
  for (int i = 0; i < 2; i++)
    writeChannel(i, pwm);
}

void pidOut()
{
  double pid_signal[3] = {roll_signal, 0, 0};

  //Serial.print("M0: ");
  writeChannel(0, pidMix(-1, 0, 1, pid_signal, throttle));
  //Serial.print("M1: ");
  writeChannel(1, pidMix(1, 0, 1, pid_signal, throttle));
}

int pidMix( double x, double y, double z, double* pid_signal, double throttle)
{
  int pwm = throttle + pid_signal[0] * x + pid_signal[1] * y + pid_signal[2] * z;

  if (pwm < pwm_min)
    pwm = pwm_min;
  else if (pwm > pwm_max)
    pwm = pwm_max;
  //Serial.println(pwm);
  return pwm;
}
