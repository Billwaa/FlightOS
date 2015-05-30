#include <Arduino.h>
#include <Servo.h>
#include "Motor.h"
#include "Data.h"

Motor::Motor( int _pin0, int _pin1, int _pin2, int _pin3)
{
	motorNum = 4;
	motor[0].attach(_pin0);
	motor[1].attach(_pin1);
	motor[2].attach(_pin2);
	motor[3].attach(_pin3);
}

void Motor::writeChannel(int _channel, int _pwm)
{
	motor[_channel].writeMicroseconds(_pwm);
}

void Motor::writeAll(int _pwm)
{
	for (int i = 0; i < motorNum; i++)
	writeChannel(i, _pwm);
}

void Motor::writePWM(Data& data)
{
	int _pwm[4] = {data.motor0_pwm, data.motor1_pwm, data.motor2_pwm, data.motor3_pwm};
	for (int i = 0; i < motorNum; i++)
	writeChannel(i, _pwm[i]);
}
