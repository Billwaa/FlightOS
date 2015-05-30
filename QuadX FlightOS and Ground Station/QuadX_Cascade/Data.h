
#ifndef _Data_h
#define _Data_h


class Data
{
	public:
	
	bool overrideMode;
	bool armMode;
	
	float roll;
	float pitch;
	float yaw;
	
	float roll_d;
	float pitch_d;
	float yaw_d;
	
	float roll_t;
	float pitch_t;
	float yaw_t;
	
	float roll_d_t;
	float pitch_d_t;
	float yaw_d_t;
	
	float roll_signal;
	float pitch_signal;
	float yaw_signal;
	
	float Kp_r;
	float Ki_r;
	float Kd_r;
	float Kr_r;
	
	float Kp_p;
	float Ki_p;
	float Kd_p;
	float Kr_p;
	
	float Kp_y;
	float Ki_y;
	float Kd_y;
	float Kr_y;
	
	float Kp_r_d;
	float Ki_r_d;
	float Kd_r_d;
	float Kr_r_d;
	
	float Kp_p_d;
	float Ki_p_d;
	float Kd_p_d;
	float Kr_p_d;
	
	float Kp_y_d;
	float Ki_y_d;
	float Kd_y_d;
	float Kr_y_d;
	
	int throttle;

	int height;
	int height_t;
	
	float Kp_h;
	float Ki_h;
	float Kd_h;
	float Kr_h;

	float longitude;
	float longitude_t;
	
	float latitude;
	float latitude_t;
	
	float Kp_lon;
	float Ki_lon;
	float Kd_lon;
	
	float Kp_lat;
	float Ki_lat;
	float Kd_lat;
	
	int motor0_pwm;
	int motor1_pwm;
	int motor2_pwm;
	int motor3_pwm;
	int motor4_pwm;
	int motor5_pwm;
	
	Data();
};

#endif