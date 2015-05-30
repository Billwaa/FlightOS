// FlightController.h

#ifndef _FLIGHTCONTROLLER_h
#define _FLIGHTCONTROLLER_h

#include "Arduino.h"
#include "Data.h"
#include "PID.h"

class FlightController
{
 private:
	PIDController controller_roll;
	PIDController controller_pitch;
	PIDController controller_yaw;
	
	PIDController controller_roll_rate;
	PIDController controller_pitch_rate;
	PIDController controller_yaw_rate;	
	
 public:
	FlightController(Data& data);
	void getSignal(Data& data);
	void setGains(Data& data);
	void reset();
	
};


#endif

