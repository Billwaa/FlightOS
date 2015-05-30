#include "COMM.h"
#include "Data.h"
#include "Arduino.h"


COMM::COMM()
{
}

void COMM::parseCommand(Data& data)
{

	long t0 = millis();

	char buf[1024];

	for (int i = 0; i < 1024; i++)
	buf[i] = 0;

	Serial3.readBytesUntil(';', buf, 1024);
	String str = String(buf);

        // Override Mode
	if (str.startsWith("@OR") && str.endsWith("@END"))
	{
            data.overrideMode = getValue(str, ',', 1).toInt();
            Serial3.print("Override Mode: ");
            Serial3.print(data.overrideMode); 
            Serial3.print(";");
	}

        // Arm Mode
	if (str.startsWith("@AR") && str.endsWith("@END"))
	{
            data.armMode = getValue(str, ',', 1).toInt();
            Serial3.print("Arm Mode: ");
            Serial3.print(data.armMode); 
            Serial3.print(";");
	}

	// Downlink
	if (str.startsWith("@DL") && str.endsWith("@END"))
	{
		downlink(data);
	}
	
	// Set Target
	else if (str.startsWith("@T") && str.endsWith("@END"))
	{
		setTargets(data,str);		
	}


	// Set Gains for Angular Rate
	else if (str.startsWith("@K_R") && str.endsWith("@END"))
	{
		setAngularRateGains(data,str);
	}

	// Set Gains for Angle
	else if (str.startsWith("@K_A") && str.endsWith("@END"))
	{
		setAngleGains(data,str);
	}

	// Set Gains for Position
	else if (str.startsWith("@K_P") && str.endsWith("@END"))
	{
		setPositionGains(data,str);
	}

	else
		Serial3.println("Invalid Format!");
}






//http://stackoverflow.com/questions/9072320/split-string-into-string-array
//Alvaro Luis Bustamante
String COMM::getValue(String data, char separator, int index)
{
	int found = 0;
	int strIndex[] = {0, -1};
	int maxIndex = data.length() - 1;

	for (int i = 0; i <= maxIndex && found <= index; i++) {
		if (data.charAt(i) == separator || i == maxIndex) {
			found++;
			strIndex[0] = strIndex[1] + 1;
			strIndex[1] = (i == maxIndex) ? i + 1 : i;
		}
	}

	return found > index ? data.substring(strIndex[0], strIndex[1]) : "";
}

void COMM::downlink(Data& data)
{
	// Begin and Time ////////////////////////////////////
	Serial3.print("@DL"); Serial3.print(",");
	Serial3.print(millis()); Serial3.print(",");
	
	// States ////////////////////////////////////////////

        Serial3.print(data.armMode); Serial3.print(",");

	Serial3.print(data.roll); Serial3.print(",");
	Serial3.print(data.pitch); Serial3.print(",");
	Serial3.print(data.yaw); Serial3.print(",");
	
	Serial3.print(data.roll_d); Serial3.print(",");
	Serial3.print(data.pitch_d); Serial3.print(",");
	Serial3.print(data.yaw_d); Serial3.print(",");
	
	Serial3.print(data.longitude); Serial3.print(","); //longitude
	Serial3.print(data.latitude); Serial3.print(","); // latitude
	
	Serial3.print(data.throttle); Serial3.print(",");
	Serial3.print(data.height); Serial3.print(",");
	
	// Commands ///////////////////////////////////////////
	Serial3.print(data.roll_t); Serial3.print(",");
	Serial3.print(data.pitch_t); Serial3.print(",");
	Serial3.print(data.yaw_t); Serial3.print(",");
	
	Serial3.print(data.longitude_t); Serial3.print(","); // longitude_t
	Serial3.print(data.latitude_t); Serial3.print(","); // latitude_t
	Serial3.print(data.height_t); Serial3.print(",");
	
	// Signal ////////////////////////////////////////////
	Serial3.print(data.roll_signal); Serial3.print(",");
	Serial3.print(data.pitch_signal); Serial3.print(",");
	Serial3.print(data.yaw_signal); Serial3.print(",");
	
	Serial3.print(data.motor0_pwm); Serial3.print(",");
	Serial3.print(data.motor1_pwm); Serial3.print(",");
	Serial3.print(data.motor2_pwm); Serial3.print(",");
	Serial3.print(data.motor3_pwm); Serial3.print(",");
	
	// END ///////////////////////////////////////////////
	Serial3.print("@END;");
}

void COMM::setTargets(Data& data, String str)
{
	data.throttle = getValue(str, ',', 1).toInt();
	data.roll_t = getValue(str, ',', 2).toFloat();
	data.pitch_t = getValue(str, ',', 3).toFloat();
	data.yaw_t = getValue(str, ',', 4).toFloat();
	data.longitude_t = getValue(str, ',', 5).toFloat();  // longitude
	data.latitude_t = getValue(str, ',', 6).toFloat();  // latituude
	data.height_t = getValue(str, ',', 7).toInt();
	
        Serial3.print("Set Targets: ");
	Serial3.print(data.throttle); Serial3.print(",");
	Serial3.print(data.roll_t); Serial3.print(",");
	Serial3.print(data.pitch_t); Serial3.print(",");
	Serial3.print(data.yaw_t); Serial3.print(",");
        Serial3.print(data.longitude_t); Serial3.print(",");
        Serial3.print(data.latitude_t); Serial3.print(",");
	Serial3.print(data.height_t); Serial3.print(";");
}

void COMM::setAngleGains(Data& data, String str)
{
	data.Kp_r = getValue(str, ',', 1).toFloat();
	data.Ki_r = getValue(str, ',', 2).toFloat();
	data.Kd_r = getValue(str, ',', 3).toFloat();

	data.Kp_p = getValue(str, ',', 4).toFloat();
	data.Ki_p = getValue(str, ',', 5).toFloat();
	data.Kd_p = getValue(str, ',', 6).toFloat();

	data.Kp_y = getValue(str, ',', 7).toFloat();
	data.Ki_y = getValue(str, ',', 8).toFloat();
	data.Kd_y = getValue(str, ',', 9).toFloat();

	Serial3.print("PID Angle Gains: ");
	Serial3.print(data.Kp_r); Serial3.print(',');
	Serial3.print(data.Ki_r); Serial3.print(',');
	Serial3.print(data.Kd_r); Serial3.print(',');
	Serial3.print(data.Kp_p); Serial3.print(',');
	Serial3.print(data.Ki_p); Serial3.print(',');
	Serial3.print(data.Kd_p); Serial3.print(',');
	Serial3.print(data.Kp_y); Serial3.print(',');
	Serial3.print(data.Ki_y); Serial3.print(',');
	Serial3.print(data.Kd_y); Serial3.print(';');
}

void COMM::setAngularRateGains(Data& data, String str)
{
	data.Kp_r_d = getValue(str, ',', 1).toFloat();
	data.Ki_r_d = getValue(str, ',', 2).toFloat();
	data.Kd_r_d = getValue(str, ',', 3).toFloat();

	data.Kp_p_d = getValue(str, ',', 4).toFloat();
	data.Ki_p_d = getValue(str, ',', 5).toFloat();
	data.Kd_p_d = getValue(str, ',', 6).toFloat();

	data.Kp_y_d = getValue(str, ',', 7).toFloat();
	data.Ki_y_d = getValue(str, ',', 8).toFloat();
	data.Kd_y_d = getValue(str, ',', 9).toFloat();

	Serial3.print("PID Angular Rate Gains: ");
	Serial3.print(data.Kp_r_d); Serial3.print(',');
	Serial3.print(data.Ki_r_d); Serial3.print(',');
	Serial3.print(data.Kd_r_d); Serial3.print(',');
	Serial3.print(data.Kp_p_d); Serial3.print(',');
	Serial3.print(data.Ki_p_d); Serial3.print(',');
	Serial3.print(data.Kd_p_d); Serial3.print(',');
	Serial3.print(data.Kp_y_d); Serial3.print(',');
	Serial3.print(data.Ki_y_d); Serial3.print(',');
	Serial3.print(data.Kd_y_d); Serial3.print(';');
}

void COMM::setPositionGains(Data& data, String str)
{
	data.Kp_lon = getValue(str,',',1).toFloat();
	data.Ki_lon = getValue(str,',',2).toFloat();
	data.Kd_lon = getValue(str,',',3).toFloat();

	data.Kp_lat = getValue(str,',',4).toFloat();
	data.Ki_lat = getValue(str,',',5).toFloat();
	data.Kd_lat = getValue(str,',',6).toFloat();

	data.Kp_h = getValue(str,',',4).toFloat();
	data.Ki_h = getValue(str,',',5).toFloat();
	data.Kd_h = getValue(str,',',6).toFloat();

	Serial3.print("PID Position Gains: ");
	Serial3.print(data.Kp_lon); Serial3.print(',');
	Serial3.print(data.Ki_lon); Serial3.print(',');
	Serial3.print(data.Kd_lon); Serial3.print(',');
	Serial3.print(data.Kp_lat); Serial3.print(',');
	Serial3.print(data.Ki_lat); Serial3.print(',');
	Serial3.print(data.Kd_lat); Serial3.print(',');
	Serial3.print(data.Kp_h); Serial3.print(',');
	Serial3.print(data.Ki_h); Serial3.print(',');
	Serial3.print(data.Kd_h); Serial3.print(';');
}

