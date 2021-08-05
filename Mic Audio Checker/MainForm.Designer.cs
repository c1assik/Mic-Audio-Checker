
namespace Mic_Audio_Checker
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.pnlTitleBar = new System.Windows.Forms.Panel();
			this.pnlClose = new System.Windows.Forms.Panel();
			this.lblClose = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.picIcon = new System.Windows.Forms.PictureBox();
			this.ctxIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
			this.pnlDeviceProperties = new System.Windows.Forms.Panel();
			this.lblDeviceVolume = new System.Windows.Forms.Label();
			this.lbl_DeviceVolume = new System.Windows.Forms.Label();
			this.lblDeviceName = new System.Windows.Forms.Label();
			this.lbl_DeviceName = new System.Windows.Forms.Label();
			this.lblDeviceProperties = new System.Windows.Forms.Label();
			this.picBottomBorder = new System.Windows.Forms.PictureBox();
			this.picRightBorder = new System.Windows.Forms.PictureBox();
			this.picLeftBorder = new System.Windows.Forms.PictureBox();
			this.picTopBorder = new System.Windows.Forms.PictureBox();
			this.pnlCheckVolume = new System.Windows.Forms.Panel();
			this.lblCheckVolume = new System.Windows.Forms.Label();
			this.cmbMicVolume = new System.Windows.Forms.ComboBox();
			this.lblMicVolume = new System.Windows.Forms.Label();
			this.pnlSetVolume = new System.Windows.Forms.Panel();
			this.lblSetVolume = new System.Windows.Forms.Label();
			this.info = new System.Windows.Forms.ToolTip(this.components);
			this.lblVolumeCheck = new System.Windows.Forms.Label();
			this.pnlTitleBar.SuspendLayout();
			this.pnlClose.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
			this.ctxIconMenu.SuspendLayout();
			this.pnlDeviceProperties.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBottomBorder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picRightBorder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picLeftBorder)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picTopBorder)).BeginInit();
			this.pnlCheckVolume.SuspendLayout();
			this.pnlSetVolume.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTitleBar
			// 
			this.pnlTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.pnlTitleBar.Controls.Add(this.pnlClose);
			this.pnlTitleBar.Controls.Add(this.lblTitle);
			this.pnlTitleBar.Controls.Add(this.picIcon);
			this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
			this.pnlTitleBar.Name = "pnlTitleBar";
			this.pnlTitleBar.Size = new System.Drawing.Size(365, 32);
			this.pnlTitleBar.TabIndex = 0;
			this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MSDown);
			// 
			// pnlClose
			// 
			this.pnlClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlClose.Controls.Add(this.lblClose);
			this.pnlClose.Location = new System.Drawing.Point(333, 0);
			this.pnlClose.Name = "pnlClose";
			this.pnlClose.Size = new System.Drawing.Size(32, 32);
			this.pnlClose.TabIndex = 2;
			this.pnlClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_MSClick);
			this.pnlClose.MouseEnter += new System.EventHandler(this.Close_MSEnter);
			this.pnlClose.MouseLeave += new System.EventHandler(this.Close_MSLeave);
			// 
			// lblClose
			// 
			this.lblClose.AutoSize = true;
			this.lblClose.Font = new System.Drawing.Font("Webdings", 10.5F);
			this.lblClose.Location = new System.Drawing.Point(5, 6);
			this.lblClose.Name = "lblClose";
			this.lblClose.Size = new System.Drawing.Size(23, 20);
			this.lblClose.TabIndex = 0;
			this.lblClose.Text = "r";
			this.lblClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_MSClick);
			this.lblClose.MouseEnter += new System.EventHandler(this.Close_MSEnter);
			this.lblClose.MouseLeave += new System.EventHandler(this.Close_MSLeave);
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.Location = new System.Drawing.Point(24, 5);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(140, 21);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "Mic Audio Checker";
			this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MSDown);
			// 
			// picIcon
			// 
			this.picIcon.Image = global::Mic_Audio_Checker.Properties.Resources.microphone;
			this.picIcon.Location = new System.Drawing.Point(3, 6);
			this.picIcon.Name = "picIcon";
			this.picIcon.Size = new System.Drawing.Size(20, 20);
			this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.picIcon.TabIndex = 0;
			this.picIcon.TabStop = false;
			this.picIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ShowIconMenu_MSClick);
			// 
			// ctxIconMenu
			// 
			this.ctxIconMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose});
			this.ctxIconMenu.Name = "ctxIconMenu";
			this.ctxIconMenu.Size = new System.Drawing.Size(104, 26);
			// 
			// btnClose
			// 
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(103, 22);
			this.btnClose.Text = "Close";
			this.btnClose.Click += new System.EventHandler(this.CTXMNU_Close_MSClick);
			// 
			// pnlDeviceProperties
			// 
			this.pnlDeviceProperties.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlDeviceProperties.Controls.Add(this.lblVolumeCheck);
			this.pnlDeviceProperties.Controls.Add(this.lblDeviceVolume);
			this.pnlDeviceProperties.Controls.Add(this.lbl_DeviceVolume);
			this.pnlDeviceProperties.Controls.Add(this.lblDeviceName);
			this.pnlDeviceProperties.Controls.Add(this.lbl_DeviceName);
			this.pnlDeviceProperties.Controls.Add(this.lblDeviceProperties);
			this.pnlDeviceProperties.Controls.Add(this.picBottomBorder);
			this.pnlDeviceProperties.Controls.Add(this.picRightBorder);
			this.pnlDeviceProperties.Controls.Add(this.picLeftBorder);
			this.pnlDeviceProperties.Controls.Add(this.picTopBorder);
			this.pnlDeviceProperties.Location = new System.Drawing.Point(12, 35);
			this.pnlDeviceProperties.Name = "pnlDeviceProperties";
			this.pnlDeviceProperties.Size = new System.Drawing.Size(341, 100);
			this.pnlDeviceProperties.TabIndex = 2;
			// 
			// lblDeviceVolume
			// 
			this.lblDeviceVolume.AutoSize = true;
			this.lblDeviceVolume.Font = new System.Drawing.Font("Leelawadee UI", 10F);
			this.lblDeviceVolume.Location = new System.Drawing.Point(120, 67);
			this.lblDeviceVolume.Name = "lblDeviceVolume";
			this.lblDeviceVolume.Size = new System.Drawing.Size(33, 19);
			this.lblDeviceVolume.TabIndex = 8;
			this.lblDeviceVolume.Text = "999";
			this.info.SetToolTip(this.lblDeviceVolume, "The volume of the microphone that is currently connected.");
			// 
			// lbl_DeviceVolume
			// 
			this.lbl_DeviceVolume.AutoSize = true;
			this.lbl_DeviceVolume.Font = new System.Drawing.Font("Leelawadee UI", 10F);
			this.lbl_DeviceVolume.Location = new System.Drawing.Point(11, 67);
			this.lbl_DeviceVolume.Name = "lbl_DeviceVolume";
			this.lbl_DeviceVolume.Size = new System.Drawing.Size(103, 19);
			this.lbl_DeviceVolume.TabIndex = 7;
			this.lbl_DeviceVolume.Text = "Device Volume:";
			// 
			// lblDeviceName
			// 
			this.lblDeviceName.AutoSize = true;
			this.lblDeviceName.Font = new System.Drawing.Font("Leelawadee UI", 10F);
			this.lblDeviceName.Location = new System.Drawing.Point(120, 36);
			this.lblDeviceName.Name = "lblDeviceName";
			this.lblDeviceName.Size = new System.Drawing.Size(100, 19);
			this.lblDeviceName.TabIndex = 6;
			this.lblDeviceName.Text = "MICROPHONE";
			this.info.SetToolTip(this.lblDeviceName, "The name of the microphone that is currently connected.");
			// 
			// lbl_DeviceName
			// 
			this.lbl_DeviceName.AutoSize = true;
			this.lbl_DeviceName.Font = new System.Drawing.Font("Leelawadee UI", 10F);
			this.lbl_DeviceName.Location = new System.Drawing.Point(11, 36);
			this.lbl_DeviceName.Name = "lbl_DeviceName";
			this.lbl_DeviceName.Size = new System.Drawing.Size(92, 19);
			this.lbl_DeviceName.TabIndex = 5;
			this.lbl_DeviceName.Text = "Device Name:";
			// 
			// lblDeviceProperties
			// 
			this.lblDeviceProperties.AutoSize = true;
			this.lblDeviceProperties.Location = new System.Drawing.Point(9, 4);
			this.lblDeviceProperties.Name = "lblDeviceProperties";
			this.lblDeviceProperties.Size = new System.Drawing.Size(131, 21);
			this.lblDeviceProperties.TabIndex = 3;
			this.lblDeviceProperties.Text = "Device Properties";
			// 
			// picBottomBorder
			// 
			this.picBottomBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picBottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.picBottomBorder.Location = new System.Drawing.Point(0, 99);
			this.picBottomBorder.Name = "picBottomBorder";
			this.picBottomBorder.Size = new System.Drawing.Size(341, 1);
			this.picBottomBorder.TabIndex = 2;
			this.picBottomBorder.TabStop = false;
			// 
			// picRightBorder
			// 
			this.picRightBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picRightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.picRightBorder.Location = new System.Drawing.Point(340, 15);
			this.picRightBorder.Name = "picRightBorder";
			this.picRightBorder.Size = new System.Drawing.Size(1, 85);
			this.picRightBorder.TabIndex = 1;
			this.picRightBorder.TabStop = false;
			// 
			// picLeftBorder
			// 
			this.picLeftBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.picLeftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.picLeftBorder.Location = new System.Drawing.Point(0, 15);
			this.picLeftBorder.Name = "picLeftBorder";
			this.picLeftBorder.Size = new System.Drawing.Size(1, 85);
			this.picLeftBorder.TabIndex = 0;
			this.picLeftBorder.TabStop = false;
			// 
			// picTopBorder
			// 
			this.picTopBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.picTopBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
			this.picTopBorder.Location = new System.Drawing.Point(0, 15);
			this.picTopBorder.Name = "picTopBorder";
			this.picTopBorder.Size = new System.Drawing.Size(341, 1);
			this.picTopBorder.TabIndex = 4;
			this.picTopBorder.TabStop = false;
			// 
			// pnlCheckVolume
			// 
			this.pnlCheckVolume.Controls.Add(this.lblCheckVolume);
			this.pnlCheckVolume.Location = new System.Drawing.Point(12, 141);
			this.pnlCheckVolume.Name = "pnlCheckVolume";
			this.pnlCheckVolume.Size = new System.Drawing.Size(140, 43);
			this.pnlCheckVolume.TabIndex = 3;
			this.info.SetToolTip(this.pnlCheckVolume, "Checks the microphone\'s volume to see if it\'s in the range of 80-100.");
			this.pnlCheckVolume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckVolume_MSClick);
			this.pnlCheckVolume.MouseEnter += new System.EventHandler(this.CheckVolume_MSEnter);
			this.pnlCheckVolume.MouseLeave += new System.EventHandler(this.CheckVolume_MSLeave);
			// 
			// lblCheckVolume
			// 
			this.lblCheckVolume.AutoSize = true;
			this.lblCheckVolume.Location = new System.Drawing.Point(16, 10);
			this.lblCheckVolume.Name = "lblCheckVolume";
			this.lblCheckVolume.Size = new System.Drawing.Size(110, 21);
			this.lblCheckVolume.TabIndex = 0;
			this.lblCheckVolume.Text = "Check Volume";
			this.info.SetToolTip(this.lblCheckVolume, "Checks the microphone\'s volume to see if it\'s in the range of 80-100.");
			this.lblCheckVolume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckVolume_MSClick);
			this.lblCheckVolume.MouseEnter += new System.EventHandler(this.CheckVolume_MSEnter);
			this.lblCheckVolume.MouseLeave += new System.EventHandler(this.CheckVolume_MSLeave);
			// 
			// cmbMicVolume
			// 
			this.cmbMicVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbMicVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
			this.cmbMicVolume.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbMicVolume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cmbMicVolume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
			this.cmbMicVolume.FormattingEnabled = true;
			this.cmbMicVolume.Location = new System.Drawing.Point(158, 147);
			this.cmbMicVolume.Name = "cmbMicVolume";
			this.cmbMicVolume.Size = new System.Drawing.Size(195, 29);
			this.cmbMicVolume.TabIndex = 4;
			this.info.SetToolTip(this.cmbMicVolume, "Set the volume in a range of 80-100.");
			// 
			// lblMicVolume
			// 
			this.lblMicVolume.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblMicVolume.Location = new System.Drawing.Point(158, 147);
			this.lblMicVolume.Name = "lblMicVolume";
			this.lblMicVolume.Size = new System.Drawing.Size(177, 29);
			this.lblMicVolume.TabIndex = 5;
			this.lblMicVolume.Text = "999";
			this.lblMicVolume.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.info.SetToolTip(this.lblMicVolume, "Set the volume in a range of 80-100.");
			// 
			// pnlSetVolume
			// 
			this.pnlSetVolume.Controls.Add(this.lblSetVolume);
			this.pnlSetVolume.Location = new System.Drawing.Point(12, 190);
			this.pnlSetVolume.Name = "pnlSetVolume";
			this.pnlSetVolume.Size = new System.Drawing.Size(341, 43);
			this.pnlSetVolume.TabIndex = 4;
			this.info.SetToolTip(this.pnlSetVolume, "Actually sets/modifies the volume of the microphone.");
			this.pnlSetVolume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetVolume_MSClick);
			this.pnlSetVolume.MouseEnter += new System.EventHandler(this.SetVolume_MSEnter);
			this.pnlSetVolume.MouseLeave += new System.EventHandler(this.SetVolume_MSLeave);
			// 
			// lblSetVolume
			// 
			this.lblSetVolume.AutoSize = true;
			this.lblSetVolume.Location = new System.Drawing.Point(127, 10);
			this.lblSetVolume.Name = "lblSetVolume";
			this.lblSetVolume.Size = new System.Drawing.Size(90, 21);
			this.lblSetVolume.TabIndex = 0;
			this.lblSetVolume.Text = "Set Volume";
			this.info.SetToolTip(this.lblSetVolume, "Actually sets/modifies the volume of the microphone.");
			this.lblSetVolume.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SetVolume_MSClick);
			this.lblSetVolume.MouseEnter += new System.EventHandler(this.SetVolume_MSEnter);
			this.lblSetVolume.MouseLeave += new System.EventHandler(this.SetVolume_MSLeave);
			// 
			// lblVolumeCheck
			// 
			this.lblVolumeCheck.AutoSize = true;
			this.lblVolumeCheck.Font = new System.Drawing.Font("Webdings", 10.5F);
			this.lblVolumeCheck.Location = new System.Drawing.Point(147, 66);
			this.lblVolumeCheck.Name = "lblVolumeCheck";
			this.lblVolumeCheck.Size = new System.Drawing.Size(23, 20);
			this.lblVolumeCheck.TabIndex = 9;
			this.lblVolumeCheck.Text = "r";
			this.lblVolumeCheck.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.ClientSize = new System.Drawing.Size(365, 240);
			this.Controls.Add(this.pnlSetVolume);
			this.Controls.Add(this.lblMicVolume);
			this.Controls.Add(this.cmbMicVolume);
			this.Controls.Add(this.pnlCheckVolume);
			this.Controls.Add(this.pnlDeviceProperties);
			this.Controls.Add(this.pnlTitleBar);
			this.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Mic Audio Checker";
			this.pnlTitleBar.ResumeLayout(false);
			this.pnlTitleBar.PerformLayout();
			this.pnlClose.ResumeLayout(false);
			this.pnlClose.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
			this.ctxIconMenu.ResumeLayout(false);
			this.pnlDeviceProperties.ResumeLayout(false);
			this.pnlDeviceProperties.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picBottomBorder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picRightBorder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picLeftBorder)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picTopBorder)).EndInit();
			this.pnlCheckVolume.ResumeLayout(false);
			this.pnlCheckVolume.PerformLayout();
			this.pnlSetVolume.ResumeLayout(false);
			this.pnlSetVolume.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTitleBar;
		private System.Windows.Forms.PictureBox picIcon;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.ContextMenuStrip ctxIconMenu;
		private System.Windows.Forms.ToolStripMenuItem btnClose;
		private System.Windows.Forms.Panel pnlClose;
		private System.Windows.Forms.Label lblClose;
		private System.Windows.Forms.Panel pnlDeviceProperties;
		private System.Windows.Forms.PictureBox picLeftBorder;
		private System.Windows.Forms.PictureBox picRightBorder;
		private System.Windows.Forms.PictureBox picBottomBorder;
		private System.Windows.Forms.Label lblDeviceProperties;
		private System.Windows.Forms.PictureBox picTopBorder;
		private System.Windows.Forms.Label lblDeviceVolume;
		private System.Windows.Forms.Label lbl_DeviceVolume;
		private System.Windows.Forms.Label lblDeviceName;
		private System.Windows.Forms.Label lbl_DeviceName;
		private System.Windows.Forms.Panel pnlCheckVolume;
		private System.Windows.Forms.Label lblCheckVolume;
		private System.Windows.Forms.ComboBox cmbMicVolume;
		private System.Windows.Forms.Label lblMicVolume;
		private System.Windows.Forms.Panel pnlSetVolume;
		private System.Windows.Forms.Label lblSetVolume;
		private System.Windows.Forms.ToolTip info;
		private System.Windows.Forms.Label lblVolumeCheck;
	}
}

