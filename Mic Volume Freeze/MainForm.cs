using Mic_Audio_Checker.Properties;
using NAudio.CoreAudioApi;
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mic_Audio_Checker
{
	public partial class MainForm : DropShadowForm
	{
		public MainForm()
		{
			InitializeComponent();
            trackBar1.Scroll += trackBar1_Scroll;

			Timer t = new Timer { Interval = 1 };
			Timer t2 = new Timer { Interval = 1500 };
			t.Tick += (s, e) =>
			{
				lblDeviceName.Text = "Getting info...";
				lblDeviceVolume.Text = "Getting info...";

				t.Enabled = false;
				t2.Start();
			};
			t2.Tick += (s, e) =>
			{
				MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
				MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
				if (devices.Count > 0)
				{
					MMDevice mic = devices[0];
					lblDeviceName.Text = mic.FriendlyName;
					lblDeviceVolume.Text = (mic.AudioEndpointVolume.MasterVolumeLevelScalar * 100.0f).ToString();
                    label1.Text = String.Format("Минимальное значение: {0}", mic.AudioEndpointVolume.MasterVolumeLevelScalar * 100.0f);
				}
				else
				{
					lblDeviceName.Text = "No Microphone Detected";
					lblDeviceVolume.Text = "N/A";
				}
				t2.Enabled = false;
			};
			t.Start();
		}

        private void label2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            //this.ShowInTaskbar = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            //if the form is minimized  
            //hide it from the task bar  
            //and show the system tray icon (represented by the NotifyIcon control)  
            if (this.WindowState == FormWindowState.Minimized)
            {
                notifyIcon1.Visible = true;
                Hide();

            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon1.Visible = false;
        }

        [DllImport("user32.dll")]
		private static extern bool ReleaseCapture();

		[DllImport("user32.dll")]
		private static extern int SendMessage(IntPtr hwnd, int msg, int wp, int lp);

		private void TitleBar_MSDown(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ReleaseCapture();
				SendMessage(Handle, 161, 2, 0);
			}
		}
		private void ShowIconMenu_MSClick(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				ctxIconMenu.Show(MousePosition);
			}
		}

		private void Close_MSEnter(object sender, EventArgs e)
		{
			lblClose.BackColor = Color.FromArgb(45, 45, 45);
		}
		private void Close_MSLeave(object sender, EventArgs e)
		{
			lblClose.BackColor = Color.FromArgb(35, 35, 35);
		}

		private void Close_MSClick(object sender, MouseEventArgs e)
		{
			Application.Exit();
		}
		private void CTXMNU_Close_MSClick(object sender, EventArgs e)
		{
			Application.Exit();
		}

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = String.Format("Минимальное значение: {0}", trackBar1.Value);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            CheckBox checkBox = (CheckBox)sender; // приводим отправителя к элементу типа CheckBox
            if (checkBox.Checked == true)
            {
                int volume = 0;

                MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
                MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
                if (devices.Count > 0)
                {
                    MMDevice mic = devices[0];
                    volume = (int)(mic.AudioEndpointVolume.MasterVolumeLevelScalar * 100.0f);
                    lblDeviceVolume.Text = volume.ToString();

                    Timer t3 = new Timer { Interval = 10 };
                    
                    t3.Tick += (ss, eee) =>
                    {
						if (checkBox.Checked == false) { t3.Enabled = false; }
                        volume = (int)(mic.AudioEndpointVolume.MasterVolumeLevelScalar * 100.0f);
                        if (volume < trackBar1.Value)
                        {
							Timer t = new Timer { Interval = 5 };
                            Timer t2 = new Timer { Interval = 20 };
                            t.Tick += (s, ee) =>
								{
                                    lblDeviceVolume.Text = "Changing...";
                                    t.Enabled = false;
                                    t2.Start();
                                };
                                t2.Tick += (s, ee) =>
                                {
                                    mic.AudioEndpointVolume.MasterVolumeLevelScalar = trackBar1.Value / 100.0f;
                                    lblDeviceVolume.Text = volume.ToString();
                                    t2.Enabled = false;
                   
                                };
                                t.Start();
							}
						};
						t3.Start();
					}
                else
                {
                    MessageBox.Show("No microphones were detected. Are any plugged in?", "No Microphones Found",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

