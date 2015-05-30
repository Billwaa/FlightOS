#include <Arduino.h>
#include "IMU.h"
#include "Data.h"


IMU::IMU()
{
	// Serial Port for IMU must be Defined in Main Sketch
	// Serial1.begin(115200);
	
	// Set Calibration Flag
	calGyro = false;
	calKalman = false;
	calMag = false;
	calAll = false;
        
        // Set Euler Data Request
	setEulerBuf();

}

void IMU::calibrate()
{
	Serial.println();
	Serial.println();
	Serial.println("IMU Calibration Mode");
	Serial.println("~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
	while (!calAll)
	{
		
		if (!calGyro)
		{
			char bufGryo[7] = { 's', 'n', 'p', 0x00, 0xAD, 0x01, 0xFE};
			Serial1.print(bufGryo);
			Serial.println("Request Gryro Calibration");
			for (int i = 0; i < 7; i++)
			{
				Serial.print((int)bufGryo[i]);
				Serial.print(" ");
			}
			Serial.println();
			Serial.println();
			
			if(confirmCommand())
			{
				calGyro = true;
				Serial.println("Gryo Calibrated!");
				Serial.println("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Serial.println();
			}
			
		}
		
		
		
		else if (!calKalman)
		{
			char bufGryo[7] = { 's', 'n', 'p', 0x00, 0xB3, 0x02, 0x04};
			Serial1.print(bufGryo);
			Serial.println("Request Kalman Filter Calibration");
			for (int i = 0; i < 7; i++)
			{
				Serial.print((int)bufGryo[i]);
				Serial.print(" ");
			}
			Serial.println();
			Serial.println();
			
			if(confirmCommand())
			{
				calKalman = true;
				Serial.println("Kalman Filter Calibrated!");
				Serial.println("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Serial.println();
			}
		}
		
		else if (!calMag)
		{
			char bufMag[7] = { 's', 'n', 'p', 0x00, 0xB0, 0x02, 0x01};
			Serial1.print(bufMag);
			Serial.println("Request Magnetometer Reference Calibration");
			for (int i = 0; i < 7; i++)
			{
				Serial.print((int)bufMag[i]);
				Serial.print(" ");
			}
			Serial.println();
			Serial.println();
			
			if(confirmCommand())
			{
				calMag = true;
				calAll = true;
				Serial.println("Magnetometer Calibrated!");
				Serial.println("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
				Serial.println();
			}
		}

	}
}

boolean IMU::confirmCommand()
{
	long t0 = millis();
	
	while(Serial1.available() <= 0)
	{
		if (millis() - t0 > 500)
		break;
	}
	
	if (Serial1.available() >= 7)
	{
		Serial.print("Parsing Data......... 0x");
		
		while (Serial1.available() > 0 && Serial1.read() != 's');
		if (Serial1.available() > 0 && Serial1.read() == 'n')
		if (Serial1.available() > 0 && Serial1.read() == 'p')
		{
			byte pt = Serial1.read();
			byte addr = Serial1.read();
			byte csum0 = Serial1.read();
			byte csum1 = Serial1.read();
			unsigned int csum = (csum0 << 8) + csum1;
			Serial.println(addr,HEX);

			unsigned int verify = 's' + 'n' + 'p' + pt + addr;
			boolean valid = verify == csum;
			
			if (valid && pt == 0)
			return true;
			
			else
			return false;
		}
	}
}


void IMU::requestData()
{
	// Request Euler Angle and Rate
	Serial1.print(bufData);
}



boolean IMU::checkIMU(Data& data)
{
	if (Serial1.available() >= 23)
	{

		while (Serial1.available() > 0 && Serial1.read() != 's');
		if (Serial1.available() > 0 && Serial1.read() == 'n')
		if (Serial1.available() > 0 && Serial1.read() == 'p')
		{
			processData(data);
			return true;
		}
	}
	
	return false;

}



void IMU::processData(Data& data)
{
	byte pt = Serial1.read();
	byte addr = Serial1.read();
	
	int ptSize = ((B00111100 & pt) >> 2) * 4;

	byte packet[ptSize];

	for (int i = 0; i < ptSize; i++)
	packet[i] = Serial1.read();

	byte csum0 = Serial1.read();
	byte csum1 = Serial1.read();
	unsigned int csum = (csum0 << 8) + csum1;

	unsigned int verify = 's' + 'n' + 'p' + pt + addr;
	for (int i = 0; i < ptSize; i++)
	verify += packet[i];

	boolean valid = verify == csum;

	// In Arduino DUE, int is 4 byte, must force 2 bytes
	// to have it handle 2's complement automatically
	if (valid)
	{
		if (pt == B11010000 && addr == 0x70)
		{
			data.roll = (int16_t) ((packet[0] << 8) + packet[1]) * 0.0109863;
			data.pitch = (int16_t) ((packet[2] << 8) + packet[3]) * 0.0109863;
			data.yaw = (int16_t) ((packet[4] << 8) + packet[5]) * 0.0109863;
			data.roll_d = (int16_t) ((packet[8] << 8) + packet[9]) / 16.0;
			data.pitch_d = (int16_t) ((packet[10] << 8) + packet[11]) / 16.0;
			data.yaw_d = (int16_t) ((packet[12] << 8) + packet[13])  / 16.0;
                        //setGyroBuf();
		}
                else if (pt == B11001100 && addr == 0x61)
                {                        
                        data.roll_d = binToFloat(packet[0],packet[1],packet[2],packet[3]);
                        data.pitch_d = binToFloat(packet[4],packet[5],packet[6],packet[7]);
                        data.yaw_d = binToFloat(packet[8],packet[9],packet[10],packet[11]);
                        setEulerBuf();
                }

	}
}


float IMU::binToFloat(byte D3, byte D2, byte D1, byte D0)
{
  byte bin[4];
  
  bin[3] = D3;
  bin[2] = D2;
  bin[1] = D1;
  bin[0] = D0;
  
  return *( (float*) bin ); 
}

void IMU::setEulerBuf()
{
  	// Define Data Request Buffer
	bufData[0] = 's';
	bufData[1] = 'n';
	bufData[2] = 'p';
	bufData[3] = B01010000;
	bufData[4] = 0x70;
	bufData[5] = 2;
	bufData[6] = 17;
}

void IMU::setGyroBuf()
{
  	// Define Data Request Buffer
	bufData[0] = 's';
	bufData[1] = 'n';
	bufData[2] = 'p';
	bufData[3] = B01001100;
	bufData[4] = 0x61;
	bufData[5] = 1;
	bufData[6] = 254;
}

