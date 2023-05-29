
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblClose = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.ctxIconMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnClose = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlDeviceProperties = new System.Windows.Forms.Panel();
            this.lblVolumeCheck = new System.Windows.Forms.Label();
            this.lblDeviceVolume = new System.Windows.Forms.Label();
            this.lbl_DeviceVolume = new System.Windows.Forms.Label();
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.lbl_DeviceName = new System.Windows.Forms.Label();
            this.lblDeviceProperties = new System.Windows.Forms.Label();
            this.picBottomBorder = new System.Windows.Forms.PictureBox();
            this.picRightBorder = new System.Windows.Forms.PictureBox();
            this.picLeftBorder = new System.Windows.Forms.PictureBox();
            this.picTopBorder = new System.Windows.Forms.PictureBox();
            this.info = new System.Windows.Forms.ToolTip(this.components);
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.ctxIconMenu.SuspendLayout();
            this.pnlDeviceProperties.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopBorder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitleBar
            // 
            this.pnlTitleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.pnlTitleBar.Controls.Add(this.label2);
            this.pnlTitleBar.Controls.Add(this.lblTitle);
            this.pnlTitleBar.Controls.Add(this.lblClose);
            this.pnlTitleBar.Controls.Add(this.picIcon);
            this.pnlTitleBar.Location = new System.Drawing.Point(0, 0);
            this.pnlTitleBar.Name = "pnlTitleBar";
            this.pnlTitleBar.Size = new System.Drawing.Size(479, 32);
            this.pnlTitleBar.TabIndex = 0;
            this.pnlTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MSDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 21);
            this.label2.TabIndex = 10;
            this.label2.Text = "_";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(24, 5);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(142, 21);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Mic Volume Freeze\r\n";
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MSDown);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Font = new System.Drawing.Font("Webdings", 10.5F);
            this.lblClose.Location = new System.Drawing.Point(443, 6);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(23, 20);
            this.lblClose.TabIndex = 9;
            this.lblClose.Text = "r";
            this.lblClose.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Close_MSClick);
            this.lblClose.MouseEnter += new System.EventHandler(this.Close_MSEnter);
            this.lblClose.MouseLeave += new System.EventHandler(this.Close_MSLeave);
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
            this.pnlDeviceProperties.Size = new System.Drawing.Size(454, 100);
            this.pnlDeviceProperties.TabIndex = 2;
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
            this.picBottomBorder.Size = new System.Drawing.Size(594, 1);
            this.picBottomBorder.TabIndex = 2;
            this.picBottomBorder.TabStop = false;
            // 
            // picRightBorder
            // 
            this.picRightBorder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picRightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(85)))));
            this.picRightBorder.Location = new System.Drawing.Point(593, 15);
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
            this.picTopBorder.Size = new System.Drawing.Size(594, 1);
            this.picTopBorder.TabIndex = 4;
            this.picTopBorder.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.PanEast;
            this.trackBar1.Location = new System.Drawing.Point(163, 160);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(184, 45);
            this.trackBar1.TabIndex = 6;
            this.trackBar1.Value = 50;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Минимальное значение: 50";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(20, 160);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(132, 25);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Freeze Volume";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Mic Volume Freeze";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(478, 259);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.pnlDeviceProperties);
            this.Controls.Add(this.pnlTitleBar);
            this.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(185)))), ((int)(((byte)(185)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mic Level Freeze";
            this.pnlTitleBar.ResumeLayout(false);
            this.pnlTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ctxIconMenu.ResumeLayout(false);
            this.pnlDeviceProperties.ResumeLayout(false);
            this.pnlDeviceProperties.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBottomBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRightBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLeftBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTopBorder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel pnlTitleBar;
		private System.Windows.Forms.PictureBox picIcon;
		private System.Windows.Forms.Label lblTitle;
		private System.Windows.Forms.ContextMenuStrip ctxIconMenu;
		private System.Windows.Forms.ToolStripMenuItem btnClose;
		//private System.Windows.Forms.Label lblClose;
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
		private System.Windows.Forms.ToolTip info;
		private System.Windows.Forms.Label lblVolumeCheck;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label lblClose;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label2;
    }
}

