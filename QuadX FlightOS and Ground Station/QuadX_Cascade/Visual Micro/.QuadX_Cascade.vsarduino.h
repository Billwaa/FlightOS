/* 
	Editor: http://www.visualmicro.com
	        visual micro and the arduino ide ignore this code during compilation. this code is automatically maintained by visualmicro, manual changes to this file will be overwritten
	        the contents of the Visual Micro sketch sub folder can be deleted prior to publishing a project
	        all non-arduino files created by visual micro and all visual studio project or solution files can be freely deleted and are not required to compile a sketch (do not delete your own code!).
	        note: debugger breakpoints are stored in '.sln' or '.asln' files, knowledge of last uploaded breakpoints is stored in the upload.vmps.xml file. Both files are required to continue a previous debug session without needing to compile and upload again
	
	Hardware: Arduino Due (Programming Port), Platform=sam, Package=arduino
*/

#define __SAM3X8E__
#define USB_VID 0x2341
#define USB_PID 0x003e
#define USBCON
#define USB_MANUFACTURER "\"Unknown\""
#define USB_PRODUCT "\"Arduino Due\""
#define ARDUINO 158
#define ARDUINO_MAIN
#define F_CPU 84000000L
#define printf iprintf
#define __SAM__
extern "C" void __cxa_pure_virtual() {;}

void calcSignal1();
void calcSignal2();
void calcSignal3();
void calcSignal4();
void calcSignal5();
void calcSignal6();
//
//
void parseRF();
void serialEvent3();
void serialEvent1();
int getUltrasonic();
void printData();
void printDataXBEE();
void attachMotor(int _m0, int _m1, int _m2, int _m3);
void writeChannel(int channel, int pwm);
void writeAll(int pwm);
void writePWM(Data& data);

#include "C:\Program Files (x86)\Arduino\hardware\arduino\sam\variants\arduino_due_x\pins_arduino.h" 
#include "C:\Program Files (x86)\Arduino\hardware\arduino\sam\variants\arduino_due_x\variant.h" 
#include "C:\Program Files (x86)\Arduino\hardware\arduino\sam\cores\arduino\arduino.h"
#include <QuadX_Cascade.ino>
#include <COMM.cpp>
#include <COMM.h>
#include <Data.cpp>
#include <Data.h>
#include <FlightController.cpp>
#include <FlightController.h>
#include <FlightMixer.cpp>
#include <FlightMixer.h>
#include <IMU.cpp>
#include <IMU.h>
#include <Motor.cpp>
#include <Motor.h>
#include <PID.cpp>
#include <PID.h>
