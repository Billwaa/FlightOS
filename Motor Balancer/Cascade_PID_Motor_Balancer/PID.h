// PID.h

// Yu Hin Hau
// PID Controller Module
// Spring 2015

#ifndef _PID_h
#define _PID_h

#if defined(ARDUINO) && ARDUINO >= 100
	#include "Arduino.h"
#else
	#include "WProgram.h"
#endif

class PIDController
{
 private:
	
	double integral;
	double error_old;
	
	int InputFilter_term;
	int DFilter_term;
	
	double dTerm[5];
	double iTerm[5];


 public:
 	
	double Kp;
	double Ki;
	double Kd;
	
	PIDController(double _Kp, double _Ki, double _Kd, int PFilter_term, int DFilter_term);
	double getSignal(double input_value, double sensor_value);
};


#endif

