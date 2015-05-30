// 
// 
// 

#include "FlightMixer.h"
#include "Data.h"

FlightMixerClass::FlightMixerClass()
{
	mode = 3;
	pwm_min = 1150;
	pwm_max = 1700;
}

FlightMixerClass::FlightMixerClass(String _mode, int _pwm_min, int _pwm_max)
{
	if (_mode == "Y6")
		mode = 0;
	else if (_mode == "Quad+")
		mode = 1;
	else if (_mode == "QuadX")
		mode = 2;
	else if (_mode == "QuadX2")
		mode = 3;
		
	pwm_min = _pwm_min;
	pwm_max = _pwm_max;
}

int FlightMixerClass::pidMix( double x, double y, double z, double* pid_signal,double throttle)
{
	int pwm = throttle + pid_signal[0]*x + pid_signal[1]*y + pid_signal[2]*z;
	
	if (pwm < pwm_min)
		pwm = pwm_min;
	else if (pwm > pwm_max)
		pwm = pwm_max;
	
	return pwm;
}

void FlightMixerClass::getPWM(Data& data)
{		
	
	double pid_signal[3] = {data.roll_signal, data.pitch_signal, data.yaw_signal};
	int throttle = data.throttle;
	
	
	if (mode == 0)
	{		
		data.motor0_pwm = pidMix(0,-1,1,pid_signal,throttle);
		data.motor1_pwm = pidMix(0,-1,-1,pid_signal,throttle);
		data.motor2_pwm = pidMix(-0.87,0.5,1,pid_signal,throttle);
		data.motor3_pwm = pidMix(-0.87,0.5,-1,pid_signal,throttle);
		data.motor4_pwm = pidMix(0.87,0.5,1,pid_signal,throttle);
		data.motor5_pwm = pidMix(0.87,0.5,-1,pid_signal,throttle);
	}
	else if (mode == 1)
	{
		data.motor0_pwm = pidMix(-1,0,1,pid_signal,throttle);
		data.motor1_pwm = pidMix(0,1,-1,pid_signal,throttle);
		data.motor2_pwm = pidMix(1,0,1,pid_signal,throttle);
		data.motor3_pwm = pidMix(0,-1,-1,pid_signal,throttle);
	}
	else if (mode == 2)
	{	
		data.motor0_pwm = pidMix(-1,1,1,pid_signal,throttle);
		data.motor1_pwm = pidMix(1,1,-1,pid_signal,throttle);
		data.motor2_pwm = pidMix(1,-1,1,pid_signal,throttle); // trim +7
		data.motor3_pwm = pidMix(-1,-1,-1,pid_signal,throttle); // trim +7
	}
	else if (mode == 3)
	{
		data.motor0_pwm = pidMix(-1,1,-1,pid_signal,throttle);
		data.motor1_pwm = pidMix(1,1,1,pid_signal,throttle);
		data.motor2_pwm = pidMix(1,-1,-1,pid_signal,throttle);
		data.motor3_pwm = pidMix(-1,-1,1,pid_signal,throttle);
	}	
	
}



FlightMixerClass FlightMixer;

