#include "Data.h"

Data::Data()
{
	overrideMode = false;
	armMode = false;
	
	roll = 1.1;
	pitch = 2.2;
	yaw = 3.3;
	
	roll_d = 4.4;
	pitch_d = 5.5;
	yaw_d = 6.6;
	
	roll_t = 0.0;
	pitch_t = 0.0;
	yaw_t = 0.0;
	
	roll_d_t = 0.0;
	pitch_d_t = 0.0;
	yaw_d_t = 0.0;
	
	roll_signal = 0.0;
	pitch_signal = 0.0;
	yaw_signal = 0.0;
	
	Kp_r = 1.7;//1.7;
	Ki_r = 0.02;
	Kd_r = 0.0;
	Kr_r = 0.0;
	
	Kp_p = 1.7;//1.7;
	Ki_p = 0.02;
	Kd_p = 0.0;
	Kr_p = 0.0;
	
	Kp_y = 0.0;
	Ki_y = 0.0;
	Kd_y = 0.0;
	Kr_y = 0.0;
	
	Kp_r_d = 0.5;//0.5;
	Ki_r_d = 0;//0.1;
	Kd_r_d = 3.3;//7.3;
	Kr_r_d = 0.0;
	
	Kp_p_d = 0.5;//0.5;
	Ki_p_d = 0.03;//0.1;
	Kd_p_d = 3.3;//7.3;
	Kr_p_d = 0.0;
	
	Kp_y_d = 1.5;//1.5;
	Ki_y_d = 0.5;//0.5;
	Kd_y_d = 0.3;//0.3;
	Kr_y_d = 0.0;
	
	throttle = 1250;

	height = 0;
	height_t = 25;
	
	Kp_h = 1.5;
	Ki_h = 1.2;
	Kd_h = 0.11;
	Kr_h = 0.0;
	
	motor0_pwm = 1000;
	motor1_pwm = 1000;
	motor2_pwm = 1000;
	motor3_pwm = 1000;
	motor4_pwm = 1000;
	motor5_pwm = 1000;
}
