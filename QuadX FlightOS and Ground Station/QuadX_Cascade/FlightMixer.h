// FlightMixer.h

#ifndef _FLIGHTMIXER_h
#define _FLIGHTMIXER_h

#if defined(ARDUINO) && ARDUINO >= 100
	#include "Arduino.h"
#else
	#include "WProgram.h"
#endif

#include "Data.h"

class FlightMixerClass
{
 private:
	int mode;
	int pwm_min;
	int pwm_max;

 public:
	FlightMixerClass();
	FlightMixerClass(String _mode, int _pwm_min, int _pwm_max);
	int pidMix( double x, double y, double z, double* pid_signal,double throttle);
	void getPWM(Data& data);

};

extern FlightMixerClass FlightMixer;

#endif

