// PID.h

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

        int iLimit;


 public:
 	
	double Kp;
	double Ki;
	double Kd;
	
	PIDController();
	PIDController(double _Kp, double _Ki, double _Kd, int PFilter_term, int DFilter_term, int Integral_limit);
	void init(double _Kp, double _Ki, double _Kd, int PFilter_term, int DFilter_term, int Integral_limit);
	double getSignal(double input_value, double sensor_value);
        double getSignal(double input_value, double sensor_value, double sensor_rate_value);
	void setGains(double _Kp, double _Ki, double _Kd);
	void reset();
};


#endif

