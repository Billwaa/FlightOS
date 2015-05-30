/*
 * Created by SharpDevelop.
 * User: Billwaa
 * Date: 1/10/2015
 * Time: 4:03 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Ground_Station_App
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabCOM = new System.Windows.Forms.TabPage();
			this.checkBox_arm = new System.Windows.Forms.CheckBox();
			this.checkBox_override = new System.Windows.Forms.CheckBox();
			this.sync_bar = new System.Windows.Forms.ProgressBar();
			this.button_uplink = new System.Windows.Forms.Button();
			this.label36 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.label34 = new System.Windows.Forms.Label();
			this.label33 = new System.Windows.Forms.Label();
			this.DL_height = new System.Windows.Forms.TextBox();
			this.DL_latitude = new System.Windows.Forms.TextBox();
			this.DL_longitude = new System.Windows.Forms.TextBox();
			this.button_emergency = new System.Windows.Forms.Button();
			this.latitudeT_text = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.longitudeT_text = new System.Windows.Forms.TextBox();
			this.label31 = new System.Windows.Forms.Label();
			this.heightT_text = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label24 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.DL_Motor3 = new System.Windows.Forms.TextBox();
			this.DL_Motor2 = new System.Windows.Forms.TextBox();
			this.DL_Motor1 = new System.Windows.Forms.TextBox();
			this.DL_Motor0 = new System.Windows.Forms.TextBox();
			this.DL_YawSignal = new System.Windows.Forms.TextBox();
			this.DL_PitchSignal = new System.Windows.Forms.TextBox();
			this.DL_RollSignal = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.DL_Time = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.DL_Yaw_d = new System.Windows.Forms.TextBox();
			this.DL_Pitch_d = new System.Windows.Forms.TextBox();
			this.DL_Roll_d = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.DL_Yaw = new System.Windows.Forms.TextBox();
			this.DL_Pitch = new System.Windows.Forms.TextBox();
			this.DL_Roll = new System.Windows.Forms.TextBox();
			this.throttle_text = new System.Windows.Forms.TextBox();
			this.pitchT_text = new System.Windows.Forms.TextBox();
			this.yawT_text = new System.Windows.Forms.TextBox();
			this.rollT_text = new System.Windows.Forms.TextBox();
			this.throttle_bar = new System.Windows.Forms.TrackBar();
			this.yawT_bar = new System.Windows.Forms.TrackBar();
			this.pitchT_bar = new System.Windows.Forms.TrackBar();
			this.rollT_bar = new System.Windows.Forms.TrackBar();
			this.label17 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.tabRate = new System.Windows.Forms.TabPage();
			this.button_KR_sendall = new System.Windows.Forms.Button();
			this.button_KR_load = new System.Windows.Forms.Button();
			this.button_KR_save = new System.Windows.Forms.Button();
			this.button_KR_reset = new System.Windows.Forms.Button();
			this.panel5 = new System.Windows.Forms.Panel();
			this.label41 = new System.Windows.Forms.Label();
			this.Kdyd_text = new System.Windows.Forms.TextBox();
			this.Kdyd_bar = new System.Windows.Forms.HScrollBar();
			this.label42 = new System.Windows.Forms.Label();
			this.Kiyd_text = new System.Windows.Forms.TextBox();
			this.Kiyd_bar = new System.Windows.Forms.HScrollBar();
			this.label43 = new System.Windows.Forms.Label();
			this.label44 = new System.Windows.Forms.Label();
			this.Kpyd_text = new System.Windows.Forms.TextBox();
			this.Kpyd_bar = new System.Windows.Forms.HScrollBar();
			this.panel6 = new System.Windows.Forms.Panel();
			this.label45 = new System.Windows.Forms.Label();
			this.Kdpd_text = new System.Windows.Forms.TextBox();
			this.Kdpd_bar = new System.Windows.Forms.HScrollBar();
			this.label46 = new System.Windows.Forms.Label();
			this.Kipd_text = new System.Windows.Forms.TextBox();
			this.Kipd_bar = new System.Windows.Forms.HScrollBar();
			this.label47 = new System.Windows.Forms.Label();
			this.label48 = new System.Windows.Forms.Label();
			this.Kppd_text = new System.Windows.Forms.TextBox();
			this.Kppd_bar = new System.Windows.Forms.HScrollBar();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label37 = new System.Windows.Forms.Label();
			this.Kdrd_text = new System.Windows.Forms.TextBox();
			this.Kdrd_bar = new System.Windows.Forms.HScrollBar();
			this.label38 = new System.Windows.Forms.Label();
			this.Kird_text = new System.Windows.Forms.TextBox();
			this.Kird_bar = new System.Windows.Forms.HScrollBar();
			this.label39 = new System.Windows.Forms.Label();
			this.label40 = new System.Windows.Forms.Label();
			this.Kprd_text = new System.Windows.Forms.TextBox();
			this.Kprd_bar = new System.Windows.Forms.HScrollBar();
			this.tabAttitude = new System.Windows.Forms.TabPage();
			this.button_KA_sendAll = new System.Windows.Forms.Button();
			this.button_KA_load = new System.Windows.Forms.Button();
			this.button_KA_save = new System.Windows.Forms.Button();
			this.button_KA_reset = new System.Windows.Forms.Button();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label12 = new System.Windows.Forms.Label();
			this.Kyd_text = new System.Windows.Forms.TextBox();
			this.Kyd_bar = new System.Windows.Forms.HScrollBar();
			this.label13 = new System.Windows.Forms.Label();
			this.Kyi_text = new System.Windows.Forms.TextBox();
			this.Kyi_bar = new System.Windows.Forms.HScrollBar();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.Kyp_text = new System.Windows.Forms.TextBox();
			this.Kyp_bar = new System.Windows.Forms.HScrollBar();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label7 = new System.Windows.Forms.Label();
			this.Kpd_text = new System.Windows.Forms.TextBox();
			this.Kpd_bar = new System.Windows.Forms.HScrollBar();
			this.label8 = new System.Windows.Forms.Label();
			this.Kpi_text = new System.Windows.Forms.TextBox();
			this.Kpi_bar = new System.Windows.Forms.HScrollBar();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.Kpp_text = new System.Windows.Forms.TextBox();
			this.Kpp_bar = new System.Windows.Forms.HScrollBar();
			this.panel4 = new System.Windows.Forms.Panel();
			this.label4 = new System.Windows.Forms.Label();
			this.Krd_text = new System.Windows.Forms.TextBox();
			this.Krd_bar = new System.Windows.Forms.HScrollBar();
			this.label3 = new System.Windows.Forms.Label();
			this.Kri_text = new System.Windows.Forms.TextBox();
			this.Kri_bar = new System.Windows.Forms.HScrollBar();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Krp_text = new System.Windows.Forms.TextBox();
			this.Krp_bar = new System.Windows.Forms.HScrollBar();
			this.tabPosition = new System.Windows.Forms.TabPage();
			this.button_KP_sendall = new System.Windows.Forms.Button();
			this.button_KP_load = new System.Windows.Forms.Button();
			this.button_KP_save = new System.Windows.Forms.Button();
			this.button_KP_reset = new System.Windows.Forms.Button();
			this.panel7 = new System.Windows.Forms.Panel();
			this.label49 = new System.Windows.Forms.Label();
			this.KdAlt_text = new System.Windows.Forms.TextBox();
			this.KdAlt_bar = new System.Windows.Forms.HScrollBar();
			this.label50 = new System.Windows.Forms.Label();
			this.KiAlt_text = new System.Windows.Forms.TextBox();
			this.KiAlt_bar = new System.Windows.Forms.HScrollBar();
			this.label51 = new System.Windows.Forms.Label();
			this.label52 = new System.Windows.Forms.Label();
			this.KpAlt_text = new System.Windows.Forms.TextBox();
			this.KpAlt_bar = new System.Windows.Forms.HScrollBar();
			this.panel8 = new System.Windows.Forms.Panel();
			this.label53 = new System.Windows.Forms.Label();
			this.KdLat_text = new System.Windows.Forms.TextBox();
			this.KdLat_bar = new System.Windows.Forms.HScrollBar();
			this.label54 = new System.Windows.Forms.Label();
			this.KiLat_text = new System.Windows.Forms.TextBox();
			this.KiLat_bar = new System.Windows.Forms.HScrollBar();
			this.label55 = new System.Windows.Forms.Label();
			this.label56 = new System.Windows.Forms.Label();
			this.KpLat_text = new System.Windows.Forms.TextBox();
			this.KpLat_bar = new System.Windows.Forms.HScrollBar();
			this.panel9 = new System.Windows.Forms.Panel();
			this.label57 = new System.Windows.Forms.Label();
			this.KdLon_text = new System.Windows.Forms.TextBox();
			this.KdLon_bar = new System.Windows.Forms.HScrollBar();
			this.label58 = new System.Windows.Forms.Label();
			this.KiLon_text = new System.Windows.Forms.TextBox();
			this.KiLon_bar = new System.Windows.Forms.HScrollBar();
			this.label59 = new System.Windows.Forms.Label();
			this.label60 = new System.Windows.Forms.Label();
			this.KpLon_text = new System.Windows.Forms.TextBox();
			this.KpLon_bar = new System.Windows.Forms.HScrollBar();
			this.tabControl1.SuspendLayout();
			this.tabCOM.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.throttle_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.yawT_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pitchT_bar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.rollT_bar)).BeginInit();
			this.tabRate.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel3.SuspendLayout();
			this.tabAttitude.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel4.SuspendLayout();
			this.tabPosition.SuspendLayout();
			this.panel7.SuspendLayout();
			this.panel8.SuspendLayout();
			this.panel9.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabCOM);
			this.tabControl1.Controls.Add(this.tabRate);
			this.tabControl1.Controls.Add(this.tabAttitude);
			this.tabControl1.Controls.Add(this.tabPosition);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(760, 538);
			this.tabControl1.TabIndex = 0;
			// 
			// tabCOM
			// 
			this.tabCOM.Controls.Add(this.checkBox_arm);
			this.tabCOM.Controls.Add(this.checkBox_override);
			this.tabCOM.Controls.Add(this.sync_bar);
			this.tabCOM.Controls.Add(this.button_uplink);
			this.tabCOM.Controls.Add(this.label36);
			this.tabCOM.Controls.Add(this.label35);
			this.tabCOM.Controls.Add(this.label34);
			this.tabCOM.Controls.Add(this.label33);
			this.tabCOM.Controls.Add(this.DL_height);
			this.tabCOM.Controls.Add(this.DL_latitude);
			this.tabCOM.Controls.Add(this.DL_longitude);
			this.tabCOM.Controls.Add(this.button_emergency);
			this.tabCOM.Controls.Add(this.latitudeT_text);
			this.tabCOM.Controls.Add(this.label32);
			this.tabCOM.Controls.Add(this.longitudeT_text);
			this.tabCOM.Controls.Add(this.label31);
			this.tabCOM.Controls.Add(this.heightT_text);
			this.tabCOM.Controls.Add(this.label30);
			this.tabCOM.Controls.Add(this.label29);
			this.tabCOM.Controls.Add(this.label28);
			this.tabCOM.Controls.Add(this.label27);
			this.tabCOM.Controls.Add(this.label26);
			this.tabCOM.Controls.Add(this.label25);
			this.tabCOM.Controls.Add(this.label24);
			this.tabCOM.Controls.Add(this.label23);
			this.tabCOM.Controls.Add(this.label22);
			this.tabCOM.Controls.Add(this.DL_Motor3);
			this.tabCOM.Controls.Add(this.DL_Motor2);
			this.tabCOM.Controls.Add(this.DL_Motor1);
			this.tabCOM.Controls.Add(this.DL_Motor0);
			this.tabCOM.Controls.Add(this.DL_YawSignal);
			this.tabCOM.Controls.Add(this.DL_PitchSignal);
			this.tabCOM.Controls.Add(this.DL_RollSignal);
			this.tabCOM.Controls.Add(this.label21);
			this.tabCOM.Controls.Add(this.DL_Time);
			this.tabCOM.Controls.Add(this.label20);
			this.tabCOM.Controls.Add(this.label19);
			this.tabCOM.Controls.Add(this.label18);
			this.tabCOM.Controls.Add(this.label11);
			this.tabCOM.Controls.Add(this.label6);
			this.tabCOM.Controls.Add(this.DL_Yaw_d);
			this.tabCOM.Controls.Add(this.DL_Pitch_d);
			this.tabCOM.Controls.Add(this.DL_Roll_d);
			this.tabCOM.Controls.Add(this.label5);
			this.tabCOM.Controls.Add(this.DL_Yaw);
			this.tabCOM.Controls.Add(this.DL_Pitch);
			this.tabCOM.Controls.Add(this.DL_Roll);
			this.tabCOM.Controls.Add(this.throttle_text);
			this.tabCOM.Controls.Add(this.pitchT_text);
			this.tabCOM.Controls.Add(this.yawT_text);
			this.tabCOM.Controls.Add(this.rollT_text);
			this.tabCOM.Controls.Add(this.throttle_bar);
			this.tabCOM.Controls.Add(this.yawT_bar);
			this.tabCOM.Controls.Add(this.pitchT_bar);
			this.tabCOM.Controls.Add(this.rollT_bar);
			this.tabCOM.Controls.Add(this.label17);
			this.tabCOM.Controls.Add(this.label16);
			this.tabCOM.Location = new System.Drawing.Point(4, 22);
			this.tabCOM.Name = "tabCOM";
			this.tabCOM.Padding = new System.Windows.Forms.Padding(3);
			this.tabCOM.Size = new System.Drawing.Size(752, 512);
			this.tabCOM.TabIndex = 0;
			this.tabCOM.Text = "FlightCOM";
			this.tabCOM.UseVisualStyleBackColor = true;
			// 
			// checkBox_arm
			// 
			this.checkBox_arm.Location = new System.Drawing.Point(7, 258);
			this.checkBox_arm.Name = "checkBox_arm";
			this.checkBox_arm.Size = new System.Drawing.Size(104, 24);
			this.checkBox_arm.TabIndex = 59;
			this.checkBox_arm.Text = "Arm FlightOS";
			this.checkBox_arm.UseVisualStyleBackColor = true;
			this.checkBox_arm.CheckedChanged += new System.EventHandler(this.CheckBox_armCheckedChanged);
			// 
			// checkBox_override
			// 
			this.checkBox_override.Location = new System.Drawing.Point(7, 228);
			this.checkBox_override.Name = "checkBox_override";
			this.checkBox_override.Size = new System.Drawing.Size(104, 24);
			this.checkBox_override.TabIndex = 58;
			this.checkBox_override.Text = "Override RC";
			this.checkBox_override.UseVisualStyleBackColor = true;
			this.checkBox_override.CheckedChanged += new System.EventHandler(this.CheckBox_overrideCheckedChanged);
			// 
			// sync_bar
			// 
			this.sync_bar.Location = new System.Drawing.Point(612, 486);
			this.sync_bar.Name = "sync_bar";
			this.sync_bar.Size = new System.Drawing.Size(100, 20);
			this.sync_bar.TabIndex = 57;
			// 
			// button_uplink
			// 
			this.button_uplink.Location = new System.Drawing.Point(612, 459);
			this.button_uplink.Name = "button_uplink";
			this.button_uplink.Size = new System.Drawing.Size(100, 23);
			this.button_uplink.TabIndex = 56;
			this.button_uplink.Text = "Uplink Commands";
			this.button_uplink.UseVisualStyleBackColor = true;
			this.button_uplink.Click += new System.EventHandler(this.Button_uplinkClick);
			// 
			// label36
			// 
			this.label36.Location = new System.Drawing.Point(7, 165);
			this.label36.Name = "label36";
			this.label36.Size = new System.Drawing.Size(74, 23);
			this.label36.TabIndex = 55;
			this.label36.Text = "Navigation";
			this.label36.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label35
			// 
			this.label35.Location = new System.Drawing.Point(301, 136);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(100, 23);
			this.label35.TabIndex = 54;
			this.label35.Text = "Height";
			this.label35.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label34
			// 
			this.label34.Location = new System.Drawing.Point(194, 136);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(100, 23);
			this.label34.TabIndex = 53;
			this.label34.Text = "Latitude";
			this.label34.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label33
			// 
			this.label33.Location = new System.Drawing.Point(87, 136);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(100, 23);
			this.label33.TabIndex = 52;
			this.label33.Text = "Longitude";
			this.label33.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// DL_height
			// 
			this.DL_height.Location = new System.Drawing.Point(301, 165);
			this.DL_height.Name = "DL_height";
			this.DL_height.Size = new System.Drawing.Size(100, 20);
			this.DL_height.TabIndex = 51;
			// 
			// DL_latitude
			// 
			this.DL_latitude.Location = new System.Drawing.Point(194, 165);
			this.DL_latitude.Name = "DL_latitude";
			this.DL_latitude.Size = new System.Drawing.Size(100, 20);
			this.DL_latitude.TabIndex = 50;
			// 
			// DL_longitude
			// 
			this.DL_longitude.Location = new System.Drawing.Point(87, 165);
			this.DL_longitude.Name = "DL_longitude";
			this.DL_longitude.Size = new System.Drawing.Size(100, 20);
			this.DL_longitude.TabIndex = 49;
			// 
			// button_emergency
			// 
			this.button_emergency.BackColor = System.Drawing.Color.Transparent;
			this.button_emergency.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_emergency.ForeColor = System.Drawing.Color.Red;
			this.button_emergency.Location = new System.Drawing.Point(397, 201);
			this.button_emergency.Name = "button_emergency";
			this.button_emergency.Size = new System.Drawing.Size(319, 23);
			this.button_emergency.TabIndex = 48;
			this.button_emergency.Text = "Emergency Override";
			this.button_emergency.UseVisualStyleBackColor = false;
			this.button_emergency.Click += new System.EventHandler(this.Button_emergencyClick);
			// 
			// latitudeT_text
			// 
			this.latitudeT_text.Location = new System.Drawing.Point(612, 416);
			this.latitudeT_text.Name = "latitudeT_text";
			this.latitudeT_text.Size = new System.Drawing.Size(100, 20);
			this.latitudeT_text.TabIndex = 46;
			this.latitudeT_text.TextChanged += new System.EventHandler(this.LatitudeT_textTextChanged);
			// 
			// label32
			// 
			this.label32.Location = new System.Drawing.Point(612, 389);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(100, 23);
			this.label32.TabIndex = 45;
			this.label32.Text = "Latitude Target";
			this.label32.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// longitudeT_text
			// 
			this.longitudeT_text.Location = new System.Drawing.Point(612, 362);
			this.longitudeT_text.Name = "longitudeT_text";
			this.longitudeT_text.Size = new System.Drawing.Size(100, 20);
			this.longitudeT_text.TabIndex = 44;
			this.longitudeT_text.TextChanged += new System.EventHandler(this.LongitudeT_textTextChanged);
			// 
			// label31
			// 
			this.label31.Location = new System.Drawing.Point(612, 335);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(100, 23);
			this.label31.TabIndex = 43;
			this.label31.Text = "Longitude Target";
			this.label31.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// heightT_text
			// 
			this.heightT_text.Location = new System.Drawing.Point(612, 296);
			this.heightT_text.Name = "heightT_text";
			this.heightT_text.Size = new System.Drawing.Size(100, 20);
			this.heightT_text.TabIndex = 42;
			this.heightT_text.TextChanged += new System.EventHandler(this.HeightT_textTextChanged);
			// 
			// label30
			// 
			this.label30.Location = new System.Drawing.Point(612, 267);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(100, 23);
			this.label30.TabIndex = 41;
			this.label30.Text = "Height Target";
			this.label30.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label29
			// 
			this.label29.Location = new System.Drawing.Point(449, 376);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(100, 23);
			this.label29.TabIndex = 40;
			this.label29.Text = "Throttle";
			this.label29.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label28
			// 
			this.label28.Location = new System.Drawing.Point(449, 267);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(100, 23);
			this.label28.TabIndex = 39;
			this.label28.Text = "Pitch Target";
			this.label28.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label27
			// 
			this.label27.Location = new System.Drawing.Point(140, 350);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(100, 23);
			this.label27.TabIndex = 38;
			this.label27.Text = "Yaw Target";
			this.label27.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label26
			// 
			this.label26.Location = new System.Drawing.Point(140, 234);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(100, 23);
			this.label26.TabIndex = 37;
			this.label26.Text = "Roll Target";
			this.label26.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(597, 32);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(100, 23);
			this.label25.TabIndex = 36;
			this.label25.Text = "Motor 0";
			this.label25.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label24
			// 
			this.label24.Location = new System.Drawing.Point(490, 32);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(100, 23);
			this.label24.TabIndex = 35;
			this.label24.Text = "Motor 1";
			this.label24.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(597, 88);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(100, 23);
			this.label23.TabIndex = 34;
			this.label23.Text = "Motor 3";
			this.label23.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(490, 88);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(100, 23);
			this.label22.TabIndex = 33;
			this.label22.Text = "Motor 2";
			this.label22.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// DL_Motor3
			// 
			this.DL_Motor3.Location = new System.Drawing.Point(597, 117);
			this.DL_Motor3.Name = "DL_Motor3";
			this.DL_Motor3.Size = new System.Drawing.Size(100, 20);
			this.DL_Motor3.TabIndex = 32;
			// 
			// DL_Motor2
			// 
			this.DL_Motor2.Location = new System.Drawing.Point(490, 117);
			this.DL_Motor2.Name = "DL_Motor2";
			this.DL_Motor2.Size = new System.Drawing.Size(100, 20);
			this.DL_Motor2.TabIndex = 31;
			// 
			// DL_Motor1
			// 
			this.DL_Motor1.Location = new System.Drawing.Point(490, 59);
			this.DL_Motor1.Name = "DL_Motor1";
			this.DL_Motor1.Size = new System.Drawing.Size(100, 20);
			this.DL_Motor1.TabIndex = 30;
			// 
			// DL_Motor0
			// 
			this.DL_Motor0.Location = new System.Drawing.Point(596, 59);
			this.DL_Motor0.Name = "DL_Motor0";
			this.DL_Motor0.Size = new System.Drawing.Size(100, 20);
			this.DL_Motor0.TabIndex = 29;
			// 
			// DL_YawSignal
			// 
			this.DL_YawSignal.Location = new System.Drawing.Point(300, 112);
			this.DL_YawSignal.Name = "DL_YawSignal";
			this.DL_YawSignal.Size = new System.Drawing.Size(100, 20);
			this.DL_YawSignal.TabIndex = 28;
			// 
			// DL_PitchSignal
			// 
			this.DL_PitchSignal.Location = new System.Drawing.Point(193, 112);
			this.DL_PitchSignal.Name = "DL_PitchSignal";
			this.DL_PitchSignal.Size = new System.Drawing.Size(100, 20);
			this.DL_PitchSignal.TabIndex = 27;
			// 
			// DL_RollSignal
			// 
			this.DL_RollSignal.Location = new System.Drawing.Point(87, 112);
			this.DL_RollSignal.Name = "DL_RollSignal";
			this.DL_RollSignal.Size = new System.Drawing.Size(100, 20);
			this.DL_RollSignal.TabIndex = 26;
			// 
			// label21
			// 
			this.label21.Location = new System.Drawing.Point(7, 115);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(74, 23);
			this.label21.TabIndex = 25;
			this.label21.Text = "PID Signal";
			this.label21.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// DL_Time
			// 
			this.DL_Time.Location = new System.Drawing.Point(550, 9);
			this.DL_Time.Name = "DL_Time";
			this.DL_Time.Size = new System.Drawing.Size(100, 20);
			this.DL_Time.TabIndex = 24;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(449, 7);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(100, 23);
			this.label20.TabIndex = 23;
			this.label20.Text = "Flight Time";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label19
			// 
			this.label19.Location = new System.Drawing.Point(299, 33);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(100, 23);
			this.label19.TabIndex = 22;
			this.label19.Text = "Yaw";
			this.label19.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(193, 33);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(100, 23);
			this.label18.TabIndex = 21;
			this.label18.Text = "Pitch";
			this.label18.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(87, 33);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 20;
			this.label11.Text = "Roll";
			this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(7, 59);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(74, 23);
			this.label6.TabIndex = 19;
			this.label6.Text = "Angle";
			this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// DL_Yaw_d
			// 
			this.DL_Yaw_d.Location = new System.Drawing.Point(299, 85);
			this.DL_Yaw_d.Name = "DL_Yaw_d";
			this.DL_Yaw_d.Size = new System.Drawing.Size(100, 20);
			this.DL_Yaw_d.TabIndex = 18;
			// 
			// DL_Pitch_d
			// 
			this.DL_Pitch_d.Location = new System.Drawing.Point(193, 85);
			this.DL_Pitch_d.Name = "DL_Pitch_d";
			this.DL_Pitch_d.Size = new System.Drawing.Size(100, 20);
			this.DL_Pitch_d.TabIndex = 17;
			// 
			// DL_Roll_d
			// 
			this.DL_Roll_d.Location = new System.Drawing.Point(87, 85);
			this.DL_Roll_d.Name = "DL_Roll_d";
			this.DL_Roll_d.Size = new System.Drawing.Size(100, 20);
			this.DL_Roll_d.TabIndex = 16;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 88);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(74, 23);
			this.label5.TabIndex = 15;
			this.label5.Text = "Angular Rate";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// DL_Yaw
			// 
			this.DL_Yaw.Location = new System.Drawing.Point(299, 59);
			this.DL_Yaw.Name = "DL_Yaw";
			this.DL_Yaw.Size = new System.Drawing.Size(100, 20);
			this.DL_Yaw.TabIndex = 14;
			// 
			// DL_Pitch
			// 
			this.DL_Pitch.Location = new System.Drawing.Point(193, 59);
			this.DL_Pitch.Name = "DL_Pitch";
			this.DL_Pitch.Size = new System.Drawing.Size(100, 20);
			this.DL_Pitch.TabIndex = 13;
			// 
			// DL_Roll
			// 
			this.DL_Roll.Location = new System.Drawing.Point(87, 59);
			this.DL_Roll.Name = "DL_Roll";
			this.DL_Roll.Size = new System.Drawing.Size(100, 20);
			this.DL_Roll.TabIndex = 12;
			// 
			// throttle_text
			// 
			this.throttle_text.Location = new System.Drawing.Point(449, 405);
			this.throttle_text.Name = "throttle_text";
			this.throttle_text.Size = new System.Drawing.Size(95, 20);
			this.throttle_text.TabIndex = 9;
			this.throttle_text.TextChanged += new System.EventHandler(this.Throttle_textTextChanged);
			// 
			// pitchT_text
			// 
			this.pitchT_text.Location = new System.Drawing.Point(449, 296);
			this.pitchT_text.Name = "pitchT_text";
			this.pitchT_text.Size = new System.Drawing.Size(95, 20);
			this.pitchT_text.TabIndex = 8;
			this.pitchT_text.TextChanged += new System.EventHandler(this.PitchT_textTextChanged);
			// 
			// yawT_text
			// 
			this.yawT_text.Location = new System.Drawing.Point(140, 379);
			this.yawT_text.Name = "yawT_text";
			this.yawT_text.Size = new System.Drawing.Size(100, 20);
			this.yawT_text.TabIndex = 7;
			this.yawT_text.TextChanged += new System.EventHandler(this.YawT_textTextChanged);
			// 
			// rollT_text
			// 
			this.rollT_text.Location = new System.Drawing.Point(140, 263);
			this.rollT_text.Name = "rollT_text";
			this.rollT_text.Size = new System.Drawing.Size(100, 20);
			this.rollT_text.TabIndex = 6;
			this.rollT_text.TextChanged += new System.EventHandler(this.RollT_textTextChanged);
			// 
			// throttle_bar
			// 
			this.throttle_bar.Location = new System.Drawing.Point(550, 263);
			this.throttle_bar.Maximum = 1600;
			this.throttle_bar.Minimum = 1150;
			this.throttle_bar.Name = "throttle_bar";
			this.throttle_bar.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.throttle_bar.Size = new System.Drawing.Size(45, 219);
			this.throttle_bar.TabIndex = 5;
			this.throttle_bar.TickFrequency = 10;
			this.throttle_bar.Value = 1150;
			this.throttle_bar.Scroll += new System.EventHandler(this.Throttle_barScroll);
			// 
			// yawT_bar
			// 
			this.yawT_bar.Location = new System.Drawing.Point(7, 405);
			this.yawT_bar.Maximum = 90;
			this.yawT_bar.Minimum = -90;
			this.yawT_bar.Name = "yawT_bar";
			this.yawT_bar.Size = new System.Drawing.Size(368, 45);
			this.yawT_bar.TabIndex = 5;
			this.yawT_bar.TickFrequency = 5;
			this.yawT_bar.Scroll += new System.EventHandler(this.YawT_barScroll);
			// 
			// pitchT_bar
			// 
			this.pitchT_bar.BackColor = System.Drawing.SystemColors.Control;
			this.pitchT_bar.Location = new System.Drawing.Point(397, 263);
			this.pitchT_bar.Maximum = 45;
			this.pitchT_bar.Minimum = -45;
			this.pitchT_bar.Name = "pitchT_bar";
			this.pitchT_bar.Orientation = System.Windows.Forms.Orientation.Vertical;
			this.pitchT_bar.Size = new System.Drawing.Size(45, 219);
			this.pitchT_bar.TabIndex = 1;
			this.pitchT_bar.Scroll += new System.EventHandler(this.PitchT_barScroll);
			// 
			// rollT_bar
			// 
			this.rollT_bar.Location = new System.Drawing.Point(7, 296);
			this.rollT_bar.Maximum = 45;
			this.rollT_bar.Minimum = -45;
			this.rollT_bar.Name = "rollT_bar";
			this.rollT_bar.Size = new System.Drawing.Size(368, 45);
			this.rollT_bar.TabIndex = 1;
			this.rollT_bar.Scroll += new System.EventHandler(this.RollT_barScroll);
			// 
			// label17
			// 
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(7, 201);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(180, 23);
			this.label17.TabIndex = 1;
			this.label17.Text = "Command Uplink";
			// 
			// label16
			// 
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(7, 7);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(180, 23);
			this.label16.TabIndex = 0;
			this.label16.Text = "Telemetry Downlink";
			// 
			// tabRate
			// 
			this.tabRate.Controls.Add(this.button_KR_sendall);
			this.tabRate.Controls.Add(this.button_KR_load);
			this.tabRate.Controls.Add(this.button_KR_save);
			this.tabRate.Controls.Add(this.button_KR_reset);
			this.tabRate.Controls.Add(this.panel5);
			this.tabRate.Controls.Add(this.panel6);
			this.tabRate.Controls.Add(this.panel3);
			this.tabRate.Location = new System.Drawing.Point(4, 22);
			this.tabRate.Name = "tabRate";
			this.tabRate.Padding = new System.Windows.Forms.Padding(3);
			this.tabRate.Size = new System.Drawing.Size(752, 512);
			this.tabRate.TabIndex = 6;
			this.tabRate.Text = "Angular Rate Tuner";
			this.tabRate.UseVisualStyleBackColor = true;
			// 
			// button_KR_sendall
			// 
			this.button_KR_sendall.Location = new System.Drawing.Point(660, 174);
			this.button_KR_sendall.Name = "button_KR_sendall";
			this.button_KR_sendall.Size = new System.Drawing.Size(89, 23);
			this.button_KR_sendall.TabIndex = 17;
			this.button_KR_sendall.Text = "Send All";
			this.button_KR_sendall.UseVisualStyleBackColor = true;
			this.button_KR_sendall.Click += new System.EventHandler(this.Button_KR_sendallClick);
			// 
			// button_KR_load
			// 
			this.button_KR_load.Location = new System.Drawing.Point(660, 145);
			this.button_KR_load.Name = "button_KR_load";
			this.button_KR_load.Size = new System.Drawing.Size(89, 23);
			this.button_KR_load.TabIndex = 16;
			this.button_KR_load.Text = "Load";
			this.button_KR_load.UseVisualStyleBackColor = true;
			this.button_KR_load.Click += new System.EventHandler(this.Button_KR_loadClick);
			// 
			// button_KR_save
			// 
			this.button_KR_save.Location = new System.Drawing.Point(660, 116);
			this.button_KR_save.Name = "button_KR_save";
			this.button_KR_save.Size = new System.Drawing.Size(89, 23);
			this.button_KR_save.TabIndex = 15;
			this.button_KR_save.Text = "Save";
			this.button_KR_save.UseVisualStyleBackColor = true;
			this.button_KR_save.Click += new System.EventHandler(this.Button_KR_saveClick);
			// 
			// button_KR_reset
			// 
			this.button_KR_reset.Location = new System.Drawing.Point(660, 87);
			this.button_KR_reset.Name = "button_KR_reset";
			this.button_KR_reset.Size = new System.Drawing.Size(89, 23);
			this.button_KR_reset.TabIndex = 14;
			this.button_KR_reset.Text = "Reset";
			this.button_KR_reset.UseVisualStyleBackColor = true;
			this.button_KR_reset.Click += new System.EventHandler(this.Button_KR_resetClick);
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label41);
			this.panel5.Controls.Add(this.Kdyd_text);
			this.panel5.Controls.Add(this.Kdyd_bar);
			this.panel5.Controls.Add(this.label42);
			this.panel5.Controls.Add(this.Kiyd_text);
			this.panel5.Controls.Add(this.Kiyd_bar);
			this.panel5.Controls.Add(this.label43);
			this.panel5.Controls.Add(this.label44);
			this.panel5.Controls.Add(this.Kpyd_text);
			this.panel5.Controls.Add(this.Kpyd_bar);
			this.panel5.Location = new System.Drawing.Point(22, 333);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(628, 144);
			this.panel5.TabIndex = 13;
			// 
			// label41
			// 
			this.label41.Location = new System.Drawing.Point(323, 28);
			this.label41.Name = "label41";
			this.label41.Size = new System.Drawing.Size(142, 23);
			this.label41.TabIndex = 9;
			this.label41.Text = "Derivative";
			this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kdyd_text
			// 
			this.Kdyd_text.Location = new System.Drawing.Point(323, 54);
			this.Kdyd_text.Name = "Kdyd_text";
			this.Kdyd_text.Size = new System.Drawing.Size(142, 20);
			this.Kdyd_text.TabIndex = 8;
			this.Kdyd_text.TextChanged += new System.EventHandler(this.Kdyd_textTextChanged);
			// 
			// Kdyd_bar
			// 
			this.Kdyd_bar.Location = new System.Drawing.Point(323, 77);
			this.Kdyd_bar.Maximum = 500;
			this.Kdyd_bar.Name = "Kdyd_bar";
			this.Kdyd_bar.Size = new System.Drawing.Size(142, 23);
			this.Kdyd_bar.TabIndex = 7;
			this.Kdyd_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kdyd_barScroll);
			// 
			// label42
			// 
			this.label42.Location = new System.Drawing.Point(175, 28);
			this.label42.Name = "label42";
			this.label42.Size = new System.Drawing.Size(142, 23);
			this.label42.TabIndex = 6;
			this.label42.Text = "Integral";
			this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kiyd_text
			// 
			this.Kiyd_text.Location = new System.Drawing.Point(175, 54);
			this.Kiyd_text.Name = "Kiyd_text";
			this.Kiyd_text.Size = new System.Drawing.Size(142, 20);
			this.Kiyd_text.TabIndex = 5;
			this.Kiyd_text.TextChanged += new System.EventHandler(this.Kiyd_textTextChanged);
			// 
			// Kiyd_bar
			// 
			this.Kiyd_bar.Location = new System.Drawing.Point(175, 77);
			this.Kiyd_bar.Maximum = 500;
			this.Kiyd_bar.Name = "Kiyd_bar";
			this.Kiyd_bar.Size = new System.Drawing.Size(142, 23);
			this.Kiyd_bar.TabIndex = 4;
			this.Kiyd_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kiyd_barScroll);
			// 
			// label43
			// 
			this.label43.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label43.Location = new System.Drawing.Point(0, 0);
			this.label43.Name = "label43";
			this.label43.Size = new System.Drawing.Size(132, 23);
			this.label43.TabIndex = 3;
			this.label43.Text = "Yaw Rate Parameters";
			// 
			// label44
			// 
			this.label44.Location = new System.Drawing.Point(27, 28);
			this.label44.Name = "label44";
			this.label44.Size = new System.Drawing.Size(142, 23);
			this.label44.TabIndex = 2;
			this.label44.Text = "Proportional";
			this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kpyd_text
			// 
			this.Kpyd_text.Location = new System.Drawing.Point(27, 54);
			this.Kpyd_text.Name = "Kpyd_text";
			this.Kpyd_text.Size = new System.Drawing.Size(142, 20);
			this.Kpyd_text.TabIndex = 1;
			this.Kpyd_text.TextChanged += new System.EventHandler(this.Kpyd_textTextChanged);
			// 
			// Kpyd_bar
			// 
			this.Kpyd_bar.Location = new System.Drawing.Point(27, 77);
			this.Kpyd_bar.Maximum = 500;
			this.Kpyd_bar.Name = "Kpyd_bar";
			this.Kpyd_bar.Size = new System.Drawing.Size(142, 23);
			this.Kpyd_bar.TabIndex = 0;
			this.Kpyd_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kpyd_barScroll);
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.label45);
			this.panel6.Controls.Add(this.Kdpd_text);
			this.panel6.Controls.Add(this.Kdpd_bar);
			this.panel6.Controls.Add(this.label46);
			this.panel6.Controls.Add(this.Kipd_text);
			this.panel6.Controls.Add(this.Kipd_bar);
			this.panel6.Controls.Add(this.label47);
			this.panel6.Controls.Add(this.label48);
			this.panel6.Controls.Add(this.Kppd_text);
			this.panel6.Controls.Add(this.Kppd_bar);
			this.panel6.Location = new System.Drawing.Point(22, 183);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(628, 144);
			this.panel6.TabIndex = 13;
			// 
			// label45
			// 
			this.label45.Location = new System.Drawing.Point(323, 28);
			this.label45.Name = "label45";
			this.label45.Size = new System.Drawing.Size(142, 23);
			this.label45.TabIndex = 9;
			this.label45.Text = "Derivative";
			this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kdpd_text
			// 
			this.Kdpd_text.Location = new System.Drawing.Point(323, 54);
			this.Kdpd_text.Name = "Kdpd_text";
			this.Kdpd_text.Size = new System.Drawing.Size(142, 20);
			this.Kdpd_text.TabIndex = 8;
			this.Kdpd_text.TextChanged += new System.EventHandler(this.Kdpd_textTextChanged);
			// 
			// Kdpd_bar
			// 
			this.Kdpd_bar.Location = new System.Drawing.Point(323, 77);
			this.Kdpd_bar.Maximum = 500;
			this.Kdpd_bar.Name = "Kdpd_bar";
			this.Kdpd_bar.Size = new System.Drawing.Size(142, 23);
			this.Kdpd_bar.TabIndex = 7;
			this.Kdpd_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kdpd_barScroll);
			// 
			// label46
			// 
			this.label46.Location = new System.Drawing.Point(175, 28);
			this.label46.Name = "label46";
			this.label46.Size = new System.Drawing.Size(142, 23);
			this.label46.TabIndex = 6;
			this.label46.Text = "Integral";
			this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kipd_text
			// 
			this.Kipd_text.Location = new System.Drawing.Point(175, 54);
			this.Kipd_text.Name = "Kipd_text";
			this.Kipd_text.Size = new System.Drawing.Size(142, 20);
			this.Kipd_text.TabIndex = 5;
			this.Kipd_text.TextChanged += new System.EventHandler(this.Kipd_textTextChanged);
			// 
			// Kipd_bar
			// 
			this.Kipd_bar.Location = new System.Drawing.Point(175, 77);
			this.Kipd_bar.Maximum = 500;
			this.Kipd_bar.Name = "Kipd_bar";
			this.Kipd_bar.Size = new System.Drawing.Size(142, 23);
			this.Kipd_bar.TabIndex = 4;
			this.Kipd_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kipd_barScroll);
			// 
			// label47
			// 
			this.label47.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label47.Location = new System.Drawing.Point(0, 0);
			this.label47.Name = "label47";
			this.label47.Size = new System.Drawing.Size(132, 23);
			this.label47.TabIndex = 3;
			this.label47.Text = "Pitch Rate Parameters";
			// 
			// label48
			// 
			this.label48.Location = new System.Drawing.Point(27, 28);
			this.label48.Name = "label48";
			this.label48.Size = new System.Drawing.Size(142, 23);
			this.label48.TabIndex = 2;
			this.label48.Text = "Proportional";
			this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kppd_text
			// 
			this.Kppd_text.Location = new System.Drawing.Point(27, 54);
			this.Kppd_text.Name = "Kppd_text";
			this.Kppd_text.Size = new System.Drawing.Size(142, 20);
			this.Kppd_text.TabIndex = 1;
			this.Kppd_text.TextChanged += new System.EventHandler(this.Kppd_textTextChanged);
			// 
			// Kppd_bar
			// 
			this.Kppd_bar.Location = new System.Drawing.Point(27, 77);
			this.Kppd_bar.Maximum = 500;
			this.Kppd_bar.Name = "Kppd_bar";
			this.Kppd_bar.Size = new System.Drawing.Size(142, 23);
			this.Kppd_bar.TabIndex = 0;
			this.Kppd_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kppd_barScroll);
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label37);
			this.panel3.Controls.Add(this.Kdrd_text);
			this.panel3.Controls.Add(this.Kdrd_bar);
			this.panel3.Controls.Add(this.label38);
			this.panel3.Controls.Add(this.Kird_text);
			this.panel3.Controls.Add(this.Kird_bar);
			this.panel3.Controls.Add(this.label39);
			this.panel3.Controls.Add(this.label40);
			this.panel3.Controls.Add(this.Kprd_text);
			this.panel3.Controls.Add(this.Kprd_bar);
			this.panel3.Location = new System.Drawing.Point(22, 33);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(628, 144);
			this.panel3.TabIndex = 2;
			// 
			// label37
			// 
			this.label37.Location = new System.Drawing.Point(323, 28);
			this.label37.Name = "label37";
			this.label37.Size = new System.Drawing.Size(142, 23);
			this.label37.TabIndex = 9;
			this.label37.Text = "Derivative";
			this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kdrd_text
			// 
			this.Kdrd_text.Location = new System.Drawing.Point(323, 54);
			this.Kdrd_text.Name = "Kdrd_text";
			this.Kdrd_text.Size = new System.Drawing.Size(142, 20);
			this.Kdrd_text.TabIndex = 8;
			this.Kdrd_text.TextChanged += new System.EventHandler(this.Kdrd_textTextChanged);
			// 
			// Kdrd_bar
			// 
			this.Kdrd_bar.Location = new System.Drawing.Point(323, 77);
			this.Kdrd_bar.Maximum = 500;
			this.Kdrd_bar.Name = "Kdrd_bar";
			this.Kdrd_bar.Size = new System.Drawing.Size(142, 23);
			this.Kdrd_bar.TabIndex = 7;
			this.Kdrd_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kdrd_barScroll);
			// 
			// label38
			// 
			this.label38.Location = new System.Drawing.Point(175, 28);
			this.label38.Name = "label38";
			this.label38.Size = new System.Drawing.Size(142, 23);
			this.label38.TabIndex = 6;
			this.label38.Text = "Integral";
			this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kird_text
			// 
			this.Kird_text.Location = new System.Drawing.Point(175, 54);
			this.Kird_text.Name = "Kird_text";
			this.Kird_text.Size = new System.Drawing.Size(142, 20);
			this.Kird_text.TabIndex = 5;
			this.Kird_text.TextChanged += new System.EventHandler(this.Kird_textTextChanged);
			// 
			// Kird_bar
			// 
			this.Kird_bar.Location = new System.Drawing.Point(175, 77);
			this.Kird_bar.Maximum = 500;
			this.Kird_bar.Name = "Kird_bar";
			this.Kird_bar.Size = new System.Drawing.Size(142, 23);
			this.Kird_bar.TabIndex = 4;
			this.Kird_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kird_barScroll);
			// 
			// label39
			// 
			this.label39.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label39.Location = new System.Drawing.Point(0, 0);
			this.label39.Name = "label39";
			this.label39.Size = new System.Drawing.Size(132, 23);
			this.label39.TabIndex = 3;
			this.label39.Text = "Roll Rate Parameters";
			// 
			// label40
			// 
			this.label40.Location = new System.Drawing.Point(27, 28);
			this.label40.Name = "label40";
			this.label40.Size = new System.Drawing.Size(142, 23);
			this.label40.TabIndex = 2;
			this.label40.Text = "Proportional";
			this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kprd_text
			// 
			this.Kprd_text.Location = new System.Drawing.Point(27, 54);
			this.Kprd_text.Name = "Kprd_text";
			this.Kprd_text.Size = new System.Drawing.Size(142, 20);
			this.Kprd_text.TabIndex = 1;
			this.Kprd_text.TextChanged += new System.EventHandler(this.Kprd_textTextChanged);
			// 
			// Kprd_bar
			// 
			this.Kprd_bar.Location = new System.Drawing.Point(27, 77);
			this.Kprd_bar.Maximum = 500;
			this.Kprd_bar.Name = "Kprd_bar";
			this.Kprd_bar.Size = new System.Drawing.Size(142, 23);
			this.Kprd_bar.TabIndex = 0;
			this.Kprd_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kprd_barScroll);
			// 
			// tabAttitude
			// 
			this.tabAttitude.Controls.Add(this.button_KA_sendAll);
			this.tabAttitude.Controls.Add(this.button_KA_load);
			this.tabAttitude.Controls.Add(this.button_KA_save);
			this.tabAttitude.Controls.Add(this.button_KA_reset);
			this.tabAttitude.Controls.Add(this.panel2);
			this.tabAttitude.Controls.Add(this.panel1);
			this.tabAttitude.Controls.Add(this.panel4);
			this.tabAttitude.Location = new System.Drawing.Point(4, 22);
			this.tabAttitude.Name = "tabAttitude";
			this.tabAttitude.Padding = new System.Windows.Forms.Padding(3);
			this.tabAttitude.Size = new System.Drawing.Size(752, 512);
			this.tabAttitude.TabIndex = 1;
			this.tabAttitude.Text = "Attitude Tuner";
			this.tabAttitude.UseVisualStyleBackColor = true;
			// 
			// button_KA_sendAll
			// 
			this.button_KA_sendAll.Location = new System.Drawing.Point(660, 174);
			this.button_KA_sendAll.Name = "button_KA_sendAll";
			this.button_KA_sendAll.Size = new System.Drawing.Size(89, 23);
			this.button_KA_sendAll.TabIndex = 17;
			this.button_KA_sendAll.Text = "Send All";
			this.button_KA_sendAll.UseVisualStyleBackColor = true;
			this.button_KA_sendAll.Click += new System.EventHandler(this.Button_KA_sendAllClick);
			// 
			// button_KA_load
			// 
			this.button_KA_load.Location = new System.Drawing.Point(660, 145);
			this.button_KA_load.Name = "button_KA_load";
			this.button_KA_load.Size = new System.Drawing.Size(89, 23);
			this.button_KA_load.TabIndex = 16;
			this.button_KA_load.Text = "Load";
			this.button_KA_load.UseVisualStyleBackColor = true;
			this.button_KA_load.Click += new System.EventHandler(this.Button_KA_loadClick);
			// 
			// button_KA_save
			// 
			this.button_KA_save.Location = new System.Drawing.Point(660, 116);
			this.button_KA_save.Name = "button_KA_save";
			this.button_KA_save.Size = new System.Drawing.Size(89, 23);
			this.button_KA_save.TabIndex = 15;
			this.button_KA_save.Text = "Save";
			this.button_KA_save.UseVisualStyleBackColor = true;
			this.button_KA_save.Click += new System.EventHandler(this.Button_KA_saveClick);
			// 
			// button_KA_reset
			// 
			this.button_KA_reset.Location = new System.Drawing.Point(660, 87);
			this.button_KA_reset.Name = "button_KA_reset";
			this.button_KA_reset.Size = new System.Drawing.Size(89, 23);
			this.button_KA_reset.TabIndex = 14;
			this.button_KA_reset.Text = "Reset";
			this.button_KA_reset.UseVisualStyleBackColor = true;
			this.button_KA_reset.Click += new System.EventHandler(this.Button_KA_resetClick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.Kyd_text);
			this.panel2.Controls.Add(this.Kyd_bar);
			this.panel2.Controls.Add(this.label13);
			this.panel2.Controls.Add(this.Kyi_text);
			this.panel2.Controls.Add(this.Kyi_bar);
			this.panel2.Controls.Add(this.label14);
			this.panel2.Controls.Add(this.label15);
			this.panel2.Controls.Add(this.Kyp_text);
			this.panel2.Controls.Add(this.Kyp_bar);
			this.panel2.Location = new System.Drawing.Point(22, 333);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(628, 144);
			this.panel2.TabIndex = 13;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(323, 28);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(142, 23);
			this.label12.TabIndex = 9;
			this.label12.Text = "Derivative";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kyd_text
			// 
			this.Kyd_text.Location = new System.Drawing.Point(323, 54);
			this.Kyd_text.Name = "Kyd_text";
			this.Kyd_text.Size = new System.Drawing.Size(142, 20);
			this.Kyd_text.TabIndex = 8;
			this.Kyd_text.TextChanged += new System.EventHandler(this.Kyd_textTextChanged);
			// 
			// Kyd_bar
			// 
			this.Kyd_bar.Location = new System.Drawing.Point(323, 77);
			this.Kyd_bar.Maximum = 500;
			this.Kyd_bar.Name = "Kyd_bar";
			this.Kyd_bar.Size = new System.Drawing.Size(142, 23);
			this.Kyd_bar.TabIndex = 7;
			this.Kyd_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kyd_barScroll);
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(175, 28);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(142, 23);
			this.label13.TabIndex = 6;
			this.label13.Text = "Integral";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kyi_text
			// 
			this.Kyi_text.Location = new System.Drawing.Point(175, 54);
			this.Kyi_text.Name = "Kyi_text";
			this.Kyi_text.Size = new System.Drawing.Size(142, 20);
			this.Kyi_text.TabIndex = 5;
			this.Kyi_text.TextChanged += new System.EventHandler(this.Kyi_textTextChanged);
			// 
			// Kyi_bar
			// 
			this.Kyi_bar.Location = new System.Drawing.Point(175, 77);
			this.Kyi_bar.Maximum = 500;
			this.Kyi_bar.Name = "Kyi_bar";
			this.Kyi_bar.Size = new System.Drawing.Size(142, 23);
			this.Kyi_bar.TabIndex = 4;
			this.Kyi_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kyi_barScroll);
			// 
			// label14
			// 
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label14.Location = new System.Drawing.Point(0, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 3;
			this.label14.Text = "Yaw Parameters";
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(27, 28);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(142, 23);
			this.label15.TabIndex = 2;
			this.label15.Text = "Proportional";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kyp_text
			// 
			this.Kyp_text.Location = new System.Drawing.Point(27, 54);
			this.Kyp_text.Name = "Kyp_text";
			this.Kyp_text.Size = new System.Drawing.Size(142, 20);
			this.Kyp_text.TabIndex = 1;
			this.Kyp_text.TextChanged += new System.EventHandler(this.Kyp_textTextChanged);
			// 
			// Kyp_bar
			// 
			this.Kyp_bar.Location = new System.Drawing.Point(27, 77);
			this.Kyp_bar.Maximum = 500;
			this.Kyp_bar.Name = "Kyp_bar";
			this.Kyp_bar.Size = new System.Drawing.Size(142, 23);
			this.Kyp_bar.TabIndex = 0;
			this.Kyp_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kyp_barScroll);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.Kpd_text);
			this.panel1.Controls.Add(this.Kpd_bar);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.Kpi_text);
			this.panel1.Controls.Add(this.Kpi_bar);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.Kpp_text);
			this.panel1.Controls.Add(this.Kpp_bar);
			this.panel1.Location = new System.Drawing.Point(22, 183);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(628, 144);
			this.panel1.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(323, 28);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(142, 23);
			this.label7.TabIndex = 9;
			this.label7.Text = "Derivative";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kpd_text
			// 
			this.Kpd_text.Location = new System.Drawing.Point(323, 54);
			this.Kpd_text.Name = "Kpd_text";
			this.Kpd_text.Size = new System.Drawing.Size(142, 20);
			this.Kpd_text.TabIndex = 8;
			this.Kpd_text.TextChanged += new System.EventHandler(this.Kpd_textTextChanged);
			// 
			// Kpd_bar
			// 
			this.Kpd_bar.Location = new System.Drawing.Point(323, 77);
			this.Kpd_bar.Maximum = 500;
			this.Kpd_bar.Name = "Kpd_bar";
			this.Kpd_bar.Size = new System.Drawing.Size(142, 23);
			this.Kpd_bar.TabIndex = 7;
			this.Kpd_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kpd_barScroll);
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(175, 28);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(142, 23);
			this.label8.TabIndex = 6;
			this.label8.Text = "Integral";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kpi_text
			// 
			this.Kpi_text.Location = new System.Drawing.Point(175, 54);
			this.Kpi_text.Name = "Kpi_text";
			this.Kpi_text.Size = new System.Drawing.Size(142, 20);
			this.Kpi_text.TabIndex = 5;
			this.Kpi_text.TextChanged += new System.EventHandler(this.Kpi_textTextChanged);
			// 
			// Kpi_bar
			// 
			this.Kpi_bar.Location = new System.Drawing.Point(175, 77);
			this.Kpi_bar.Maximum = 500;
			this.Kpi_bar.Name = "Kpi_bar";
			this.Kpi_bar.Size = new System.Drawing.Size(142, 23);
			this.Kpi_bar.TabIndex = 4;
			this.Kpi_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kpi_barScroll);
			// 
			// label9
			// 
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label9.Location = new System.Drawing.Point(0, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 3;
			this.label9.Text = "Pitch Parameters";
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(27, 28);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(142, 23);
			this.label10.TabIndex = 2;
			this.label10.Text = "Proportional";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kpp_text
			// 
			this.Kpp_text.Location = new System.Drawing.Point(27, 54);
			this.Kpp_text.Name = "Kpp_text";
			this.Kpp_text.Size = new System.Drawing.Size(142, 20);
			this.Kpp_text.TabIndex = 1;
			this.Kpp_text.TextChanged += new System.EventHandler(this.Kpp_textTextChanged);
			// 
			// Kpp_bar
			// 
			this.Kpp_bar.Location = new System.Drawing.Point(27, 77);
			this.Kpp_bar.Maximum = 500;
			this.Kpp_bar.Name = "Kpp_bar";
			this.Kpp_bar.Size = new System.Drawing.Size(142, 23);
			this.Kpp_bar.TabIndex = 0;
			this.Kpp_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kpp_barScroll);
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.Krd_text);
			this.panel4.Controls.Add(this.Krd_bar);
			this.panel4.Controls.Add(this.label3);
			this.panel4.Controls.Add(this.Kri_text);
			this.panel4.Controls.Add(this.Kri_bar);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Controls.Add(this.label1);
			this.panel4.Controls.Add(this.Krp_text);
			this.panel4.Controls.Add(this.Krp_bar);
			this.panel4.Location = new System.Drawing.Point(22, 33);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(628, 144);
			this.panel4.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(323, 28);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(142, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Derivative";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Krd_text
			// 
			this.Krd_text.Location = new System.Drawing.Point(323, 54);
			this.Krd_text.Name = "Krd_text";
			this.Krd_text.Size = new System.Drawing.Size(142, 20);
			this.Krd_text.TabIndex = 8;
			this.Krd_text.TextChanged += new System.EventHandler(this.Krd_textTextChanged);
			// 
			// Krd_bar
			// 
			this.Krd_bar.Location = new System.Drawing.Point(323, 77);
			this.Krd_bar.Maximum = 500;
			this.Krd_bar.Name = "Krd_bar";
			this.Krd_bar.Size = new System.Drawing.Size(142, 23);
			this.Krd_bar.TabIndex = 7;
			this.Krd_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Krd_barScroll);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(175, 28);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(142, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Integral";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Kri_text
			// 
			this.Kri_text.Location = new System.Drawing.Point(175, 54);
			this.Kri_text.Name = "Kri_text";
			this.Kri_text.Size = new System.Drawing.Size(142, 20);
			this.Kri_text.TabIndex = 5;
			this.Kri_text.TextChanged += new System.EventHandler(this.Kri_textTextChanged);
			// 
			// Kri_bar
			// 
			this.Kri_bar.Location = new System.Drawing.Point(175, 77);
			this.Kri_bar.Maximum = 500;
			this.Kri_bar.Name = "Kri_bar";
			this.Kri_bar.Size = new System.Drawing.Size(142, 23);
			this.Kri_bar.TabIndex = 4;
			this.Kri_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Kri_barScroll);
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 3;
			this.label2.Text = "Roll Parameters";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 28);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 23);
			this.label1.TabIndex = 2;
			this.label1.Text = "Proportional";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// Krp_text
			// 
			this.Krp_text.Location = new System.Drawing.Point(27, 54);
			this.Krp_text.Name = "Krp_text";
			this.Krp_text.Size = new System.Drawing.Size(142, 20);
			this.Krp_text.TabIndex = 1;
			this.Krp_text.TextChanged += new System.EventHandler(this.Krp_textTextChanged);
			// 
			// Krp_bar
			// 
			this.Krp_bar.Location = new System.Drawing.Point(27, 77);
			this.Krp_bar.Maximum = 500;
			this.Krp_bar.Name = "Krp_bar";
			this.Krp_bar.Size = new System.Drawing.Size(142, 23);
			this.Krp_bar.TabIndex = 0;
			this.Krp_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.Krp_barScroll);
			// 
			// tabPosition
			// 
			this.tabPosition.Controls.Add(this.button_KP_sendall);
			this.tabPosition.Controls.Add(this.button_KP_load);
			this.tabPosition.Controls.Add(this.button_KP_save);
			this.tabPosition.Controls.Add(this.button_KP_reset);
			this.tabPosition.Controls.Add(this.panel7);
			this.tabPosition.Controls.Add(this.panel8);
			this.tabPosition.Controls.Add(this.panel9);
			this.tabPosition.Location = new System.Drawing.Point(4, 22);
			this.tabPosition.Name = "tabPosition";
			this.tabPosition.Padding = new System.Windows.Forms.Padding(3);
			this.tabPosition.Size = new System.Drawing.Size(752, 512);
			this.tabPosition.TabIndex = 7;
			this.tabPosition.Text = "Position Tuner";
			this.tabPosition.UseVisualStyleBackColor = true;
			// 
			// button_KP_sendall
			// 
			this.button_KP_sendall.Location = new System.Drawing.Point(660, 174);
			this.button_KP_sendall.Name = "button_KP_sendall";
			this.button_KP_sendall.Size = new System.Drawing.Size(89, 23);
			this.button_KP_sendall.TabIndex = 17;
			this.button_KP_sendall.Text = "Send All";
			this.button_KP_sendall.UseVisualStyleBackColor = true;
			this.button_KP_sendall.Click += new System.EventHandler(this.Button_KP_sendallClick);
			// 
			// button_KP_load
			// 
			this.button_KP_load.Location = new System.Drawing.Point(660, 145);
			this.button_KP_load.Name = "button_KP_load";
			this.button_KP_load.Size = new System.Drawing.Size(89, 23);
			this.button_KP_load.TabIndex = 16;
			this.button_KP_load.Text = "Load";
			this.button_KP_load.UseVisualStyleBackColor = true;
			this.button_KP_load.Click += new System.EventHandler(this.Button_KP_loadClick);
			// 
			// button_KP_save
			// 
			this.button_KP_save.Location = new System.Drawing.Point(660, 116);
			this.button_KP_save.Name = "button_KP_save";
			this.button_KP_save.Size = new System.Drawing.Size(89, 23);
			this.button_KP_save.TabIndex = 15;
			this.button_KP_save.Text = "Save";
			this.button_KP_save.UseVisualStyleBackColor = true;
			this.button_KP_save.Click += new System.EventHandler(this.Button_KP_saveClick);
			// 
			// button_KP_reset
			// 
			this.button_KP_reset.Location = new System.Drawing.Point(660, 87);
			this.button_KP_reset.Name = "button_KP_reset";
			this.button_KP_reset.Size = new System.Drawing.Size(89, 23);
			this.button_KP_reset.TabIndex = 14;
			this.button_KP_reset.Text = "Reset";
			this.button_KP_reset.UseVisualStyleBackColor = true;
			this.button_KP_reset.Click += new System.EventHandler(this.Button_KP_resetClick);
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.label49);
			this.panel7.Controls.Add(this.KdAlt_text);
			this.panel7.Controls.Add(this.KdAlt_bar);
			this.panel7.Controls.Add(this.label50);
			this.panel7.Controls.Add(this.KiAlt_text);
			this.panel7.Controls.Add(this.KiAlt_bar);
			this.panel7.Controls.Add(this.label51);
			this.panel7.Controls.Add(this.label52);
			this.panel7.Controls.Add(this.KpAlt_text);
			this.panel7.Controls.Add(this.KpAlt_bar);
			this.panel7.Location = new System.Drawing.Point(22, 333);
			this.panel7.Name = "panel7";
			this.panel7.Size = new System.Drawing.Size(628, 144);
			this.panel7.TabIndex = 13;
			// 
			// label49
			// 
			this.label49.Location = new System.Drawing.Point(323, 28);
			this.label49.Name = "label49";
			this.label49.Size = new System.Drawing.Size(142, 23);
			this.label49.TabIndex = 9;
			this.label49.Text = "Derivative";
			this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// KdAlt_text
			// 
			this.KdAlt_text.Location = new System.Drawing.Point(323, 54);
			this.KdAlt_text.Name = "KdAlt_text";
			this.KdAlt_text.Size = new System.Drawing.Size(142, 20);
			this.KdAlt_text.TabIndex = 8;
			this.KdAlt_text.TextChanged += new System.EventHandler(this.KdAlt_textTextChanged);
			// 
			// KdAlt_bar
			// 
			this.KdAlt_bar.Location = new System.Drawing.Point(323, 77);
			this.KdAlt_bar.Maximum = 500;
			this.KdAlt_bar.Name = "KdAlt_bar";
			this.KdAlt_bar.Size = new System.Drawing.Size(142, 23);
			this.KdAlt_bar.TabIndex = 7;
			this.KdAlt_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.KdAlt_barScroll);
			// 
			// label50
			// 
			this.label50.Location = new System.Drawing.Point(175, 28);
			this.label50.Name = "label50";
			this.label50.Size = new System.Drawing.Size(142, 23);
			this.label50.TabIndex = 6;
			this.label50.Text = "Integral";
			this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// KiAlt_text
			// 
			this.KiAlt_text.Location = new System.Drawing.Point(175, 54);
			this.KiAlt_text.Name = "KiAlt_text";
			this.KiAlt_text.Size = new System.Drawing.Size(142, 20);
			this.KiAlt_text.TabIndex = 5;
			this.KiAlt_text.TextChanged += new System.EventHandler(this.KiAlt_textTextChanged);
			// 
			// KiAlt_bar
			// 
			this.KiAlt_bar.Location = new System.Drawing.Point(175, 77);
			this.KiAlt_bar.Maximum = 500;
			this.KiAlt_bar.Name = "KiAlt_bar";
			this.KiAlt_bar.Size = new System.Drawing.Size(142, 23);
			this.KiAlt_bar.TabIndex = 4;
			this.KiAlt_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.KiAlt_barScroll);
			// 
			// label51
			// 
			this.label51.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label51.Location = new System.Drawing.Point(0, 0);
			this.label51.Name = "label51";
			this.label51.Size = new System.Drawing.Size(132, 23);
			this.label51.TabIndex = 3;
			this.label51.Text = "Altitude Parameters";
			// 
			// label52
			// 
			this.label52.Location = new System.Drawing.Point(27, 28);
			this.label52.Name = "label52";
			this.label52.Size = new System.Drawing.Size(142, 23);
			this.label52.TabIndex = 2;
			this.label52.Text = "Proportional";
			this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// KpAlt_text
			// 
			this.KpAlt_text.Location = new System.Drawing.Point(27, 54);
			this.KpAlt_text.Name = "KpAlt_text";
			this.KpAlt_text.Size = new System.Drawing.Size(142, 20);
			this.KpAlt_text.TabIndex = 1;
			this.KpAlt_text.TextChanged += new System.EventHandler(this.KpAlt_textTextChanged);
			// 
			// KpAlt_bar
			// 
			this.KpAlt_bar.Location = new System.Drawing.Point(27, 77);
			this.KpAlt_bar.Maximum = 500;
			this.KpAlt_bar.Name = "KpAlt_bar";
			this.KpAlt_bar.Size = new System.Drawing.Size(142, 23);
			this.KpAlt_bar.TabIndex = 0;
			this.KpAlt_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.KpAlt_barScroll);
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.label53);
			this.panel8.Controls.Add(this.KdLat_text);
			this.panel8.Controls.Add(this.KdLat_bar);
			this.panel8.Controls.Add(this.label54);
			this.panel8.Controls.Add(this.KiLat_text);
			this.panel8.Controls.Add(this.KiLat_bar);
			this.panel8.Controls.Add(this.label55);
			this.panel8.Controls.Add(this.label56);
			this.panel8.Controls.Add(this.KpLat_text);
			this.panel8.Controls.Add(this.KpLat_bar);
			this.panel8.Location = new System.Drawing.Point(22, 183);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(628, 144);
			this.panel8.TabIndex = 13;
			// 
			// label53
			// 
			this.label53.Location = new System.Drawing.Point(323, 28);
			this.label53.Name = "label53";
			this.label53.Size = new System.Drawing.Size(142, 23);
			this.label53.TabIndex = 9;
			this.label53.Text = "Derivative";
			this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// KdLat_text
			// 
			this.KdLat_text.Location = new System.Drawing.Point(323, 54);
			this.KdLat_text.Name = "KdLat_text";
			this.KdLat_text.Size = new System.Drawing.Size(142, 20);
			this.KdLat_text.TabIndex = 8;
			this.KdLat_text.TextChanged += new System.EventHandler(this.KdLat_textTextChanged);
			// 
			// KdLat_bar
			// 
			this.KdLat_bar.Location = new System.Drawing.Point(323, 77);
			this.KdLat_bar.Maximum = 500;
			this.KdLat_bar.Name = "KdLat_bar";
			this.KdLat_bar.Size = new System.Drawing.Size(142, 23);
			this.KdLat_bar.TabIndex = 7;
			this.KdLat_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.KdLat_barScroll);
			// 
			// label54
			// 
			this.label54.Location = new System.Drawing.Point(175, 28);
			this.label54.Name = "label54";
			this.label54.Size = new System.Drawing.Size(142, 23);
			this.label54.TabIndex = 6;
			this.label54.Text = "Integral";
			this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// KiLat_text
			// 
			this.KiLat_text.Location = new System.Drawing.Point(175, 54);
			this.KiLat_text.Name = "KiLat_text";
			this.KiLat_text.Size = new System.Drawing.Size(142, 20);
			this.KiLat_text.TabIndex = 5;
			this.KiLat_text.TextChanged += new System.EventHandler(this.KiLat_textTextChanged);
			// 
			// KiLat_bar
			// 
			this.KiLat_bar.Location = new System.Drawing.Point(175, 77);
			this.KiLat_bar.Maximum = 500;
			this.KiLat_bar.Name = "KiLat_bar";
			this.KiLat_bar.Size = new System.Drawing.Size(142, 23);
			this.KiLat_bar.TabIndex = 4;
			this.KiLat_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.KiLat_barScroll);
			// 
			// label55
			// 
			this.label55.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label55.Location = new System.Drawing.Point(0, 0);
			this.label55.Name = "label55";
			this.label55.Size = new System.Drawing.Size(132, 23);
			this.label55.TabIndex = 3;
			this.label55.Text = "Latitude Parameters";
			// 
			// label56
			// 
			this.label56.Location = new System.Drawing.Point(27, 28);
			this.label56.Name = "label56";
			this.label56.Size = new System.Drawing.Size(142, 23);
			this.label56.TabIndex = 2;
			this.label56.Text = "Proportional";
			this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// KpLat_text
			// 
			this.KpLat_text.Location = new System.Drawing.Point(27, 54);
			this.KpLat_text.Name = "KpLat_text";
			this.KpLat_text.Size = new System.Drawing.Size(142, 20);
			this.KpLat_text.TabIndex = 1;
			this.KpLat_text.TextChanged += new System.EventHandler(this.KpLat_textTextChanged);
			// 
			// KpLat_bar
			// 
			this.KpLat_bar.Location = new System.Drawing.Point(27, 77);
			this.KpLat_bar.Maximum = 500;
			this.KpLat_bar.Name = "KpLat_bar";
			this.KpLat_bar.Size = new System.Drawing.Size(142, 23);
			this.KpLat_bar.TabIndex = 0;
			this.KpLat_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.KpLat_barScroll);
			// 
			// panel9
			// 
			this.panel9.Controls.Add(this.label57);
			this.panel9.Controls.Add(this.KdLon_text);
			this.panel9.Controls.Add(this.KdLon_bar);
			this.panel9.Controls.Add(this.label58);
			this.panel9.Controls.Add(this.KiLon_text);
			this.panel9.Controls.Add(this.KiLon_bar);
			this.panel9.Controls.Add(this.label59);
			this.panel9.Controls.Add(this.label60);
			this.panel9.Controls.Add(this.KpLon_text);
			this.panel9.Controls.Add(this.KpLon_bar);
			this.panel9.Location = new System.Drawing.Point(22, 33);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(628, 144);
			this.panel9.TabIndex = 2;
			// 
			// label57
			// 
			this.label57.Location = new System.Drawing.Point(323, 28);
			this.label57.Name = "label57";
			this.label57.Size = new System.Drawing.Size(142, 23);
			this.label57.TabIndex = 9;
			this.label57.Text = "Derivative";
			this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// KdLon_text
			// 
			this.KdLon_text.Location = new System.Drawing.Point(323, 54);
			this.KdLon_text.Name = "KdLon_text";
			this.KdLon_text.Size = new System.Drawing.Size(142, 20);
			this.KdLon_text.TabIndex = 8;
			this.KdLon_text.TextChanged += new System.EventHandler(this.KdLon_textTextChanged);
			// 
			// KdLon_bar
			// 
			this.KdLon_bar.Location = new System.Drawing.Point(323, 77);
			this.KdLon_bar.Maximum = 500;
			this.KdLon_bar.Name = "KdLon_bar";
			this.KdLon_bar.Size = new System.Drawing.Size(142, 23);
			this.KdLon_bar.TabIndex = 7;
			this.KdLon_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.KdLon_barScroll);
			// 
			// label58
			// 
			this.label58.Location = new System.Drawing.Point(175, 28);
			this.label58.Name = "label58";
			this.label58.Size = new System.Drawing.Size(142, 23);
			this.label58.TabIndex = 6;
			this.label58.Text = "Integral";
			this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// KiLon_text
			// 
			this.KiLon_text.Location = new System.Drawing.Point(175, 54);
			this.KiLon_text.Name = "KiLon_text";
			this.KiLon_text.Size = new System.Drawing.Size(142, 20);
			this.KiLon_text.TabIndex = 5;
			this.KiLon_text.TextChanged += new System.EventHandler(this.KiLon_textTextChanged);
			// 
			// KiLon_bar
			// 
			this.KiLon_bar.Location = new System.Drawing.Point(175, 77);
			this.KiLon_bar.Maximum = 500;
			this.KiLon_bar.Name = "KiLon_bar";
			this.KiLon_bar.Size = new System.Drawing.Size(142, 23);
			this.KiLon_bar.TabIndex = 4;
			this.KiLon_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.KiLon_barScroll);
			// 
			// label59
			// 
			this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label59.Location = new System.Drawing.Point(0, 0);
			this.label59.Name = "label59";
			this.label59.Size = new System.Drawing.Size(132, 23);
			this.label59.TabIndex = 3;
			this.label59.Text = "Longitude Parameters";
			// 
			// label60
			// 
			this.label60.Location = new System.Drawing.Point(27, 28);
			this.label60.Name = "label60";
			this.label60.Size = new System.Drawing.Size(142, 23);
			this.label60.TabIndex = 2;
			this.label60.Text = "Proportional";
			this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// KpLon_text
			// 
			this.KpLon_text.Location = new System.Drawing.Point(27, 54);
			this.KpLon_text.Name = "KpLon_text";
			this.KpLon_text.Size = new System.Drawing.Size(142, 20);
			this.KpLon_text.TabIndex = 1;
			this.KpLon_text.TextChanged += new System.EventHandler(this.KpLon_textTextChanged);
			// 
			// KpLon_bar
			// 
			this.KpLon_bar.Location = new System.Drawing.Point(27, 77);
			this.KpLon_bar.Maximum = 500;
			this.KpLon_bar.Name = "KpLon_bar";
			this.KpLon_bar.Size = new System.Drawing.Size(142, 23);
			this.KpLon_bar.TabIndex = 0;
			this.KpLon_bar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.KpLon_barScroll);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 562);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Space Hopper Ground Station";
			this.tabControl1.ResumeLayout(false);
			this.tabCOM.ResumeLayout(false);
			this.tabCOM.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.throttle_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.yawT_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pitchT_bar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.rollT_bar)).EndInit();
			this.tabRate.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.tabAttitude.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.tabPosition.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.panel9.ResumeLayout(false);
			this.panel9.PerformLayout();
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button button_KA_sendAll;
		private System.Windows.Forms.Button button_KA_load;
		private System.Windows.Forms.Button button_KA_save;
		private System.Windows.Forms.Button button_KA_reset;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox Kyd_text;
		private System.Windows.Forms.HScrollBar Kyd_bar;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox Kyi_text;
		private System.Windows.Forms.HScrollBar Kyi_bar;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox Kyp_text;
		private System.Windows.Forms.HScrollBar Kyp_bar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Kpd_text;
		private System.Windows.Forms.HScrollBar Kpd_bar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox Kpi_text;
		private System.Windows.Forms.HScrollBar Kpi_bar;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox Kpp_text;
		private System.Windows.Forms.HScrollBar Kpp_bar;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox Krp_text;
		private System.Windows.Forms.HScrollBar Krp_bar;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Krd_text;
		private System.Windows.Forms.HScrollBar Krd_bar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Kri_text;
		private System.Windows.Forms.HScrollBar Kri_bar;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabCOM;
		private System.Windows.Forms.TabPage tabAttitude;
		private System.Windows.Forms.TextBox throttle_text;
		private System.Windows.Forms.TextBox pitchT_text;
		private System.Windows.Forms.TextBox yawT_text;
		private System.Windows.Forms.TextBox rollT_text;
		private System.Windows.Forms.TrackBar throttle_bar;
		private System.Windows.Forms.TrackBar yawT_bar;
		private System.Windows.Forms.TrackBar pitchT_bar;
		private System.Windows.Forms.TrackBar rollT_bar;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox DL_Yaw;
		private System.Windows.Forms.TextBox DL_Pitch;
		private System.Windows.Forms.TextBox DL_Roll;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox DL_Yaw_d;
		private System.Windows.Forms.TextBox DL_Pitch_d;
		private System.Windows.Forms.TextBox DL_Roll_d;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox DL_Time;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TextBox DL_YawSignal;
		private System.Windows.Forms.TextBox DL_PitchSignal;
		private System.Windows.Forms.TextBox DL_RollSignal;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox DL_Motor3;
		private System.Windows.Forms.TextBox DL_Motor2;
		private System.Windows.Forms.TextBox DL_Motor1;
		private System.Windows.Forms.TextBox DL_Motor0;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.TextBox heightT_text;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.TextBox latitudeT_text;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.TextBox longitudeT_text;
		private System.Windows.Forms.Button button_emergency;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.TextBox DL_height;
		private System.Windows.Forms.TextBox DL_latitude;
		private System.Windows.Forms.TextBox DL_longitude;
		private System.Windows.Forms.Label label36;
		private System.Windows.Forms.TabPage tabRate;
		private System.Windows.Forms.Button button_KR_sendall;
		private System.Windows.Forms.Button button_KR_load;
		private System.Windows.Forms.Button button_KR_save;
		private System.Windows.Forms.Button button_KR_reset;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.Label label41;
		private System.Windows.Forms.TextBox Kdyd_text;
		private System.Windows.Forms.HScrollBar Kdyd_bar;
		private System.Windows.Forms.Label label42;
		private System.Windows.Forms.TextBox Kiyd_text;
		private System.Windows.Forms.HScrollBar Kiyd_bar;
		private System.Windows.Forms.Label label43;
		private System.Windows.Forms.Label label44;
		private System.Windows.Forms.TextBox Kpyd_text;
		private System.Windows.Forms.HScrollBar Kpyd_bar;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Label label45;
		private System.Windows.Forms.TextBox Kdpd_text;
		private System.Windows.Forms.HScrollBar Kdpd_bar;
		private System.Windows.Forms.Label label46;
		private System.Windows.Forms.TextBox Kipd_text;
		private System.Windows.Forms.HScrollBar Kipd_bar;
		private System.Windows.Forms.Label label47;
		private System.Windows.Forms.Label label48;
		private System.Windows.Forms.TextBox Kppd_text;
		private System.Windows.Forms.HScrollBar Kppd_bar;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label37;
		private System.Windows.Forms.TextBox Kdrd_text;
		private System.Windows.Forms.HScrollBar Kdrd_bar;
		private System.Windows.Forms.Label label38;
		private System.Windows.Forms.TextBox Kird_text;
		private System.Windows.Forms.HScrollBar Kird_bar;
		private System.Windows.Forms.Label label39;
		private System.Windows.Forms.Label label40;
		private System.Windows.Forms.TextBox Kprd_text;
		private System.Windows.Forms.HScrollBar Kprd_bar;
		private System.Windows.Forms.TabPage tabPosition;
		private System.Windows.Forms.Button button_KP_sendall;
		private System.Windows.Forms.Button button_KP_load;
		private System.Windows.Forms.Button button_KP_save;
		private System.Windows.Forms.Button button_KP_reset;
		private System.Windows.Forms.Panel panel7;
		private System.Windows.Forms.Label label49;
		private System.Windows.Forms.TextBox KdAlt_text;
		private System.Windows.Forms.HScrollBar KdAlt_bar;
		private System.Windows.Forms.Label label50;
		private System.Windows.Forms.TextBox KiAlt_text;
		private System.Windows.Forms.HScrollBar KiAlt_bar;
		private System.Windows.Forms.Label label51;
		private System.Windows.Forms.Label label52;
		private System.Windows.Forms.TextBox KpAlt_text;
		private System.Windows.Forms.HScrollBar KpAlt_bar;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Label label53;
		private System.Windows.Forms.TextBox KdLat_text;
		private System.Windows.Forms.HScrollBar KdLat_bar;
		private System.Windows.Forms.Label label54;
		private System.Windows.Forms.TextBox KiLat_text;
		private System.Windows.Forms.HScrollBar KiLat_bar;
		private System.Windows.Forms.Label label55;
		private System.Windows.Forms.Label label56;
		private System.Windows.Forms.TextBox KpLat_text;
		private System.Windows.Forms.HScrollBar KpLat_bar;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label label57;
		private System.Windows.Forms.TextBox KdLon_text;
		private System.Windows.Forms.HScrollBar KdLon_bar;
		private System.Windows.Forms.Label label58;
		private System.Windows.Forms.TextBox KiLon_text;
		private System.Windows.Forms.HScrollBar KiLon_bar;
		private System.Windows.Forms.Label label59;
		private System.Windows.Forms.Label label60;
		private System.Windows.Forms.TextBox KpLon_text;
		private System.Windows.Forms.HScrollBar KpLon_bar;
		private System.Windows.Forms.Button button_uplink;
		private System.Windows.Forms.ProgressBar sync_bar;
		private System.Windows.Forms.CheckBox checkBox_arm;
		private System.Windows.Forms.CheckBox checkBox_override;
	}
}
