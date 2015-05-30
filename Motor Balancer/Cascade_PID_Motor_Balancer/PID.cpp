//
//
//
// Yu Hin Hau
// PID Controller Module
// Spring 2015

#include "Arduino.h"
#include "PID.h"

PIDController::PIDController(double _Kp, double _Ki, double _Kd, int InputFilter, int DFilter)
{
	InputFilter_term = InputFilter;
	DFilter_term = DFilter;
	
	Kp = _Kp;
	Ki = _Ki;
	Kd = _Kd;
	
	integral = 0.0;
	error_old = 0.0;
	
	for (int i = 0; i < 5; i++)
	{
		iTerm[i] = 0;
		dTerm[i] = 0;
	}
}


double PIDController::getSignal(double input_value, double sensor_value)
{
	iTerm[4] = iTerm[3];
	iTerm[3] = iTerm[2];
	iTerm[2] = iTerm[1];
	iTerm[1] = iTerm[0];
	iTerm[0] = sensor_value;
	
	double inputFiltered = 0.0;
	
	for(int i = 0; i < InputFilter_term; i ++)
	{
		inputFiltered += iTerm[i];
	}
	
	inputFiltered /= InputFilter_term;
	
	
	double error = input_value - inputFiltered;

	integral += error;
	
	if(integral > 500)
		integral = 500;
	else if (integral < -500)
		integral = -500;
	
	dTerm[4] = dTerm[3];
	dTerm[3] = dTerm[2];
	dTerm[2] = dTerm[1];
	dTerm[1] = dTerm[0];
	dTerm[0] = error - error_old;
	
	error_old = error;
	
	double dFiltered = 0.0;
	
	for(int i = 0; i < DFilter_term; i ++)
	{
		dFiltered += dTerm[i];
	}
	
	dFiltered /= DFilter_term;
	
	return Kp*error + Ki*integral + Kd * dFiltered;
	
		
}

