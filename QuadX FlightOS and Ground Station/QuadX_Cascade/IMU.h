#ifndef _IMU_h
#define _IMU_h

#include <Arduino.h>
#include "Data.h"

class IMU
{  
  private:
    char bufData[7];

	boolean calGyro;
	boolean calKalman;
	boolean calMag;
	boolean calAll;

        int mode;
        
        void setEulerBuf();
        void setGyroBuf();
  
  public:	
    IMU();
    void calibrate();	
    boolean confirmCommand();
    void requestData();
    boolean checkIMU(Data& data);
    void processData(Data& data);
    float binToFloat(byte D3, byte D2, byte D1, byte D0);
};


#endif
