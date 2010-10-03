namespace WiimoteTest
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.clbButtons = new System.Windows.Forms.CheckedListBox();
            this.lblAccel = new System.Windows.Forms.Label();
            this.chkLED4 = new System.Windows.Forms.CheckBox();
            this.chkLED3 = new System.Windows.Forms.CheckBox();
            this.chkLED2 = new System.Windows.Forms.CheckBox();
            this.chkLED1 = new System.Windows.Forms.CheckBox();
            this.chkRumble = new System.Windows.Forms.CheckBox();
            this.pbBattery = new System.Windows.Forms.ProgressBar();
            this.lblIR1 = new System.Windows.Forms.Label();
            this.lblIR2 = new System.Windows.Forms.Label();
            this.chkFound1 = new System.Windows.Forms.CheckBox();
            this.chkFound2 = new System.Windows.Forms.CheckBox();
            this.lblBattery = new System.Windows.Forms.Label();
            this.pbIR = new System.Windows.Forms.PictureBox();
            this.chkExtension = new System.Windows.Forms.CheckBox();
            this.lblChuk = new System.Windows.Forms.Label();
            this.lblChukJoy = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkZ = new System.Windows.Forms.CheckBox();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lblIR3Raw = new System.Windows.Forms.Label();
            this.lblIR1Raw = new System.Windows.Forms.Label();
            this.lblIR4Raw = new System.Windows.Forms.Label();
            this.lblIR2Raw = new System.Windows.Forms.Label();
            this.lblIR3 = new System.Windows.Forms.Label();
            this.lblIR4 = new System.Windows.Forms.Label();
            this.chkFound3 = new System.Windows.Forms.CheckBox();
            this.chkFound4 = new System.Windows.Forms.CheckBox();
            this.clbCCButtons = new System.Windows.Forms.CheckedListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTriggerR = new System.Windows.Forms.Label();
            this.lblTriggerL = new System.Windows.Forms.Label();
            this.lblCCJoy2 = new System.Windows.Forms.Label();
            this.lblCCJoy1 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblGuitarWhammy = new System.Windows.Forms.Label();
            this.lblGuitarJoy = new System.Windows.Forms.Label();
            this.clbGuitarButtons = new System.Windows.Forms.CheckedListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbIR)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // clbButtons
            // 
            this.clbButtons.FormattingEnabled = true;
            this.clbButtons.Items.AddRange(new object[] {
            "A",
            "B",
            "-",
            "Home",
            "+",
            "1",
            "2",
            "Up",
            "Down",
            "Left",
            "Right"});
            this.clbButtons.Location = new System.Drawing.Point(11, 20);
            this.clbButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbButtons.Name = "clbButtons";
            this.clbButtons.Size = new System.Drawing.Size(73, 225);
            this.clbButtons.TabIndex = 1;
            // 
            // lblAccel
            // 
            this.lblAccel.Location = new System.Drawing.Point(11, 25);
            this.lblAccel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAccel.Name = "lblAccel";
            this.lblAccel.Size = new System.Drawing.Size(117, 59);
            this.lblAccel.TabIndex = 2;
            this.lblAccel.Text = "Accel Values";
            // 
            // chkLED4
            // 
            this.chkLED4.AutoSize = true;
            this.chkLED4.Location = new System.Drawing.Point(11, 94);
            this.chkLED4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLED4.Name = "chkLED4";
            this.chkLED4.Size = new System.Drawing.Size(87, 26);
            this.chkLED4.TabIndex = 3;
            this.chkLED4.Text = "LED4";
            this.chkLED4.UseVisualStyleBackColor = true;
            this.chkLED4.CheckedChanged += new System.EventHandler(this.chkLED1_CheckedChanged);
            // 
            // chkLED3
            // 
            this.chkLED3.AutoSize = true;
            this.chkLED3.Location = new System.Drawing.Point(11, 69);
            this.chkLED3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLED3.Name = "chkLED3";
            this.chkLED3.Size = new System.Drawing.Size(87, 26);
            this.chkLED3.TabIndex = 3;
            this.chkLED3.Text = "LED3";
            this.chkLED3.UseVisualStyleBackColor = true;
            this.chkLED3.CheckedChanged += new System.EventHandler(this.chkLED1_CheckedChanged);
            // 
            // chkLED2
            // 
            this.chkLED2.AutoSize = true;
            this.chkLED2.Location = new System.Drawing.Point(11, 44);
            this.chkLED2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLED2.Name = "chkLED2";
            this.chkLED2.Size = new System.Drawing.Size(87, 26);
            this.chkLED2.TabIndex = 3;
            this.chkLED2.Text = "LED2";
            this.chkLED2.UseVisualStyleBackColor = true;
            this.chkLED2.CheckedChanged += new System.EventHandler(this.chkLED1_CheckedChanged);
            // 
            // chkLED1
            // 
            this.chkLED1.AutoSize = true;
            this.chkLED1.Location = new System.Drawing.Point(11, 20);
            this.chkLED1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkLED1.Name = "chkLED1";
            this.chkLED1.Size = new System.Drawing.Size(87, 26);
            this.chkLED1.TabIndex = 3;
            this.chkLED1.Text = "LED1";
            this.chkLED1.UseVisualStyleBackColor = true;
            this.chkLED1.CheckedChanged += new System.EventHandler(this.chkLED1_CheckedChanged);
            // 
            // chkRumble
            // 
            this.chkRumble.AutoSize = true;
            this.chkRumble.Location = new System.Drawing.Point(11, 118);
            this.chkRumble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkRumble.Name = "chkRumble";
            this.chkRumble.Size = new System.Drawing.Size(104, 26);
            this.chkRumble.TabIndex = 4;
            this.chkRumble.Text = "Rumble";
            this.chkRumble.UseVisualStyleBackColor = true;
            this.chkRumble.CheckedChanged += new System.EventHandler(this.chkRumble_CheckedChanged);
            // 
            // pbBattery
            // 
            this.pbBattery.Location = new System.Drawing.Point(11, 25);
            this.pbBattery.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbBattery.Maximum = 200;
            this.pbBattery.Name = "pbBattery";
            this.pbBattery.Size = new System.Drawing.Size(133, 28);
            this.pbBattery.Step = 1;
            this.pbBattery.TabIndex = 6;
            // 
            // lblIR1
            // 
            this.lblIR1.AutoSize = true;
            this.lblIR1.Location = new System.Drawing.Point(11, 20);
            this.lblIR1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIR1.Name = "lblIR1";
            this.lblIR1.Size = new System.Drawing.Size(29, 17);
            this.lblIR1.TabIndex = 7;
            this.lblIR1.Text = "IR1";
            // 
            // lblIR2
            // 
            this.lblIR2.AutoSize = true;
            this.lblIR2.Location = new System.Drawing.Point(11, 39);
            this.lblIR2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIR2.Name = "lblIR2";
            this.lblIR2.Size = new System.Drawing.Size(29, 17);
            this.lblIR2.TabIndex = 7;
            this.lblIR2.Text = "IR2";
            // 
            // chkFound1
            // 
            this.chkFound1.AutoSize = true;
            this.chkFound1.Location = new System.Drawing.Point(11, 182);
            this.chkFound1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFound1.Name = "chkFound1";
            this.chkFound1.Size = new System.Drawing.Size(73, 26);
            this.chkFound1.TabIndex = 8;
            this.chkFound1.Text = "IR 1";
            this.chkFound1.UseVisualStyleBackColor = true;
            // 
            // chkFound2
            // 
            this.chkFound2.AutoSize = true;
            this.chkFound2.Location = new System.Drawing.Point(11, 202);
            this.chkFound2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFound2.Name = "chkFound2";
            this.chkFound2.Size = new System.Drawing.Size(73, 26);
            this.chkFound2.TabIndex = 8;
            this.chkFound2.Text = "IR 2";
            this.chkFound2.UseVisualStyleBackColor = true;
            // 
            // lblBattery
            // 
            this.lblBattery.AutoSize = true;
            this.lblBattery.Location = new System.Drawing.Point(149, 30);
            this.lblBattery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBattery.Name = "lblBattery";
            this.lblBattery.Size = new System.Drawing.Size(46, 17);
            this.lblBattery.TabIndex = 9;
            this.lblBattery.Text = "label1";
            // 
            // pbIR
            // 
            this.pbIR.Location = new System.Drawing.Point(11, 310);
            this.pbIR.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pbIR.Name = "pbIR";
            this.pbIR.Size = new System.Drawing.Size(341, 236);
            this.pbIR.TabIndex = 10;
            this.pbIR.TabStop = false;
            // 
            // chkExtension
            // 
            this.chkExtension.AutoSize = true;
            this.chkExtension.Location = new System.Drawing.Point(11, 281);
            this.chkExtension.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkExtension.Name = "chkExtension";
            this.chkExtension.Size = new System.Drawing.Size(64, 21);
            this.chkExtension.TabIndex = 12;
            this.chkExtension.Text = "None";
            this.chkExtension.UseVisualStyleBackColor = true;
            // 
            // lblChuk
            // 
            this.lblChuk.Location = new System.Drawing.Point(11, 25);
            this.lblChuk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChuk.Name = "lblChuk";
            this.lblChuk.Size = new System.Drawing.Size(123, 49);
            this.lblChuk.TabIndex = 13;
            this.lblChuk.Text = "Accel Values";
            // 
            // lblChukJoy
            // 
            this.lblChukJoy.Location = new System.Drawing.Point(11, 79);
            this.lblChukJoy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblChukJoy.Name = "lblChukJoy";
            this.lblChukJoy.Size = new System.Drawing.Size(123, 34);
            this.lblChukJoy.TabIndex = 16;
            this.lblChukJoy.Text = "Joystick Values";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAccel);
            this.groupBox1.Location = new System.Drawing.Point(107, 5);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(139, 89);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Wiimote Accel";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkZ);
            this.groupBox2.Controls.Add(this.chkC);
            this.groupBox2.Controls.Add(this.lblChuk);
            this.groupBox2.Controls.Add(this.lblChukJoy);
            this.groupBox2.Location = new System.Drawing.Point(107, 98);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(139, 167);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nunchuk";
            // 
            // chkZ
            // 
            this.chkZ.AutoSize = true;
            this.chkZ.Location = new System.Drawing.Point(11, 138);
            this.chkZ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkZ.Name = "chkZ";
            this.chkZ.Size = new System.Drawing.Size(52, 26);
            this.chkZ.TabIndex = 17;
            this.chkZ.Text = "Z";
            this.chkZ.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(11, 113);
            this.chkC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(52, 26);
            this.chkC.TabIndex = 17;
            this.chkC.Text = "C";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkLED2);
            this.groupBox3.Controls.Add(this.chkLED4);
            this.groupBox3.Controls.Add(this.chkLED3);
            this.groupBox3.Controls.Add(this.chkLED1);
            this.groupBox3.Controls.Add(this.chkRumble);
            this.groupBox3.Location = new System.Drawing.Point(357, 310);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(96, 148);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outputs";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pbBattery);
            this.groupBox4.Controls.Add(this.lblBattery);
            this.groupBox4.Location = new System.Drawing.Point(251, 236);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox4.Size = new System.Drawing.Size(208, 64);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Battery";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.lblIR3Raw);
            this.groupBox5.Controls.Add(this.lblIR1Raw);
            this.groupBox5.Controls.Add(this.lblIR4Raw);
            this.groupBox5.Controls.Add(this.lblIR2Raw);
            this.groupBox5.Controls.Add(this.lblIR3);
            this.groupBox5.Controls.Add(this.lblIR1);
            this.groupBox5.Controls.Add(this.lblIR4);
            this.groupBox5.Controls.Add(this.lblIR2);
            this.groupBox5.Controls.Add(this.chkFound3);
            this.groupBox5.Controls.Add(this.chkFound4);
            this.groupBox5.Controls.Add(this.chkFound1);
            this.groupBox5.Controls.Add(this.chkFound2);
            this.groupBox5.Location = new System.Drawing.Point(251, 5);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox5.Size = new System.Drawing.Size(208, 231);
            this.groupBox5.TabIndex = 22;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "IR";
            // 
            // lblIR3Raw
            // 
            this.lblIR3Raw.AutoSize = true;
            this.lblIR3Raw.Location = new System.Drawing.Point(11, 138);
            this.lblIR3Raw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIR3Raw.Name = "lblIR3Raw";
            this.lblIR3Raw.Size = new System.Drawing.Size(56, 17);
            this.lblIR3Raw.TabIndex = 10;
            this.lblIR3Raw.Text = "IR3Raw";
            // 
            // lblIR1Raw
            // 
            this.lblIR1Raw.AutoSize = true;
            this.lblIR1Raw.Location = new System.Drawing.Point(11, 98);
            this.lblIR1Raw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIR1Raw.Name = "lblIR1Raw";
            this.lblIR1Raw.Size = new System.Drawing.Size(56, 17);
            this.lblIR1Raw.TabIndex = 10;
            this.lblIR1Raw.Text = "IR1Raw";
            // 
            // lblIR4Raw
            // 
            this.lblIR4Raw.AutoSize = true;
            this.lblIR4Raw.Location = new System.Drawing.Point(11, 158);
            this.lblIR4Raw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIR4Raw.Name = "lblIR4Raw";
            this.lblIR4Raw.Size = new System.Drawing.Size(56, 17);
            this.lblIR4Raw.TabIndex = 9;
            this.lblIR4Raw.Text = "IR4Raw";
            // 
            // lblIR2Raw
            // 
            this.lblIR2Raw.AutoSize = true;
            this.lblIR2Raw.Location = new System.Drawing.Point(11, 118);
            this.lblIR2Raw.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIR2Raw.Name = "lblIR2Raw";
            this.lblIR2Raw.Size = new System.Drawing.Size(56, 17);
            this.lblIR2Raw.TabIndex = 9;
            this.lblIR2Raw.Text = "IR2Raw";
            // 
            // lblIR3
            // 
            this.lblIR3.AutoSize = true;
            this.lblIR3.Location = new System.Drawing.Point(11, 59);
            this.lblIR3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIR3.Name = "lblIR3";
            this.lblIR3.Size = new System.Drawing.Size(29, 17);
            this.lblIR3.TabIndex = 7;
            this.lblIR3.Text = "IR3";
            // 
            // lblIR4
            // 
            this.lblIR4.AutoSize = true;
            this.lblIR4.Location = new System.Drawing.Point(11, 79);
            this.lblIR4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIR4.Name = "lblIR4";
            this.lblIR4.Size = new System.Drawing.Size(29, 17);
            this.lblIR4.TabIndex = 7;
            this.lblIR4.Text = "IR4";
            // 
            // chkFound3
            // 
            this.chkFound3.AutoSize = true;
            this.chkFound3.Location = new System.Drawing.Point(80, 182);
            this.chkFound3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFound3.Name = "chkFound3";
            this.chkFound3.Size = new System.Drawing.Size(73, 26);
            this.chkFound3.TabIndex = 8;
            this.chkFound3.Text = "IR 3";
            this.chkFound3.UseVisualStyleBackColor = true;
            // 
            // chkFound4
            // 
            this.chkFound4.AutoSize = true;
            this.chkFound4.Location = new System.Drawing.Point(80, 202);
            this.chkFound4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFound4.Name = "chkFound4";
            this.chkFound4.Size = new System.Drawing.Size(73, 26);
            this.chkFound4.TabIndex = 8;
            this.chkFound4.Text = "IR 4";
            this.chkFound4.UseVisualStyleBackColor = true;
            // 
            // clbCCButtons
            // 
            this.clbCCButtons.FormattingEnabled = true;
            this.clbCCButtons.Items.AddRange(new object[] {
            "A",
            "B",
            "X",
            "Y",
            "-",
            "Home",
            "+",
            "Up",
            "Down",
            "Left",
            "Right",
            "ZL",
            "ZR",
            "LTrigger",
            "RTrigger"});
            this.clbCCButtons.Location = new System.Drawing.Point(5, 20);
            this.clbCCButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbCCButtons.Name = "clbCCButtons";
            this.clbCCButtons.Size = new System.Drawing.Size(89, 293);
            this.clbCCButtons.TabIndex = 23;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTriggerR);
            this.groupBox6.Controls.Add(this.lblTriggerL);
            this.groupBox6.Controls.Add(this.lblCCJoy2);
            this.groupBox6.Controls.Add(this.lblCCJoy1);
            this.groupBox6.Controls.Add(this.clbCCButtons);
            this.groupBox6.Location = new System.Drawing.Point(464, 207);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox6.Size = new System.Drawing.Size(251, 330);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Classic Controller";
            // 
            // lblTriggerR
            // 
            this.lblTriggerR.AutoSize = true;
            this.lblTriggerR.Location = new System.Drawing.Point(101, 128);
            this.lblTriggerR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTriggerR.Name = "lblTriggerR";
            this.lblTriggerR.Size = new System.Drawing.Size(68, 17);
            this.lblTriggerR.TabIndex = 25;
            this.lblTriggerR.Text = "Trigger R";
            // 
            // lblTriggerL
            // 
            this.lblTriggerL.AutoSize = true;
            this.lblTriggerL.Location = new System.Drawing.Point(101, 108);
            this.lblTriggerL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTriggerL.Name = "lblTriggerL";
            this.lblTriggerL.Size = new System.Drawing.Size(66, 17);
            this.lblTriggerL.TabIndex = 24;
            this.lblTriggerL.Text = "Trigger L";
            // 
            // lblCCJoy2
            // 
            this.lblCCJoy2.Location = new System.Drawing.Point(101, 64);
            this.lblCCJoy2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCCJoy2.Name = "lblCCJoy2";
            this.lblCCJoy2.Size = new System.Drawing.Size(123, 39);
            this.lblCCJoy2.TabIndex = 24;
            this.lblCCJoy2.Text = "Right Joystick";
            // 
            // lblCCJoy1
            // 
            this.lblCCJoy1.Location = new System.Drawing.Point(101, 20);
            this.lblCCJoy1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCCJoy1.Name = "lblCCJoy1";
            this.lblCCJoy1.Size = new System.Drawing.Size(123, 39);
            this.lblCCJoy1.TabIndex = 24;
            this.lblCCJoy1.Text = "Left Joystick";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblGuitarWhammy);
            this.groupBox7.Controls.Add(this.lblGuitarJoy);
            this.groupBox7.Controls.Add(this.clbGuitarButtons);
            this.groupBox7.Location = new System.Drawing.Point(464, 5);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox7.Size = new System.Drawing.Size(251, 197);
            this.groupBox7.TabIndex = 26;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Guitar";
            // 
            // lblGuitarWhammy
            // 
            this.lblGuitarWhammy.AutoSize = true;
            this.lblGuitarWhammy.Location = new System.Drawing.Point(123, 64);
            this.lblGuitarWhammy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuitarWhammy.Name = "lblGuitarWhammy";
            this.lblGuitarWhammy.Size = new System.Drawing.Size(66, 17);
            this.lblGuitarWhammy.TabIndex = 24;
            this.lblGuitarWhammy.Text = "Whammy";
            // 
            // lblGuitarJoy
            // 
            this.lblGuitarJoy.Location = new System.Drawing.Point(123, 20);
            this.lblGuitarJoy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGuitarJoy.Name = "lblGuitarJoy";
            this.lblGuitarJoy.Size = new System.Drawing.Size(123, 39);
            this.lblGuitarJoy.TabIndex = 24;
            this.lblGuitarJoy.Text = "Joystick Values";
            // 
            // clbGuitarButtons
            // 
            this.clbGuitarButtons.FormattingEnabled = true;
            this.clbGuitarButtons.Items.AddRange(new object[] {
            "Green",
            "Red",
            "Yellow",
            "Blue",
            "Orange",
            "-",
            "+",
            "StrumUp",
            "StrumDown"});
            this.clbGuitarButtons.Location = new System.Drawing.Point(5, 20);
            this.clbGuitarButtons.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.clbGuitarButtons.Name = "clbGuitarButtons";
            this.clbGuitarButtons.Size = new System.Drawing.Size(105, 157);
            this.clbGuitarButtons.TabIndex = 23;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.clbButtons);
            this.groupBox8.Location = new System.Drawing.Point(5, 5);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox8.Size = new System.Drawing.Size(96, 271);
            this.groupBox8.TabIndex = 27;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Wiimote";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 558);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.pbIR);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkExtension);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wiimote Tester";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbIR)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckedListBox clbButtons;
		private System.Windows.Forms.Label lblAccel;
		private System.Windows.Forms.CheckBox chkLED4;
		private System.Windows.Forms.CheckBox chkLED3;
		private System.Windows.Forms.CheckBox chkLED2;
		private System.Windows.Forms.CheckBox chkLED1;
		private System.Windows.Forms.CheckBox chkRumble;
		private System.Windows.Forms.ProgressBar pbBattery;
		private System.Windows.Forms.Label lblIR1;
		private System.Windows.Forms.Label lblIR2;
		private System.Windows.Forms.CheckBox chkFound1;
		private System.Windows.Forms.CheckBox chkFound2;
		private System.Windows.Forms.Label lblBattery;
		private System.Windows.Forms.PictureBox pbIR;
		private System.Windows.Forms.CheckBox chkExtension;
		private System.Windows.Forms.Label lblChuk;
		private System.Windows.Forms.Label lblChukJoy;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.CheckedListBox clbCCButtons;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.Label lblCCJoy2;
		private System.Windows.Forms.Label lblCCJoy1;
		private System.Windows.Forms.Label lblTriggerR;
		private System.Windows.Forms.Label lblTriggerL;
		private System.Windows.Forms.Label lblIR1Raw;
		private System.Windows.Forms.Label lblIR2Raw;
		private System.Windows.Forms.CheckBox chkFound3;
		private System.Windows.Forms.CheckBox chkFound4;
		private System.Windows.Forms.Label lblIR3Raw;
		private System.Windows.Forms.Label lblIR4Raw;
		private System.Windows.Forms.Label lblIR3;
		private System.Windows.Forms.Label lblIR4;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.Label lblGuitarWhammy;
		private System.Windows.Forms.Label lblGuitarJoy;
		private System.Windows.Forms.CheckedListBox clbGuitarButtons;
		private System.Windows.Forms.GroupBox groupBox8;
		private System.Windows.Forms.CheckBox chkZ;
		private System.Windows.Forms.CheckBox chkC;
	}
}

