
#include "FlightController.h"
#include "PID.h"

FlightController::FlightController(Data& data)
{
  	controller_roll.init( data.Kp_r, data.Ki_r, data.Kd_r, 1, 1, 200);
	controller_pitch.init( data.Kp_p, data.Ki_p, data.Kd_p, 1, 1, 500);
	//controller_yaw.init( data.Kp_y, data.Ki_y, data.Kd_y_d, 1, 3, 250);

	controller_roll_rate.init( data.Kp_r_d, data.Ki_r_d, data.Kd_r_d, 3, 1, 100);
	controller_pitch_rate.init( data.Kp_p_d, data.Ki_p_d, data.Kd_p_d, 3, 1, 100);
	controller_yaw_rate.init( data.Kp_y_d, data.Ki_y_d, data.Kd_y_d, 3, 1, 100);
}

void FlightController::getSignal(Data& data)
{
    data.roll_d_t = controller_roll.getSignal( data.roll_t, data.roll, data.roll_d);
	data.pitch_d_t = controller_pitch.getSignal( data.pitch_t, data.pitch, data.pitch_d);
	//data.yaw_d_t = controller_yaw.getSignal( data.yaw_t, data.yaw);     
  
	data.roll_signal = controller_roll_rate.getSignal( data.roll_d_t, data.roll_d);
	data.pitch_signal = controller_pitch_rate.getSignal( data.pitch_d_t, data.pitch_d);
	data.yaw_signal = controller_yaw_rate.getSignal( data.yaw_d_t, data.yaw_d);
}

void FlightController::setGains(Data& data)
{
  	controller_roll.setGains( data.Kp_r, data.Ki_r, data.Kd_r);
	controller_pitch.setGains( data.Kp_p, data.Ki_p, data.Kd_p);
	controller_yaw.setGains( data.Kp_y, data.Ki_y, data.Kd_y);
  
	controller_roll_rate.setGains( data.Kp_r_d, data.Ki_r_d, data.Kd_r_d);
	controller_pitch_rate.setGains( data.Kp_p_d, data.Ki_p_d, data.Kd_p_d);
	controller_yaw_rate.setGains( data.Kp_y_d, data.Ki_y_d, data.Kd_y_d);
}

void FlightController::reset()
{
  	controller_roll.reset();
	controller_pitch.reset();
	controller_yaw.reset();
  
	controller_roll_rate.reset();
	controller_pitch_rate.reset();
	controller_yaw_rate.reset();
}




