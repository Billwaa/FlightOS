// Yu Hin Hau
// QuadX FlightOS
// Spring 2015

#include "FlightController.h"
#include "Data.h"
#include "IMU.h"
#include "PID.h"
#include "FlightMixer.h"
#include "COMM.h"
#include <Servo.h>

////////////////////// RF Reader Setup /////////////////////////////
//assume that pin 32 is receiving PWM input
#define CHANNEL_1_PIN 7 // roll
#define CHANNEL_2_PIN 6 // pitch
#define CHANNEL_3_PIN 5 // throttle
#define CHANNEL_4_PIN 4 // yaw
#define CHANNEL_5_PIN 3 // switch 1
#define CHANNEL_6_PIN 2 // switch 2

//micros when the pin goes HIGH
volatile unsigned long timer_start1;
volatile unsigned long timer_start2;
volatile unsigned long timer_start3;
volatile unsigned long timer_start4;
volatile unsigned long timer_start5;
volatile unsigned long timer_start6;

//difference between timer_start and micros() is the length of time that the pin 
//was HIGH - the PWM pulse length. 
volatile int pulse_time1; 
volatile int pulse_time2;
volatile int pulse_time3;
volatile int pulse_time4;
volatile int pulse_time5;
volatile int pulse_time6;

//this is the time that the last interrupt occurred. 
//you can use this to determine if your receiver has a signal or not.
volatile int last_interrupt_time1;
volatile int last_interrupt_time2;
volatile int last_interrupt_time3;
volatile int last_interrupt_time4;
volatile int last_interrupt_time5;
volatile int last_interrupt_time6;



//calcSignal is the interrupt handler
void calcSignal1()
{
//record the interrupt time so that we can tell if the receiver has a signal from the transmitter
 last_interrupt_time1 = micros();

//if the pin has gone HIGH, record the microseconds since the Arduino started up
 if(digitalRead(CHANNEL_1_PIN) == HIGH)
    {
        timer_start1 = micros();
    }
//otherwise, the pin has gone LOW
    else
    {
        //only worry about this if the timer has actually started
        if(timer_start1 > 0)
        {
            //record the pulse time
            pulse_time1 = ((volatile int)micros() - timer_start1);
            //restart the timer
            timer_start1 = 0;
        }
    }
}

//calcSignal is the interrupt handler
void calcSignal2()
{
//record the interrupt time so that we can tell if the receiver has a signal from the transmitter
 last_interrupt_time2 = micros();

//if the pin has gone HIGH, record the microseconds since the Arduino started up
 if(digitalRead(CHANNEL_2_PIN) == HIGH)
    {
        timer_start2 = micros();
    }
//otherwise, the pin has gone LOW
    else
    {
        //only worry about this if the timer has actually started
        if(timer_start2 > 0)
        {
            //record the pulse time
            pulse_time2 = ((volatile int)micros() - timer_start2);
            //restart the timer
            timer_start2 = 0;
        }
    }
}

//calcSignal is the interrupt handler
void calcSignal3()
{
//record the interrupt time so that we can tell if the receiver has a signal from the transmitter
 last_interrupt_time3 = micros();

//if the pin has gone HIGH, record the microseconds since the Arduino started up
 if(digitalRead(CHANNEL_3_PIN) == HIGH)
    {
        timer_start3 = micros();
    }
//otherwise, the pin has gone LOW
    else
    {
        //only worry about this if the timer has actually started
        if(timer_start3 > 0)
        {
            //record the pulse time
            pulse_time3 = ((volatile int)micros() - timer_start3);
            //restart the timer
            timer_start3 = 0;
        }
    }
}

//calcSignal is the interrupt handler
void calcSignal4()
{
//record the interrupt time so that we can tell if the receiver has a signal from the transmitter
 last_interrupt_time4 = micros();

//if the pin has gone HIGH, record the microseconds since the Arduino started up
 if(digitalRead(CHANNEL_4_PIN) == HIGH)
    {
        timer_start4 = micros();
    }
//otherwise, the pin has gone LOW
    else
    {
        //only worry about this if the timer has actually started
        if(timer_start4 > 0)
        {
            //record the pulse time
            pulse_time4 = ((volatile int)micros() - timer_start4);
            //restart the timer
            timer_start4 = 0;
        }
    }
}

//calcSignal is the interrupt handler
void calcSignal5()
{
//record the interrupt time so that we can tell if the receiver has a signal from the transmitter
 last_interrupt_time5 = micros();

//if the pin has gone HIGH, record the microseconds since the Arduino started up
 if(digitalRead(CHANNEL_5_PIN) == HIGH)
    {
        timer_start5 = micros();
    }
//otherwise, the pin has gone LOW
    else
    {
        //only worry about this if the timer has actually started
        if(timer_start5 > 0)
        {
            //record the pulse time
            pulse_time5 = ((volatile int)micros() - timer_start5);
            //restart the timer
            timer_start5 = 0;
        }
    }
}

//calcSignal is the interrupt handler
void calcSignal6()
{
//record the interrupt time so that we can tell if the receiver has a signal from the transmitter
 last_interrupt_time6 = micros();

//if the pin has gone HIGH, record the microseconds since the Arduino started up
 if(digitalRead(CHANNEL_6_PIN) == HIGH)
    {
        timer_start6 = micros();
    }
//otherwise, the pin has gone LOW
    else
    {
        //only worry about this if the timer has actually started
        if(timer_start6 > 0)
        {
            //record the pulse time
            pulse_time6 = ((volatile int)micros() - timer_start6);
            //restart the timer
            timer_start6 = 0;
        }
    }
}
//////////////////////////////////////////////////////////////////////////////////

Data data;
IMU imu;
FlightController control(data);
FlightMixerClass mixer("QuadX",1250,1700);
Servo motor[4];

long t0;
int sample;

boolean reported;

boolean arm = false;

int counter = 0;

int ultrasonic_pin = 0;

double t = millis()/1000.0;

boolean height_control = false;

PIDController controller_height;

double t_height = millis() / 1000.0;

COMM com;

long attitudeControlTimer = millis();

///////////////////////////////////////////////////////////////////////////////
void setup()
{
	// Open Serial Port
	Serial.begin(115200);
	Serial1.begin(115200);
    Serial3.begin(57600);
    //Serial3.begin(115200)

	// Calibrate IMU
	imu.calibrate();
	
	// Attach Motor
	attachMotor(22,24,26,28);
	writeAll(1000);
	
	Serial.println("MOTOR ARMED!!!!");
	delay(3000);
	writeAll(1200);
	delay(2000);

        controller_height.init( data.Kp_h, data.Ki_h, data.Kd_h, 3, 5, 50);

	t0 = millis();
	sample = 0;
	reported = false;
	control.reset();
        

    // RF Reader Setup //
    timer_start1 = 0;
    timer_start2 = 0;
    timer_start3 = 0;
    timer_start4 = 0;
    timer_start5 = 0;
    timer_start6 = 0;
    attachInterrupt(CHANNEL_1_PIN, calcSignal1, CHANGE);
    attachInterrupt(CHANNEL_2_PIN, calcSignal2, CHANGE);
    attachInterrupt(CHANNEL_3_PIN, calcSignal3, CHANGE);
    attachInterrupt(CHANNEL_4_PIN, calcSignal4, CHANGE);
    attachInterrupt(CHANNEL_5_PIN, calcSignal5, CHANGE);
    attachInterrupt(CHANNEL_6_PIN, calcSignal6, CHANGE);
}

void loop()
{
		// Radio Command
		if (!data.overrideMode)
			parseRF();
		
		// Request Data from IMU
		if(millis() - attitudeControlTimer >= 5)
		{
			imu.requestData();
			attitudeControlTimer = millis();				
		}

                // Altitude Control
                data.height = getUltrasonic();
                
                if (height_control && (millis()/1000.0 - t_height) > 0.1)
                  {                    
                    data.throttle = controller_height.getSignal( data.height_t, data.height) + 1350;
                    t_height = millis() / 1000.0;
                    //Serial.println(throttle);
                  }                 
				

                /*long t0 = millis();
                com.downlink(data);
                Serial.println(millis()-t0);*/

		// Request PWM Values
		mixer.getPWM(data);

                
		
		// Output PWM
                if (arm)
		  writePWM(data);
                else
                  writeAll(1000);
     
                
                //delay(5);
		delay(1);
	

}
//////////////////////////////////////////////////////////////////////////////////

void parseRF()
{
  if (pulse_time1 > 1000 && pulse_time1 < 2000)
    data.roll_t = map(pulse_time1,1000,2000,-45,45);
	//data.roll_d_t = map(pulse_time1,1000,2000,-45,45);
  
  if (pulse_time2 > 1000 && pulse_time2 < 2000)
    data.pitch_t = map(pulse_time2,1000,2000,-45,45);
	//data.pitch_d_t = map(pulse_time2,1000,2000,-45,45);
    
  if (pulse_time3 > 1000 && pulse_time3 < 2000)
  { 
    if (!  height_control) 
      data.throttle = map(pulse_time3,1100,1900,1200,1600);
    
    data.height_t = map(pulse_time3,1100,1900,20,60);
  }
    
  if (pulse_time4 > 1000 && pulse_time4 < 2000)
    data.yaw_d_t = map(pulse_time4,1000,2000,-50,50);
    
  if (pulse_time5 > 800 && pulse_time5 < 2200);
    if(pulse_time5 > 1700)
      arm = true;
    else 
      arm = false;
  
  if (pulse_time6 > 800 && pulse_time6 < 2200)
    if(pulse_time6 > 1700)
      height_control = true;
    else 
      height_control = false;
    
  /*
  //4 Ch Motor Arm
  if (pulse_time3 < 1150 && pulse_time4 < 1100)
    arm = true;
  else if (pulse_time3 < 1150 && pulse_time4 > 1900)
    arm = false;*/
    
   

}

void serialEvent3()
{
	com.parseCommand(data);
	control.setGains(data);
}


void serialEvent1()
{
	if(imu.checkIMU(data))
        {
        // Request Control Signal
        control.getSignal(data);
	sample++;
        }
}

int getUltrasonic()
{
  // Mount Sensor On Arduino Board
  // Vibration / Magnetic field from Motor and Power Cable
  // Make Sensor Useless, thanks Nate for solving problems
  
  int range = analogRead(ultrasonic_pin); // cm
  
  if (range > 0 && range < 500)
    return range;
  else
    return 0;
}

void printData()
{
	Serial.println("~~~~~~~~~~~~~~~~~~~~~~~");
        Serial.print("RPY: ");
	Serial.print(data.roll); Serial.print(" ");
	Serial.print(data.pitch); Serial.print(" ");
	Serial.println(data.yaw);

        Serial.print("RPY_d: ");
	Serial.print(data.roll_d); Serial.print(" ");
	Serial.print(data.pitch_d); Serial.print(" ");
	Serial.println(data.yaw_d); 

        Serial.print("Gains: ");
	Serial.print(data.Kp_h); Serial.print(" ");
	Serial.print(data.Ki_h); Serial.print(" ");
	Serial.println(data.Kd_h);
	
        Serial.print("RPY_Signal: ");
	Serial.print(data.roll_signal); Serial.print(" ");
	Serial.print(data.pitch_signal); Serial.print(" ");
	Serial.println(data.yaw_signal);
	
        Serial.print("Motor_PWM: ");
	Serial.print(data.motor0_pwm); Serial.print(" ");
	Serial.print(data.motor1_pwm); Serial.print(" ");
	Serial.print(data.motor2_pwm); Serial.print(" ");
	Serial.println(data.motor3_pwm);

        Serial.print("RF: ");
        Serial.print(pulse_time1); Serial.print(" ");        
        Serial.print(pulse_time2); Serial.print(" ");        
        Serial.print(pulse_time3); Serial.print(" ");        
        Serial.print(pulse_time4); Serial.print(" ");
        Serial.print(pulse_time5); Serial.print(" ");
        Serial.println(pulse_time6);
        
        Serial.print("RPY_t: ");
        Serial.print(data.roll_t); Serial.print(" ");        
        Serial.print(data.pitch_t); Serial.print(" ");        
        Serial.print(data.yaw_d_t); Serial.print(" ");        
        Serial.println(data.throttle);
        
        Serial.print("Height_t: "); Serial.println(data.height_t);
        Serial.print("Height: "); Serial.println(data.height);
        
        Serial.print("Arm: "); Serial.println(arm);
        Serial.print("Height Control: "); Serial.println(height_control);
	Serial.println("~~~~~~~~~~~~~~~~~~~~~~~");
}

void printDataXBEE()
{        
        Serial3.print("RPY: ");
	Serial3.print(data.roll); Serial3.print(" ");
	Serial3.print(data.pitch); Serial3.print(" ");
	Serial3.println(data.yaw);

        Serial3.print("Gains: ");
	Serial3.print(data.Kp_h); Serial3.print(" ");
	Serial3.print(data.Ki_h); Serial3.print(" ");
	Serial3.println(data.Kd_h);

        Serial3.print("Height_t: "); Serial3.println(data.height_t);
        Serial3.print("Height: "); Serial3.println(data.height);
        
        Serial3.print("Arm: "); Serial3.println(arm);
        Serial3.print("Height Control: "); Serial3.println(height_control);
	Serial3.println("\n\n\n");
}

void attachMotor(int _m0, int _m1, int _m2, int _m3)
{
	motor[0].attach(_m0);
	motor[1].attach(_m1);
	motor[2].attach(_m2);
	motor[3].attach(_m3);
}

void writeChannel(int channel, int pwm)
{
	motor[channel].writeMicroseconds(pwm);
}

void writeAll(int pwm)
{
	for (int i = 0; i < 4; i++)
	writeChannel(i,pwm);
}

void writePWM(Data& data)
{
	writeChannel(0, data.motor0_pwm);
	writeChannel(1, data.motor1_pwm);
	writeChannel(2, data.motor2_pwm);
	writeChannel(3, data.motor3_pwm);
}
