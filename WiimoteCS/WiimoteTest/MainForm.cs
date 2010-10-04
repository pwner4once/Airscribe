//////////////////////////////////////////////////////////////////////////////////
//	Form1.cs
//	Managed Wiimote Library Tester
//	Written by Brian Peek (http://www.brianpeek.com/)
//  for MSDN's Coding4Fun (http://msdn.microsoft.com/coding4fun/)
//	Visit http://blogs.msdn.com/coding4fun/archive/2007/03/14/1879033.aspx
//  and http://www.codeplex.com/WiimoteLib
//  for more information
//////////////////////////////////////////////////////////////////////////////////

using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using WiimoteLib;

namespace WiimoteTest
{
	public partial class MainForm : Form
	{
		private delegate void UpdateWiimoteStateDelegate(WiimoteChangedEventArgs args);
		private delegate void UpdateExtensionChangedDelegate(WiimoteExtensionChangedEventArgs args);

		Wiimote wm = new Wiimote();
		Bitmap b = new Bitmap(256, 192, PixelFormat.Format24bppRgb);
		Graphics g;

		public MainForm()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			wm.WiimoteChanged += wm_WiimoteChanged;
			wm.WiimoteExtensionChanged += wm_WiimoteExtensionChanged;

			g = Graphics.FromImage(b);
			wm.Connect();
			wm.SetReportType(InputReport.IRAccel, true);
			wm.SetLEDs(false, true, true, false);
		}

		private void UpdateExtensionChanged(WiimoteExtensionChangedEventArgs args)
		{
			chkExtension.Text = args.ExtensionType.ToString();
			chkExtension.Checked = args.Inserted;

			if(args.Inserted)
				wm.SetReportType(InputReport.IRExtensionAccel, true);
			else
				wm.SetReportType(InputReport.IRAccel, true);
		}

		private void UpdateWiimoteState(WiimoteChangedEventArgs args)
		{
			WiimoteState ws = args.WiimoteState;

			clbButtons.SetItemChecked(0, ws.ButtonState.A);
			clbButtons.SetItemChecked(1, ws.ButtonState.B);
			clbButtons.SetItemChecked(2, ws.ButtonState.Minus);
			clbButtons.SetItemChecked(3, ws.ButtonState.Home);
			clbButtons.SetItemChecked(4, ws.ButtonState.Plus);
			clbButtons.SetItemChecked(5, ws.ButtonState.One);
			clbButtons.SetItemChecked(6, ws.ButtonState.Two);
			clbButtons.SetItemChecked(7, ws.ButtonState.Up);
			clbButtons.SetItemChecked(8, ws.ButtonState.Down);
			clbButtons.SetItemChecked(9, ws.ButtonState.Left);
			clbButtons.SetItemChecked(10, ws.ButtonState.Right);

			lblAccel.Text = ws.AccelState.Values.ToString();
            
			switch(ws.ExtensionType)
			{
				case ExtensionType.Nunchuk:
					lblChuk.Text = ws.NunchukState.AccelState.Values.ToString();
					lblChukJoy.Text = ws.NunchukState.Joystick.ToString();
					chkC.Checked = ws.NunchukState.C;
					chkZ.Checked = ws.NunchukState.Z;
					break;

				case ExtensionType.ClassicController:
					clbCCButtons.SetItemChecked(0, ws.ClassicControllerState.ButtonState.A);
					clbCCButtons.SetItemChecked(1, ws.ClassicControllerState.ButtonState.B);
					clbCCButtons.SetItemChecked(2, ws.ClassicControllerState.ButtonState.X);
					clbCCButtons.SetItemChecked(3, ws.ClassicControllerState.ButtonState.Y);
					clbCCButtons.SetItemChecked(4, ws.ClassicControllerState.ButtonState.Minus);
					clbCCButtons.SetItemChecked(5, ws.ClassicControllerState.ButtonState.Home);
					clbCCButtons.SetItemChecked(6, ws.ClassicControllerState.ButtonState.Plus);
					clbCCButtons.SetItemChecked(7, ws.ClassicControllerState.ButtonState.Up);
					clbCCButtons.SetItemChecked(8, ws.ClassicControllerState.ButtonState.Down);
					clbCCButtons.SetItemChecked(9, ws.ClassicControllerState.ButtonState.Left);
					clbCCButtons.SetItemChecked(10, ws.ClassicControllerState.ButtonState.Right);
					clbCCButtons.SetItemChecked(11, ws.ClassicControllerState.ButtonState.ZL);
					clbCCButtons.SetItemChecked(12, ws.ClassicControllerState.ButtonState.ZR);
					clbCCButtons.SetItemChecked(13, ws.ClassicControllerState.ButtonState.TriggerL);
					clbCCButtons.SetItemChecked(14, ws.ClassicControllerState.ButtonState.TriggerR);

					lblCCJoy1.Text = ws.ClassicControllerState.JoystickL.ToString();
					lblCCJoy2.Text = ws.ClassicControllerState.JoystickR.ToString();

					lblTriggerL.Text = ws.ClassicControllerState.TriggerL.ToString();
					lblTriggerR.Text = ws.ClassicControllerState.TriggerR.ToString();
					break;

				case ExtensionType.Guitar:
				    clbGuitarButtons.SetItemChecked(0, ws.GuitarState.ButtonState.Green);
				    clbGuitarButtons.SetItemChecked(1, ws.GuitarState.ButtonState.Red);
				    clbGuitarButtons.SetItemChecked(2, ws.GuitarState.ButtonState.Yellow);
				    clbGuitarButtons.SetItemChecked(3, ws.GuitarState.ButtonState.Blue);
				    clbGuitarButtons.SetItemChecked(4, ws.GuitarState.ButtonState.Orange);
				    clbGuitarButtons.SetItemChecked(5, ws.GuitarState.ButtonState.Minus);
				    clbGuitarButtons.SetItemChecked(6, ws.GuitarState.ButtonState.Plus);
				    clbGuitarButtons.SetItemChecked(7, ws.GuitarState.ButtonState.StrumUp);
				    clbGuitarButtons.SetItemChecked(8, ws.GuitarState.ButtonState.StrumDown);

					lblGuitarJoy.Text = ws.GuitarState.Joystick.ToString();
					lblGuitarWhammy.Text = ws.GuitarState.WhammyBar.ToString();
				    break;
			}

			g.Clear(Color.Black);

			if(ws.IRState.IRSensors[0].Found)
			{
				lblIR1.Text = ws.IRState.IRSensors[0].Position + ", " + ws.IRState.IRSensors[0].Size;
				lblIR1Raw.Text = ws.IRState.IRSensors[0].RawPosition.ToString();
				g.DrawEllipse(new Pen(Color.Red), (int)(ws.IRState.IRSensors[0].RawPosition.X / 4), (int)(ws.IRState.IRSensors[0].RawPosition.Y / 4),
							 ws.IRState.IRSensors[0].Size+1, ws.IRState.IRSensors[0].Size+1);
			}
			if(ws.IRState.IRSensors[1].Found)
			{
				lblIR2.Text = ws.IRState.IRSensors[1].Position + ", " + ws.IRState.IRSensors[1].Size;
				lblIR2Raw.Text = ws.IRState.IRSensors[1].RawPosition.ToString();
				g.DrawEllipse(new Pen(Color.Blue), (int)(ws.IRState.IRSensors[1].RawPosition.X / 4), (int)(ws.IRState.IRSensors[1].RawPosition.Y / 4),
							 ws.IRState.IRSensors[1].Size+1, ws.IRState.IRSensors[1].Size+1);
			}
			if(ws.IRState.IRSensors[2].Found)
			{
				lblIR3.Text = ws.IRState.IRSensors[2].Position + ", " + ws.IRState.IRSensors[2].Size;
				lblIR3Raw.Text = ws.IRState.IRSensors[2].RawPosition.ToString();
				g.DrawEllipse(new Pen(Color.Yellow), (int)(ws.IRState.IRSensors[2].RawPosition.X / 4), (int)(ws.IRState.IRSensors[2].RawPosition.Y / 4),
							 ws.IRState.IRSensors[2].Size+1, ws.IRState.IRSensors[2].Size+1);
			}
			if(ws.IRState.IRSensors[3].Found)
			{
				lblIR4.Text = ws.IRState.IRSensors[3].Position + ", " + ws.IRState.IRSensors[3].Size;
				lblIR4Raw.Text = ws.IRState.IRSensors[3].RawPosition.ToString();
				g.DrawEllipse(new Pen(Color.Orange), (int)(ws.IRState.IRSensors[3].RawPosition.X / 4), (int)(ws.IRState.IRSensors[3].RawPosition.Y / 4),
							 ws.IRState.IRSensors[3].Size+1, ws.IRState.IRSensors[3].Size+1);
			}

			if(ws.IRState.IRSensors[0].Found && ws.IRState.IRSensors[1].Found)
				g.DrawEllipse(new Pen(Color.Green), (int)(ws.IRState.RawMidpoint.X / 4), (int)(ws.IRState.RawMidpoint.Y / 4), 2, 2);

			pbIR.Image = b;

			chkFound1.Checked = ws.IRState.IRSensors[0].Found;
			chkFound2.Checked = ws.IRState.IRSensors[1].Found;
			chkFound3.Checked = ws.IRState.IRSensors[2].Found;
			chkFound4.Checked = ws.IRState.IRSensors[3].Found;

			pbBattery.Value = (ws.Battery > 0xc8 ? 0xc8 : (int)ws.Battery);
			float f = (((100.0f * 48.0f * (float)(ws.Battery / 48.0f))) / 192.0f);
			lblBattery.Text = f.ToString("F");

            // add stuff listview for XYZ data
            if (ws.ButtonState.A)
            {
                lv_xyz.Items.Insert(0, new ListViewItem(new string[] { ws.AccelState.Values.X.ToString(), ws.AccelState.Values.Y.ToString(), ws.AccelState.Values.Z.ToString() }));
            }
		}

		private void wm_WiimoteChanged(object sender, WiimoteChangedEventArgs args)
		{
			BeginInvoke(new UpdateWiimoteStateDelegate(UpdateWiimoteState), args);
		}

		private void wm_WiimoteExtensionChanged(object sender, WiimoteExtensionChangedEventArgs args)
		{
			BeginInvoke(new UpdateExtensionChangedDelegate(UpdateExtensionChanged), args);
		}

		private void chkLED1_CheckedChanged(object sender, EventArgs e)
		{
			wm.SetLEDs(chkLED1.Checked, chkLED2.Checked, chkLED3.Checked, chkLED4.Checked);
		}

		private void chkRumble_CheckedChanged(object sender, EventArgs e)
		{
			wm.SetRumble(chkRumble.Checked);
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			wm.Disconnect();
		}
	}
}
