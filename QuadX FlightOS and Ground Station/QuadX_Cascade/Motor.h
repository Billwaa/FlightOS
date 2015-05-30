#ifndef Motor_h
#define Motor_h

#include <Arduino.h>
#include <Servo.h>
#include "Data.h"

class Motor
{
  private:
    int motorNum;
    Servo motor[4];

  public:
    Motor( int _pin0, int _pin1, int _pin2, int _pin3);
    void writeChannel(int _pin, int _pwm);
    void writeAll(int _pwm);
    void writePWM(Data& data);
};

#endif
