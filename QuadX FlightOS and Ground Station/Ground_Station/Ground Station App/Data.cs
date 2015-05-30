/*
 * Created by SharpDevelop.
 * User: Billwaa
 * Date: 1/13/2015
 * Time: 1:04 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ground_Station_App
{
	/// <summary>
	/// Description of Data.
	/// </summary>
	public class Data
	{
		
		public bool overrideMode;
		public bool armMode;
		
		public double time;
	
		public double roll;
		public double pitch;
		public double yaw;
    
		public double roll_d;
		public double pitch_d;
		public double yaw_d;
	
		public double roll_t;
		public double pitch_t;
		public double yaw_t;
	
		public double roll_d_t;
		public double pitch_d_t;
		public double yaw_d_t;
	
		public double roll_signal;
		public double pitch_signal;
		public double yaw_signal;
	
		public double Kp_r;
		public double Ki_r;
		public double Kd_r;
	
		public double Kp_p;
		public double Ki_p;
		public double Kd_p;
	
		public double Kp_y;
		public double Ki_y;
		public double Kd_y;
	
		public double Kp_r_d;
		public double Ki_r_d;
		public double Kd_r_d;
	
		public double Kp_p_d;
		public double Ki_p_d;
		public double Kd_p_d;
	
		public double Kp_y_d;
		public double Ki_y_d;
		public double Kd_y_d;
	
		public int throttle;

		public int height;
		public int height_t;
		
		public double longitude;
		public double latitude;
		
		public double longitude_t;
		public double latitude_t;
        
		public double Kp_h;
		public double Ki_h;
		public double Kd_h;
		public double Kr_h;
		
		public double Kp_lon;
		public double Ki_lon;
		public double Kd_lon;
		
		public double Kp_lat;
		public double Ki_lat;
		public double Kd_lat;
	
		public int motor0_pwm;
		public int motor1_pwm;
		public int motor2_pwm;
		public int motor3_pwm;
		
		public Data()
		{
			
			overrideMode = false;
			armMode = false;
			
			time  = 0.0;
			
			roll = 0.0;
			pitch = 0.0;
			yaw = 0.0;
	
			roll_d = 0.0;
			pitch_d = 0.0;
			yaw_d = 0.0;
	
			roll_t = 0.0;
			pitch_t = 0.0;
			yaw_t = 0.0;
	
			roll_d_t = 0.0;
			pitch_d_t = 0.0;
			yaw_d_t = 0.0;
	
			roll_signal = 0.0;
			pitch_signal = 0.0;
			yaw_signal = 0.0;
	
			Kp_r = 1.7;
			Ki_r = 0.0;
			Kd_r = 0.0;
	
			Kp_p = 1.7;
			Ki_p = 0.0;
			Kd_p = 0.0;
	
			Kp_y = 0.0;
			Ki_y = 0.0;
			Kd_y = 0.0;
	
			Kp_r_d = 0.5;
			Ki_r_d = 0.1;
			Kd_r_d = 0.3;
	
			Kp_p_d = 0.5;
			Ki_p_d = 0.1;
			Kd_p_d = 0.3;
	
			Kp_y_d = 1.5;
			Ki_y_d = 0.5;
			Kd_y_d = 0.3;
	
			throttle = 1250;

			height = 0;
			height_t = 25;
			
			longitude = 0;
			latitude = 0;
			
			longitude_t = 0;
			latitude_t = 0;
        
			Kp_h = 1.5;
			Ki_h = 1.2;
			Kd_h = 0.11;
			Kr_h = 0.0;
			
			Kp_lon = 0.0;
			Ki_lon = 0.0;
			Kd_lon = 0.0;
		
			Kp_lat = 0.0;
			Ki_lat = 0.0;
			Kd_lat = 0.0;
	
			motor0_pwm = 1000;
			motor1_pwm = 1000;
			motor2_pwm = 1000;
			motor3_pwm = 1000;
		}
		
		
	}
}
