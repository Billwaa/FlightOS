
#ifndef __COMM_H__
#define __COMM_H__

#include "Data.h"
#include "Arduino.h"

class COMM
{

public:
	COMM();
	void parseCommand(Data& data);
       void downlink(Data& data);

	
private:
	String getValue(String data, char separator, int index);
	
	void setTargets(Data& data, String str);
	void setAngleGains(Data& data, String str);
	void setAngularRateGains(Data& data, String str);
	void setPositionGains(Data& data, String str);
}; 

#endif 
