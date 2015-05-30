/*
 * Created by SharpDevelop.
 * User: Billwaa
 * Date: 1/10/2015
 * Time: 4:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;

namespace Ground_Station_App
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Data data = new Data();
		SerialPort port;
		System.Threading.Thread newThread;
		
		int sync_val = 0;
		
		// Setup Data Logger
		FileStream logStream;
		StreamWriter logWriter;
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			
			InitializeComponent();
			
			string promptPort = "Please Enter Serial Port Number ( ";
			
			for ( int i = 0; i < SerialPort.GetPortNames().Length; i++)			
				promptPort += SerialPort.GetPortNames()[i] + " ";
			
			promptPort += ")";
			
			string portID = SerialPort.GetPortNames()[0];
			InputBox("Serial Port",promptPort,ref portID);
			System.Diagnostics.Debug.WriteLine(portID);
			
			//Open Serial Port
			port = new SerialPort(portID);
			port.BaudRate = 57600;
			port.Open();
			
			// Set Up Background Processing Thread
			newThread = new System.Threading.Thread(new System.Threading.ThreadStart(this.processLoop));
			newThread.IsBackground = true;
			newThread.Start();
			
			// Refresh Tuner
			refresh_KA();
			refresh_KR();
			refresh_KP();
			
			// Setup Data Logger
			string logName = "Flight Log -- " + DateTime.Now.ToString()+".txt";
			logName = logName.Replace(':','-');
			logName = logName.Replace('/','-');
			System.Diagnostics.Debug.WriteLine(logName);
			logStream = new FileStream(logName,FileMode.Create);
			logWriter = new StreamWriter(logStream);
			
			logWriter.WriteLine("time roll pitch yaw roll_d pitch_d yaw_d longitude latitude height roll_t pitch_t yaw_t longitude_t latitude_t height_t roll_signal pitch_signal yaw_signal throttle Kp_r_d Ki_r_d Kd_r_d Kp_p_d Ki_p_d Kd_p_d Kp_y_d Ki_y_d Kd_y_d Kp_r Ki_r Kd_r Kp_p Ki_p Kd_p Kp_y Ki_y Kd_y Kp_lon Ki_lon Kd_lon Kp_lat Ki_lat Kd_lat Kp_h Ki_h Kd_h");
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		

//http://www.csharp-examples.net/inputbox/
public static DialogResult InputBox(string title, string promptText, ref string value)
{
  Form form = new Form();
  Label label = new Label();
  TextBox textBox = new TextBox();
  Button buttonOk = new Button();
  Button buttonCancel = new Button();

  form.Text = title;
  label.Text = promptText;
  textBox.Text = value;

  buttonOk.Text = "OK";
  buttonCancel.Text = "Cancel";
  buttonOk.DialogResult = DialogResult.OK;
  buttonCancel.DialogResult = DialogResult.Cancel;

  label.SetBounds(9, 20, 372, 13);
  textBox.SetBounds(12, 36, 372, 20);
  buttonOk.SetBounds(228, 72, 75, 23);
  buttonCancel.SetBounds(309, 72, 75, 23);

  label.AutoSize = true;
  textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
  buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
  buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

  form.ClientSize = new Size(396, 107);
  form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
  form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
  form.FormBorderStyle = FormBorderStyle.FixedDialog;
  form.StartPosition = FormStartPosition.CenterScreen;
  form.MinimizeBox = false;
  form.MaximizeBox = false;
  form.AcceptButton = buttonOk;
  form.CancelButton = buttonCancel;

  DialogResult dialogResult = form.ShowDialog();
  value = textBox.Text;
  return dialogResult;
}
		
		
		// Background Process Loop
		private void processLoop()
		{			
			long timer_downlink = DateTime.Now.Ticks;
						
			while(true)
			{
				
				if ((DateTime.Now.Ticks - timer_downlink) > 1000000)
				{
					port.Write("@DL,@END;");
					port.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
					timer_downlink = DateTime.Now.Ticks;
					dataLogger();
				}

			}
			
		}
		
		
		private void dataLogger()
		{
			string buffer = String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12} {13} {14} {15} {16} {17} {18} {19} {20} {21} {22} {23} {24} {25} {26} {27} {28} {29} {30} {31} {32} {33} {34} {35} {36} {37} {38} {39} {40} {41} {42} {43} {44} {45} {46}", 
			                              data.time,
			                              data.roll, data.pitch, data.yaw,
			                              data.roll_d, data.pitch_d, data.yaw_d,
			                              data.longitude, data.latitude, data.height,
			                              data.roll_t, data.pitch_t, data.yaw_t,
			                              data.longitude_t, data.latitude_t, data.height_t,
			                              data.roll_signal, data.pitch_signal, data.yaw_signal, data.throttle,
			                              data.Kp_r_d, data.Ki_r_d, data.Kd_r_d,
			                              data.Kp_p_d, data.Ki_p_d, data.Kd_p_d,
			                              data.Kp_y_d, data.Ki_y_d, data.Kd_y_d,
			                              data.Kp_r, data.Ki_r, data.Kd_r,
			                              data.Kp_p, data.Ki_p, data.Kd_p,
			                              data.Kp_y, data.Ki_y, data.Kd_y,
			                              data.Kp_lon, data.Ki_lon, data.Kd_lon,
			                              data.Kp_lat, data.Ki_lat, data.Kd_lat,
			                              data.Kp_h, data.Ki_h, data.Kd_h);
			                              
			                              
			                              
			                              
			                              
			logWriter.WriteLine(buffer);
		}
		
		
		// Serial Event Handler
		 private void DataReceivedHandler( object sender, SerialDataReceivedEventArgs e)
		 {
		 	try
		 	{
	        SerialPort sp = (SerialPort)sender;
	        
	        if(sp.BytesToRead < 10)
	        	return;
	        
	        string inData = sp.ReadTo(";");
	        System.Diagnostics.Debug.WriteLine( inData);
	        inData = Regex.Replace(inData,"[\x01-\x1F]",""); // Remove Ascii char from 01 to 1F in hex
	        
	        if (inData.StartsWith("@DL") && inData.EndsWith("@END"))
	        	parseTelemetry(inData);
		 	}
		 	catch (Exception ex)
		 	{
		 		System.Diagnostics.Debug.WriteLine(ex.ToString());
		 	}
	    }
		 
		 private void parseTelemetry(string str)
		 {
		 	string[] dat = str.Split(',');
		 			 	
		 	data.time = Convert.ToDouble(dat[1])/1000.0;
		 	
		 	if (dat[2] == "1")
		 		data.armMode = true;
		 	else 
		 		data.armMode = false;
		 	
		 	data.roll = Convert.ToDouble(dat[3]);
		 	data.pitch = Convert.ToDouble(dat[4]);
		 	data.yaw = Convert.ToDouble(dat[5]);
		 	data.roll_d = Convert.ToDouble(dat[6]);
		 	data.pitch_d = Convert.ToDouble(dat[7]);
		 	data.yaw_d = Convert.ToDouble(dat[8]);
		 	data.longitude = Convert.ToDouble(dat[9]);
		 	data.latitude = Convert.ToDouble(dat[10]);		 	
		 	data.height = Convert.ToInt16(dat[12]);
		 	
		 	// Check Command Sync Status
		 	double roll_t = Convert.ToDouble(dat[13]);
		 	double pitch_t = Convert.ToDouble(dat[14]);
		 	double yaw_t = Convert.ToDouble(dat[15]);
		 	double longitude_t = Convert.ToDouble(dat[16]);
		 	double latitude_t = Convert.ToDouble(dat[17]);
		 	int height_t = Convert.ToInt16(dat[18]);
		 	int throttle = Convert.ToInt16(dat[11]);
		 	
		 	if (roll_t == data.roll_t &&
		 	    pitch_t == data.pitch_t &&
		 	    yaw_t == data.yaw_t &&
		 	    longitude_t == data.longitude_t &&
		 	    latitude_t == data.latitude_t &&
		 	    height_t == data.height_t &&
		 	   	throttle == data.throttle)
		 	{
		 		sync_val = 100;
		 		SetSyncBar();
		 	}
		 	else
		 	{
		 		sync_val = 0;
		 		SetSyncBar();
		 	}
		 	
		 	if (!data.overrideMode)
		 	{
		 		data.roll_t = roll_t;
		 		data.pitch_t = pitch_t;
		 		data.yaw_t = yaw_t;
		 		data.longitude_t = longitude_t;
		 		data.latitude_t = latitude_t;
		 		data.height_t = height_t;
		 		data.throttle = throttle;
		 	}
		 	
		 	data.roll_signal = Convert.ToDouble(dat[19]);
		 	data.pitch_signal = Convert.ToDouble(dat[20]);
		 	data.yaw_signal = Convert.ToDouble(dat[21]);
		 	data.motor0_pwm = Convert.ToInt16(dat[22]);
		 	data.motor1_pwm = Convert.ToInt16(dat[23]);
		 	data.motor2_pwm = Convert.ToInt16(dat[24]);
		 	data.motor3_pwm = Convert.ToInt16(dat[25]);
		 	
		 	this.SetTelemetry();
		 }
		 
		
		//Override the Exit Button
		protected override void OnFormClosing(FormClosingEventArgs e)
		{
    		base.OnFormClosing(e);

		    if (e.CloseReason == CloseReason.WindowsShutDown) return;

			    // Confirm user wants to close
    		switch (MessageBox.Show(this, "Are you sure you want to close?", "Closing", MessageBoxButtons.YesNo))
    		{
    		case DialogResult.No:
	        	e.Cancel = true;
        		break;
    		default:        	        		
        		newThread.Abort(); // make sure thread is close and don't cause error
        		logWriter.Close();
        		logStream.Close();
        		port.Close(); // auto close anyway, and throw error if close here
        		break;
        	
    		}        
		}
		
		// Set Override
		delegate void SetOverrideCallback();
		
		private void SetOverride()
		{
			if (checkBox_override.InvokeRequired)
			{
				SetOverrideCallback d = new SetOverrideCallback(SetOverride);
				this.Invoke(d, new object[] {});				
			}
			else
			{
				checkBox_override.Checked = data.overrideMode;
			}
		
		}
		
		// Set Telemetry
		delegate void SetTelemetryCallback();

		private void SetTelemetry()
		{		  
		  if (DL_Roll.InvokeRequired || DL_Pitch.InvokeRequired || DL_Yaw.InvokeRequired)
		  { 
		    SetTelemetryCallback d = new SetTelemetryCallback(SetTelemetry);
		    this.Invoke(d, new object[] {});
		  }
		  else
		  {
		  	DL_Time.Text = Convert.ToString(data.time);
		    
		  	DL_Roll.Text = Convert.ToString(data.roll);
			DL_Pitch.Text = Convert.ToString(data.pitch);
			DL_Yaw.Text = Convert.ToString(data.yaw);
			
			DL_Roll_d.Text = Convert.ToString(data.roll_d);
			DL_Pitch_d.Text = Convert.ToString(data.pitch_d);
			DL_Yaw_d.Text = Convert.ToString(data.yaw_d);
			
			DL_longitude.Text = Convert.ToString(data.longitude);
			DL_latitude.Text = Convert.ToString(data.latitude);
			DL_height.Text = Convert.ToString(data.height);
			
			DL_RollSignal.Text = Convert.ToString(data.roll_signal);
			DL_PitchSignal.Text = Convert.ToString(data.pitch_signal);
			DL_YawSignal.Text = Convert.ToString(data.yaw_signal);
			
			DL_Motor0.Text = Convert.ToString(data.motor0_pwm);
			DL_Motor1.Text = Convert.ToString(data.motor1_pwm);
			DL_Motor2.Text = Convert.ToString(data.motor2_pwm);
			DL_Motor3.Text = Convert.ToString(data.motor3_pwm);
			
			rollT_text.Text = Convert.ToString(data.roll_t);
			pitchT_text.Text = Convert.ToString(data.pitch_t);
			yawT_text.Text = Convert.ToString(data.yaw_t);			
			throttle_text.Text = Convert.ToString(data.throttle);
			
			heightT_text.Text = Convert.ToString(data.height_t);
			longitudeT_text.Text = Convert.ToString(data.longitude_t);
			latitudeT_text.Text = Convert.ToString(data.latitude_t);
			
			checkBox_arm.Checked = data.armMode;
			
		  }
		}
		
		
		// Set Sync Bar
		delegate void SetSyncBarCallback();
		
		private void SetSyncBar()
		{
		 if (sync_bar.InvokeRequired)
		  { 
		    SetSyncBarCallback d = new SetSyncBarCallback(SetSyncBar);
		    this.Invoke(d, new object[] {});
		  }
		  else
		  {
		  	sync_bar.Value = sync_val;
		  }
			
		}
	
		
		
		// Tuner Data Process
		private string processBar(ref double var, double value, bool decMode = true)
		{
			if (decMode)
				var = value * 0.01;
			else
				var = value;
		
			
			return Convert.ToString(var);
		}
		
		private int processText(ref double var, string value, bool decMode = true, double min = 0.0, double max = 5.0)
		{
			double tempVar = Convert.ToDouble(value);
			
			if(tempVar >= min && tempVar <= max)						
				var = tempVar;			
			else
			{
				string error_message = "Input Value Out of Range! min="+min+" max="+max;
				
				MessageBox.Show(error_message,
				"ERROR",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation,
				MessageBoxDefaultButton.Button1);
			}				
			
			// Scale to Integer for Slider
			if(decMode)
				return (int) (var / 0.01);
			else
				return (int) var;
		}
		
		private string processBar(ref int var, int value)
		{
			var = value;			
			return Convert.ToString(var);
		}
		
		private int processText(ref int var, string value, int min = 0, int max = 5)
		{
			int tempVar = Convert.ToInt16(value);
			
			if(tempVar >= min && tempVar <= max)						
				var = tempVar;			
			else
			{
				string error_message = "Input Value Out of Range! min="+min+" max="+max;
				
				MessageBox.Show(error_message,
				"ERROR",
				MessageBoxButtons.OK,
				MessageBoxIcon.Exclamation,
				MessageBoxDefaultButton.Button1);
			}
			
			return var;
		}
		
		// PID Angle Gains \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
		
		// Roll Parameters 

		void Krp_barScroll(object sender, System.Windows.Forms.ScrollEventArgs e)
		{
			Krp_text.Text = processBar(ref data.Kp_r, Krp_bar.Value);
		}
		void Krp_textTextChanged(object sender, System.EventArgs e)
		{
			Krp_bar.Value = processText(ref data.Kp_r, Krp_text.Text);
		}        
		
		void Kri_barScroll(object sender, ScrollEventArgs e)
		{
			Kri_text.Text = processBar(ref data.Ki_r, Kri_bar.Value);
		}
		void Kri_textTextChanged(object sender, EventArgs e)
		{	
			Kri_bar.Value = processText(ref data.Ki_r, Kri_text.Text);
		}
		
		void Krd_barScroll(object sender, ScrollEventArgs e)
		{
			Krd_text.Text = processBar(ref data.Kd_r, Krd_bar.Value);
		}
		void Krd_textTextChanged(object sender, EventArgs e)
		{
			Krd_bar.Value = processText(ref data.Kd_r, Krd_text.Text);			
		}
				
		
		

        // Pitch Parameters

        void Kpp_barScroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            Kpp_text.Text = processBar(ref data.Kp_p, Kpp_bar.Value);
        }
        void Kpp_textTextChanged(object sender, System.EventArgs e)
        {
            Kpp_bar.Value = processText(ref data.Kp_p, Kpp_text.Text);
        }
        
        void Kpi_barScroll(object sender, ScrollEventArgs e)
        {
            Kpi_text.Text = processBar(ref data.Ki_p, Kpi_bar.Value);
        }
        void Kpi_textTextChanged(object sender, EventArgs e)
        {    
            Kpi_bar.Value = processText(ref data.Ki_p, Kpi_text.Text);
        }
        
        void Kpd_barScroll(object sender, ScrollEventArgs e)
        {
            Kpd_text.Text = processBar(ref data.Kd_p, Kpd_bar.Value);
        }
        void Kpd_textTextChanged(object sender, EventArgs e)
        {
            Kpd_bar.Value = processText(ref data.Kd_p, Kpd_text.Text);            
        }
        
        
        // Yaw Parameters

        void Kyp_barScroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            Kyp_text.Text = processBar(ref data.Kp_y, Kyp_bar.Value);
        }
        void Kyp_textTextChanged(object sender, System.EventArgs e)
        {
            Kyp_bar.Value = processText(ref data.Kp_y, Kyp_text.Text);
        }
        
        void Kyi_barScroll(object sender, ScrollEventArgs e)
        {
            Kyi_text.Text = processBar(ref data.Ki_y, Kyi_bar.Value);
        }
        void Kyi_textTextChanged(object sender, EventArgs e)
        {    
            Kyi_bar.Value = processText(ref data.Ki_y, Kyi_text.Text);
        }
        
        void Kyd_barScroll(object sender, ScrollEventArgs e)
        {
            Kyd_text.Text = processBar(ref data.Kd_y, Kyd_bar.Value);
        }
        void Kyd_textTextChanged(object sender, EventArgs e)
        {
            Kyd_bar.Value = processText(ref data.Kd_y, Kyd_text.Text);            
        }
        

		// Commands     
		void Button_KA_sendAllClick(object sender, EventArgs e)
		{
			string buffer = String.Format("@K_A,{0},{1},{2},{3},{4},{5},{6},{7},{8},@END;", 
			                              data.Kp_r, data.Ki_r, data.Kd_r,
			                             data.Kp_p, data.Ki_p, data.Kd_p,
			                            data.Kp_y, data.Ki_y, data.Kd_y);
			
			System.Diagnostics.Debug.WriteLine(buffer);
			
			port.Write(buffer);
		}
		
		void Button_KA_resetClick(object sender, EventArgs e)
		{
			data.Kp_r = 0.0;
			data.Ki_r = 0.0;
			data.Kd_r = 0.0;
			
			data.Kp_p = 0.0;
			data.Ki_p = 0.0;
			data.Kd_p = 0.0;
			
			data.Kp_y = 0.0;
			data.Ki_y = 0.0;
			data.Kd_y = 0.0;

			refresh_KA();
		}
		
		void refresh_KA()
		{
			Krp_text.Text = Convert.ToString(data.Kp_r);
			Kri_text.Text = Convert.ToString(data.Ki_r);
			Krd_text.Text = Convert.ToString(data.Kd_r);
			
			Kpp_text.Text = Convert.ToString(data.Kp_p);
			Kpi_text.Text = Convert.ToString(data.Ki_p);
			Kpd_text.Text = Convert.ToString(data.Kd_p);
			
			Kyp_text.Text = Convert.ToString(data.Kp_y);
			Kyi_text.Text = Convert.ToString(data.Ki_y);
			Kyd_text.Text = Convert.ToString(data.Kd_y);			
				
		}
		
		void Button_KA_saveClick(object sender, EventArgs e)
		{
			save_KA();
		}
		
		void Button_KA_loadClick(object sender, EventArgs e)
		{
			load_KA();
		}
		
		void save_KA()
		{
			FileStream fs = new FileStream("KA.txt",FileMode.Create);
			BinaryWriter writer = new BinaryWriter(fs);
			
			string buffer = String.Format("@K_A,{0},{1},{2},{3},{4},{5},{6},{7},{8},@END;", 
			                              data.Kp_r, data.Ki_r, data.Kd_r,
			                             data.Kp_p, data.Ki_p, data.Kd_p,
			                            data.Kp_y, data.Ki_y, data.Kd_y);
			
			writer.Write(buffer);
			writer.Close();
			
			MessageBox.Show("Attitude Control Gains Saved!");
		}
		
		void load_KA()
		{
			FileStream fs = new FileStream("KA.txt",FileMode.Open);
			BinaryReader reader = new BinaryReader(fs);
			string msg = reader.ReadString();
			
			string[] str = msg.Split(',');
			
			data.Kp_r = Convert.ToDouble(str[1]);
			data.Ki_r = Convert.ToDouble(str[2]);
			data.Kd_r = Convert.ToDouble(str[3]);
			
			data.Kp_p = Convert.ToDouble(str[4]);
			data.Ki_p = Convert.ToDouble(str[5]);
			data.Kd_p = Convert.ToDouble(str[6]);
			
			data.Kp_y = Convert.ToDouble(str[7]);
			data.Ki_y = Convert.ToDouble(str[8]);
			data.Kd_y = Convert.ToDouble(str[9]);
			
			refresh_KA();
			
			reader.Close();
			MessageBox.Show("Attitude Control Gains Loaded!");
			
			
		}
		

		
		
		// Target Display //////////////////////////////////////////////////////////////////////	
		void RollT_barScroll(object sender, EventArgs e)
		{
        	rollT_text.Text = processBar(ref data.roll_t, rollT_bar.Value, false);
		}
   
		
		void RollT_textTextChanged(object sender, EventArgs e)
		{
			rollT_bar.Value = processText(ref data.roll_t, rollT_text.Text, false, rollT_bar.Minimum, rollT_bar.Maximum);
		}
		
		
		
		void YawT_barScroll(object sender, EventArgs e)
		{
			yawT_text.Text = processBar(ref data.yaw_t, yawT_bar.Value, false);
		}
				
		void YawT_textTextChanged(object sender, EventArgs e)
		{
			yawT_bar.Value = processText(ref data.yaw_t, yawT_text.Text, false, yawT_bar.Minimum, yawT_bar.Maximum);
		}
		
		
		
		void PitchT_barScroll(object sender, EventArgs e)
		{
			pitchT_text.Text = processBar(ref data.pitch_t, pitchT_bar.Value, false);
		}
		
		void PitchT_textTextChanged(object sender, EventArgs e)
		{
			pitchT_bar.Value = processText(ref data.pitch_t, pitchT_text.Text, false, pitchT_bar.Minimum, pitchT_bar.Maximum);
		}
		
		
		void Throttle_barScroll(object sender, EventArgs e)
		{
			throttle_text.Text = processBar(ref data.throttle, throttle_bar.Value);
		}
		
		void Throttle_textTextChanged(object sender, EventArgs e)
		{			
			int tempThrottle = processText(ref data.throttle, throttle_text.Text, 0, throttle_bar.Maximum);
			
			if (tempThrottle < throttle_bar.Minimum)
				throttle_bar.Value = throttle_bar.Minimum;
			else
				throttle_bar.Value = tempThrottle;
		}
		
		void HeightT_textTextChanged(object sender, EventArgs e)		
		{
			int tempHeight = Convert.ToInt16(heightT_text.Text);
			
			if(tempHeight > 0 && tempHeight<200)
				data.height_t = tempHeight;
			else
				heightT_text.Text = data.height_t.ToString();
		}
		
		void LongitudeT_textTextChanged(object sender, EventArgs e)
		{
			double tempLon = Convert.ToDouble(longitudeT_text.Text);
			
			if( Math.Abs(tempLon) < 50)
				data.longitude_t = tempLon;
			else
				longitudeT_text.Text = data.longitude_t.ToString();		
			
		}
		
		void LatitudeT_textTextChanged(object sender, EventArgs e)
		{
			double tempLat = Convert.ToDouble(latitudeT_text.Text);
			
			if(Math.Abs(tempLat) < 50)
				data.latitude_t = tempLat;
			else
				latitudeT_text.Text = data.latitude_t.ToString();				
			
		}
		void Button_emergencyClick(object sender, EventArgs e)
		{
			data.overrideMode = true;
			SetOverride();

			string buffer = "@OR,1,@END;";
			port.Write(buffer);
			System.Diagnostics.Debug.WriteLine(buffer);
			
			rollT_text.Text = Convert.ToString(0);
			pitchT_text.Text = Convert.ToString(0);
			yawT_text.Text = Convert.ToString(0);
			throttle_text.Text = Convert.ToString(1380);
			heightT_text.Text = Convert.ToString(10);			
			uplinkTargets();			
		}
		
		void Button_uplinkClick(object sender, EventArgs e)
		{
			uplinkTargets();
		}

		void uplinkTargets()
		{			
			string buffer = String.Format("@T,{0},{1},{2},{3},{4},{5},{6},@END;",
			                              data.throttle, 
			                              data.roll_t, data.pitch_t, data.yaw_t,
			                              data.longitude_t, data.latitude_t, data.height_t);
			
			System.Diagnostics.Debug.WriteLine(buffer);
			
			port.Write(buffer);
			
		}
		
		// PID Angular Rate Gains \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
		

		// Roll Rate
		void Kprd_barScroll(object sender, ScrollEventArgs e)
		{
			Kprd_text.Text = processBar(ref data.Kp_r_d, Kprd_bar.Value);
		}
		
		void Kprd_textTextChanged(object sender, EventArgs e)
		{
			Kprd_bar.Value = processText(ref data.Kp_r_d, Kprd_text.Text);
		}

		void Kird_barScroll(object sender, ScrollEventArgs e)
		{
			Kird_text.Text = processBar(ref data.Ki_r_d, Kird_bar.Value);
		}
		void Kird_textTextChanged(object sender, EventArgs e)
		{
			Kird_bar.Value = processText(ref data.Ki_r_d, Kird_text.Text);
		}
		
		void Kdrd_barScroll(object sender, ScrollEventArgs e)
		{
			Kdrd_text.Text = processBar(ref data.Kd_r_d, Kdrd_bar.Value);
		}		
		void Kdrd_textTextChanged(object sender, EventArgs e)
		{
			Kdrd_bar.Value = processText(ref data.Kd_r_d, Kdrd_text.Text);
		}
		
		
		// Pitch Rate
		void Kppd_barScroll(object sender, ScrollEventArgs e)
		{
			Kppd_text.Text = processBar(ref data.Kp_p_d, Kppd_bar.Value);
		}
		
		void Kppd_textTextChanged(object sender, EventArgs e)
		{
			Kppd_bar.Value = processText(ref data.Kp_p_d, Kppd_text.Text);
		}

		void Kipd_barScroll(object sender, ScrollEventArgs e)
		{
			Kipd_text.Text = processBar(ref data.Ki_p_d, Kipd_bar.Value);
		}
		void Kipd_textTextChanged(object sender, EventArgs e)
		{
			Kipd_bar.Value = processText(ref data.Ki_p_d, Kipd_text.Text);
		}
		
		void Kdpd_barScroll(object sender, ScrollEventArgs e)
		{
			Kdpd_text.Text = processBar(ref data.Kd_p_d, Kdpd_bar.Value);
		}		
		void Kdpd_textTextChanged(object sender, EventArgs e)
		{
			Kdpd_bar.Value = processText(ref data.Kd_p_d, Kdpd_text.Text);
		}
		
		
		// Yaw Rate
		void Kpyd_barScroll(object sender, ScrollEventArgs e)
		{
			Kpyd_text.Text = processBar(ref data.Kp_y_d, Kpyd_bar.Value);
		}
		
		void Kpyd_textTextChanged(object sender, EventArgs e)
		{
			Kpyd_bar.Value = processText(ref data.Kp_y_d, Kpyd_text.Text);
		}

		void Kiyd_barScroll(object sender, ScrollEventArgs e)
		{
			Kiyd_text.Text = processBar(ref data.Ki_y_d, Kiyd_bar.Value);
		}
		void Kiyd_textTextChanged(object sender, EventArgs e)
		{
			Kiyd_bar.Value = processText(ref data.Ki_y_d, Kiyd_text.Text);
		}
		
		void Kdyd_barScroll(object sender, ScrollEventArgs e)
		{
			Kdyd_text.Text = processBar(ref data.Kd_y_d, Kdyd_bar.Value);
		}		
		void Kdyd_textTextChanged(object sender, EventArgs e)
		{
			Kdyd_bar.Value = processText(ref data.Kd_y_d, Kdyd_text.Text);
		}
		
		// Button 
		void Button_KR_resetClick(object sender, EventArgs e)
		{
			data.Kp_r_d = 0.0;
			data.Ki_r_d = 0.0;
			data.Kd_r_d = 0.0;
			
			data.Kp_p_d = 0.0;
			data.Ki_p_d = 0.0;
			data.Kd_p_d = 0.0;
			
			data.Kp_y_d = 0.0;
			data.Ki_y_d = 0.0;
			data.Kd_y_d = 0.0;

			refresh_KR();
		}
		
		void Button_KR_saveClick(object sender, EventArgs e)
		{
			save_KR();
		}
		
		void Button_KR_loadClick(object sender, EventArgs e)
		{
			load_KR();
		}
		
		void Button_KR_sendallClick(object sender, EventArgs e)
		{
			string buffer = String.Format("@K_R,{0},{1},{2},{3},{4},{5},{6},{7},{8},@END;", 
			                              data.Kp_r_d, data.Ki_r_d, data.Kd_r_d,
			                             data.Kp_p_d, data.Ki_p_d, data.Kd_p_d,
			                            data.Kp_y_d, data.Ki_y_d, data.Kd_y_d);
			
			System.Diagnostics.Debug.WriteLine(buffer);
			
			port.Write(buffer);			
		}
		

		void refresh_KR()
		{
			Kprd_text.Text = Convert.ToString(data.Kp_r_d);
			Kird_text.Text = Convert.ToString(data.Ki_r_d);
			Kdrd_text.Text = Convert.ToString(data.Kd_r_d);
			
			Kppd_text.Text = Convert.ToString(data.Kp_p_d);
			Kipd_text.Text = Convert.ToString(data.Ki_p_d);
			Kdpd_text.Text = Convert.ToString(data.Kd_p_d);
			
			Kpyd_text.Text = Convert.ToString(data.Kp_y_d);
			Kiyd_text.Text = Convert.ToString(data.Ki_y_d);
			Kdyd_text.Text = Convert.ToString(data.Kd_y_d);			
				
		}
		
		void save_KR()
		{
			FileStream fs = new FileStream("KR.txt",FileMode.Create);
			BinaryWriter writer = new BinaryWriter(fs);
			
			string buffer = String.Format("@K_R,{0},{1},{2},{3},{4},{5},{6},{7},{8},@END;", 
			                              data.Kp_r_d, data.Ki_r_d, data.Kd_r_d,
			                             data.Kp_p_d, data.Ki_p_d, data.Kd_p_d,
			                            data.Kp_y_d, data.Ki_y_d, data.Kd_y_d);
			
			writer.Write(buffer);
			writer.Close();
			
			MessageBox.Show("Angular Rate Control Gains Saved!");
		}
		
		void load_KR()
		{
			FileStream fs = new FileStream("KR.txt",FileMode.Open);
			BinaryReader reader = new BinaryReader(fs);
			string msg = reader.ReadString();
			
			string[] str = msg.Split(',');
			
			data.Kp_r_d = Convert.ToDouble(str[1]);
			data.Ki_r_d = Convert.ToDouble(str[2]);
			data.Kd_r_d = Convert.ToDouble(str[3]);
			
			data.Kp_p_d = Convert.ToDouble(str[4]);
			data.Ki_p_d = Convert.ToDouble(str[5]);
			data.Kd_p_d = Convert.ToDouble(str[6]);
			
			data.Kp_y_d = Convert.ToDouble(str[7]);
			data.Ki_y_d = Convert.ToDouble(str[8]);
			data.Kd_y_d = Convert.ToDouble(str[9]);
			
			refresh_KR();
			
			reader.Close();
			MessageBox.Show("Angular Rate Control Gains Loaded!");
			
			
		}
		
		// Position PID Tuner \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
		
		
		
		// Longitude Tuner
		
		void KpLon_barScroll(object sender, ScrollEventArgs e)
		{
			KpLon_text.Text = processBar(ref data.Kp_lon, KpLon_bar.Value);
		}		
		void KpLon_textTextChanged(object sender, EventArgs e)
		{
			KpLon_bar.Value = processText(ref data.Kp_lon, KpLon_text.Text);
		}
		
		void KiLon_barScroll(object sender, ScrollEventArgs e)
		{
			KiLon_text.Text = processBar(ref data.Ki_lon, KiLon_bar.Value);
		}		
		void KiLon_textTextChanged(object sender, EventArgs e)
		{
			KiLon_bar.Value = processText(ref data.Ki_lon, KiLon_text.Text);
		}		
		
		void KdLon_barScroll(object sender, ScrollEventArgs e)
		{
			KdLon_text.Text = processBar(ref data.Kd_lon, KdLon_bar.Value);
		}
		void KdLon_textTextChanged(object sender, EventArgs e)
		{
			KdLon_bar.Value = processText(ref data.Kd_lon, KdLon_text.Text);
		}
		
		
		// Latitude Tuner
		
		void KpLat_barScroll(object sender, ScrollEventArgs e)
		{
			KpLat_text.Text = processBar(ref data.Kp_lat, KpLat_bar.Value);
		}		
		void KpLat_textTextChanged(object sender, EventArgs e)
		{
			KpLat_bar.Value = processText(ref data.Kp_lat, KpLat_text.Text);
		}
		
		void KiLat_barScroll(object sender, ScrollEventArgs e)
		{
			KiLat_text.Text = processBar(ref data.Ki_lat, KiLat_bar.Value);
		}		
		void KiLat_textTextChanged(object sender, EventArgs e)
		{
			KiLat_bar.Value = processText(ref data.Ki_lat, KiLat_text.Text);
		}		
		
		void KdLat_barScroll(object sender, ScrollEventArgs e)
		{
			KdLat_text.Text = processBar(ref data.Kd_lat, KdLat_bar.Value);
		}
		void KdLat_textTextChanged(object sender, EventArgs e)
		{
			KdLat_bar.Value = processText(ref data.Kd_lat, KdLat_text.Text);
		}

		
		// Altitude Tuner
		
		void KpAlt_barScroll(object sender, ScrollEventArgs e)
		{
			KpAlt_text.Text = processBar(ref data.Kp_h, KpAlt_bar.Value);
		}		
		void KpAlt_textTextChanged(object sender, EventArgs e)
		{
			KpAlt_bar.Value = processText(ref data.Kp_h, KpAlt_text.Text);
		}
		
		void KiAlt_barScroll(object sender, ScrollEventArgs e)
		{
			KiAlt_text.Text = processBar(ref data.Ki_h, KiAlt_bar.Value);
		}		
		void KiAlt_textTextChanged(object sender, EventArgs e)
		{
			KiAlt_bar.Value = processText(ref data.Ki_h, KiLat_text.Text);
		}		
		
		void KdAlt_barScroll(object sender, ScrollEventArgs e)
		{
			KdAlt_text.Text = processBar(ref data.Kd_h, KdAlt_bar.Value);
		}
		void KdAlt_textTextChanged(object sender, EventArgs e)
		{
			KdAlt_bar.Value = processText(ref data.Kd_h, KdAlt_text.Text);
		}

		
		// Command
		
		void refresh_KP()
		{
			KpLon_text.Text = Convert.ToString(data.Kp_lon);
			KiLon_text.Text = Convert.ToString(data.Ki_lon);
			KdLon_text.Text = Convert.ToString(data.Kd_lon);
			
			KpLat_text.Text = Convert.ToString(data.Kp_lat);
			KiLat_text.Text = Convert.ToString(data.Ki_lat);
			KdLat_text.Text = Convert.ToString(data.Kd_lat);
			
			KpAlt_text.Text = Convert.ToString(data.Kp_h);
			KiAlt_text.Text = Convert.ToString(data.Ki_h);
			KdAlt_text.Text = Convert.ToString(data.Kd_h);			
				
		}
		
		void save_KP()
		{
			FileStream fs = new FileStream("KP.txt",FileMode.Create);
			BinaryWriter writer = new BinaryWriter(fs);
			
			string buffer = String.Format("@K_P,{0},{1},{2},{3},{4},{5},{6},{7},{8},@END;", 
			                              data.Kp_lon, data.Ki_lon, data.Kd_lon,
			                             data.Kp_lat, data.Ki_lat, data.Kd_lat,
			                            data.Kp_h, data.Ki_h, data.Kd_h);
			
			writer.Write(buffer);
			writer.Close();
			
			MessageBox.Show("Position Control Gains Saved!");
		}
		
		void load_KP()
		{
			FileStream fs = new FileStream("KP.txt",FileMode.Open);
			BinaryReader reader = new BinaryReader(fs);
			string msg = reader.ReadString();
			
			string[] str = msg.Split(',');
			
			data.Kp_lon = Convert.ToDouble(str[1]);
			data.Ki_lon = Convert.ToDouble(str[2]);
			data.Kd_lon = Convert.ToDouble(str[3]);
			
			data.Kp_lat = Convert.ToDouble(str[4]);
			data.Ki_lat = Convert.ToDouble(str[5]);
			data.Kd_lat = Convert.ToDouble(str[6]);
			
			data.Kp_h = Convert.ToDouble(str[7]);
			data.Ki_h = Convert.ToDouble(str[8]);
			data.Kd_h = Convert.ToDouble(str[9]);
			
			refresh_KP();
			
			reader.Close();
			MessageBox.Show("Position Control Gains Loaded!");
			
			
		}
		void Button_KP_resetClick(object sender, EventArgs e)
		{
			data.Kp_lon = 0.0;
			data.Ki_lon = 0.0;
			data.Kd_lon = 0.0;
			
			data.Kp_lat = 0.0;
			data.Ki_lat = 0.0;
			data.Kd_lat = 0.0;
			
			data.Kp_h = 0.0;
			data.Ki_h = 0.0;
			data.Kd_h = 0.0;
			
			refresh_KP();
		}
		void Button_KP_saveClick(object sender, EventArgs e)
		{
			save_KP();
		}
		void Button_KP_loadClick(object sender, EventArgs e)
		{
			load_KP();
		}
		void Button_KP_sendallClick(object sender, EventArgs e)
		{
			string buffer = String.Format("@K_P,{0},{1},{2},{3},{4},{5},{6},{7},{8},@END;", 
			                              data.Kp_lon, data.Ki_lon, data.Kd_lon,
			                             data.Kp_lat, data.Ki_lat, data.Kd_lat,
			                            data.Kp_h, data.Ki_h, data.Kd_h);
			
			System.Diagnostics.Debug.WriteLine(buffer);
			
			port.Write(buffer);			
		}
		
		
		
		void CheckBox_overrideCheckedChanged(object sender, EventArgs e)
		{
			if(checkBox_override.Checked)
			{
				data.overrideMode = true;
				string buffer = "@OR,1,@END;";
				port.Write(buffer);
				System.Diagnostics.Debug.WriteLine(buffer);
			}
			else
			{
				data.overrideMode = false;
				string buffer = "@OR,0,@END;";
				port.Write(buffer);
				System.Diagnostics.Debug.WriteLine(buffer);
			}
		}

		
		void CheckBox_armCheckedChanged(object sender, EventArgs e)
		{
			if(checkBox_arm.Checked)
			{
				data.armMode = true;
				string buffer = "@AR,1,@END;";
				port.Write(buffer);
				System.Diagnostics.Debug.WriteLine(buffer);
			}
			else
			{
				data.armMode = false;
				string buffer = "@AR,0,@END;";
				port.Write(buffer);
				System.Diagnostics.Debug.WriteLine(buffer);
			}
		}

		

	}
}
