using NAudio.CoreAudioApi;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Mic_Audio_Checker
{
	public partial class MainForm : DropShadowForm
	{
		public MainForm()
		{
			InitializeComponent();

			cmbMicVolume.Items.AddRange(volumes);
			cmbMicVolume.Text = volumes[0];
			lblMicVolume.Text = cmbMicVolume.Text;
			cmbMicVolume.TextChanged += (s, e) => lblMicVolume.Text = cmbMicVolume.Text;
			cmbMicVolume.TextUpdate += (s, e) => lblMicVolume.Text = cmbMicVolume.Text;
			cmbMicVolume.SelectedIndexChanged += (s, e) => lblMicVolume.Text = cmbMicVolume.Text;
			cmbMicVolume.SelectedValueChanged += (s, e) => lblMicVolume.Text = cmbMicVolume.Text;

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

					volumeCheckTip = new ToolTip();
					if (mic.AudioEndpointVolume.MasterVolumeLevelScalar < 0.80f)
					{
						lblVolumeCheck.Text = "r";
						lblVolumeCheck.ForeColor = Color.Firebrick;
						volumeCheckTip.SetToolTip(lblVolumeCheck, "Microphone volume is below recommended range.");
					}
					else if (mic.AudioEndpointVolume.MasterVolumeLevelScalar >= 0.80f)
					{
						lblVolumeCheck.Text = "a";
						lblVolumeCheck.ForeColor = Color.Green;
						volumeCheckTip.SetToolTip(lblVolumeCheck, "Microphone volume is at recommended range.");
					}
					lblVolumeCheck.Visible = true;
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

		private string[] volumes =
		{
			"80",
			"81",
			"82",
			"83",
			"84",
			"85",
			"86",
			"87",
			"88",
			"89",
			"90",
			"91",
			"92",
			"93",
			"94",
			"95",
			"96",
			"97",
			"98",
			"99",
			"100",
		};
		private ToolTip volumeCheckTip;

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
			pnlClose.BackColor = Color.FromArgb(45, 45, 45);
			lblClose.BackColor = Color.FromArgb(45, 45, 45);
		}
		private void Close_MSLeave(object sender, EventArgs e)
		{
			pnlClose.BackColor = Color.FromArgb(35, 35, 35);
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

		private void CheckVolume_MSEnter(object sender, EventArgs e)
		{
			pnlCheckVolume.BackColor = Color.FromArgb(35, 35, 35);
			lblCheckVolume.BackColor = Color.FromArgb(35, 35, 35);
		}
		private void CheckVolume_MSLeave(object sender, EventArgs e)
		{
			pnlCheckVolume.BackColor = Color.FromArgb(25, 25, 25);
			lblCheckVolume.BackColor = Color.FromArgb(25, 25, 25);
		}

		private void CheckVolume_MSClick(object sender, MouseEventArgs e)
		{
			int volume = 0;

			MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
			MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
			if (devices.Count > 0)
			{
				MMDevice mic = devices[0];
				volume = (int)(mic.AudioEndpointVolume.MasterVolumeLevelScalar * 100.0f);
				lblDeviceVolume.Text = volume.ToString();
				lblVolumeCheck.Visible = false;
				if (mic.AudioEndpointVolume.MasterVolumeLevelScalar < 0.80f)
				{
					lblVolumeCheck.Text = "r";
					lblVolumeCheck.ForeColor = Color.Firebrick;
					volumeCheckTip.SetToolTip(lblVolumeCheck, "Microphone volume is below recommended range.");
				}
				else if (mic.AudioEndpointVolume.MasterVolumeLevelScalar >= 0.80f)
				{
					lblVolumeCheck.Text = "a";
					lblVolumeCheck.ForeColor = Color.Green;
					volumeCheckTip.SetToolTip(lblVolumeCheck, "Microphone volume is at recommended range.");
				}
				lblVolumeCheck.Visible = true;

				if (volume < 80)
				{
					DialogResult dialog = MessageBox.Show("There was an issue detected. Your microphone volume is below 80.\n" +
						"Would you like to increase it to 80? You can change it anytime.", "Problem Found",
						MessageBoxButtons.YesNo, MessageBoxIcon.Error);

					if (dialog == DialogResult.Yes)
					{
						Timer t = new Timer { Interval = 1 };
						Timer t2 = new Timer { Interval = 1500 };
						t.Tick += (s, ee) =>
						{
							lblDeviceVolume.Text = "Changing...";
							t.Enabled = false;
							t2.Start();
						};
						t2.Tick += (s, ee) =>
						{
							mic.AudioEndpointVolume.MasterVolumeLevelScalar = 0.80f;
							lblDeviceVolume.Text = "80";
							t2.Enabled = false;
						};
						t.Start();
					}
				}
				else if (volume >= 80)
				{
					MessageBox.Show("No issues found. Your microphone is in the recommended range of 80-100.", "No Issues",
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			else
			{
				MessageBox.Show("No microphones were detected. Are any plugged in?", "No Microphones Found",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void SetVolume_MSEnter(object sender, EventArgs e)
		{
			pnlSetVolume.BackColor = Color.FromArgb(35, 35, 35);
			lblSetVolume.BackColor = Color.FromArgb(35, 35, 35);
		}
		private void SetVolume_MSLeave(object sender, EventArgs e)
		{
			pnlSetVolume.BackColor = Color.FromArgb(25, 25, 25);
			lblSetVolume.BackColor = Color.FromArgb(25, 25, 25);
		}

		private void SetVolume_MSClick(object sender, MouseEventArgs e)
		{
			MMDeviceEnumerator enumerator = new MMDeviceEnumerator();
			MMDeviceCollection devices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
			if (devices.Count > 0)
			{
				int volume = int.Parse(lblMicVolume.Text);
				float volumef = volume / 100.0f;
				MMDevice mic = devices[0];
				Timer t = new Timer { Interval = 1 };
				Timer t2 = new Timer { Interval = 1500 };
				t.Tick += (s, ee) =>
				{
					lblVolumeCheck.Visible = false;
					lblDeviceVolume.Text = "Changing...";
					t.Enabled = false;
					t2.Start();
				};
				t2.Tick += (s, ee) =>
				{
					mic.AudioEndpointVolume.MasterVolumeLevelScalar = volumef;
					lblDeviceVolume.Text = volume.ToString();
					lblVolumeCheck.Visible = true;
					t2.Enabled = false;
				};
				t.Start();
			}
			else
			{
				MessageBox.Show("No microphones were detected. Are any plugged in?", "No Microphones Found",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
}
