namespace MultiTemperatureCBWServiceManager
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlStatus = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.lblServiceStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCBWMins = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.numUpDwn_CBWInterval = new System.Windows.Forms.NumericUpDown();
            this.chkCBW_Enabled = new System.Windows.Forms.CheckBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtIPaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAddDevice = new System.Windows.Forms.Button();
            this.lstDevices = new System.Windows.Forms.ListBox();
            this.btnStopService = new System.Windows.Forms.Button();
            this.btnStartService = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBrowseLogFilePath = new System.Windows.Forms.Button();
            this.txtLogFileFullPath = new System.Windows.Forms.TextBox();
            this.tmrServiceCheckStatus = new System.Windows.Forms.Timer(this.components);
            this.pnlStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_CBWInterval)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlStatus
            // 
            this.pnlStatus.BackColor = System.Drawing.Color.SlateGray;
            this.pnlStatus.Controls.Add(this.picLogo);
            this.pnlStatus.Controls.Add(this.lblServiceStatus);
            this.pnlStatus.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatus.Location = new System.Drawing.Point(0, 0);
            this.pnlStatus.Name = "pnlStatus";
            this.pnlStatus.Size = new System.Drawing.Size(700, 34);
            this.pnlStatus.TabIndex = 3;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.InitialImage = ((System.Drawing.Image)(resources.GetObject("picLogo.InitialImage")));
            this.picLogo.Location = new System.Drawing.Point(571, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(130, 34);
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // lblServiceStatus
            // 
            this.lblServiceStatus.AutoSize = true;
            this.lblServiceStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServiceStatus.ForeColor = System.Drawing.Color.White;
            this.lblServiceStatus.Location = new System.Drawing.Point(12, 4);
            this.lblServiceStatus.Name = "lblServiceStatus";
            this.lblServiceStatus.Size = new System.Drawing.Size(138, 24);
            this.lblServiceStatus.TabIndex = 0;
            this.lblServiceStatus.Text = "Service Status: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCBWMins);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.numUpDwn_CBWInterval);
            this.groupBox1.Controls.Add(this.chkCBW_Enabled);
            this.groupBox1.Controls.Add(this.txtPort);
            this.groupBox1.Controls.Add(this.txtPassword);
            this.groupBox1.Controls.Add(this.txtIPaddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(243, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 233);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Control By Web Temperature Module";
            // 
            // lblCBWMins
            // 
            this.lblCBWMins.AutoSize = true;
            this.lblCBWMins.ForeColor = System.Drawing.Color.Teal;
            this.lblCBWMins.Location = new System.Drawing.Point(187, 127);
            this.lblCBWMins.Name = "lblCBWMins";
            this.lblCBWMins.Size = new System.Drawing.Size(22, 13);
            this.lblCBWMins.TabIndex = 10;
            this.lblCBWMins.Text = "- - -";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 126);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Seconds";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(69, 13);
            this.label11.TabIndex = 8;
            this.label11.Text = "Sample Freq:";
            // 
            // numUpDwn_CBWInterval
            // 
            this.numUpDwn_CBWInterval.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDwn_CBWInterval.Location = new System.Drawing.Point(82, 124);
            this.numUpDwn_CBWInterval.Maximum = new decimal(new int[] {
            1800,
            0,
            0,
            0});
            this.numUpDwn_CBWInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numUpDwn_CBWInterval.Name = "numUpDwn_CBWInterval";
            this.numUpDwn_CBWInterval.Size = new System.Drawing.Size(48, 20);
            this.numUpDwn_CBWInterval.TabIndex = 3;
            this.numUpDwn_CBWInterval.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // chkCBW_Enabled
            // 
            this.chkCBW_Enabled.AutoSize = true;
            this.chkCBW_Enabled.Location = new System.Drawing.Point(82, 153);
            this.chkCBW_Enabled.Name = "chkCBW_Enabled";
            this.chkCBW_Enabled.Size = new System.Drawing.Size(65, 17);
            this.chkCBW_Enabled.TabIndex = 4;
            this.chkCBW_Enabled.Text = "Enabled";
            this.chkCBW_Enabled.UseVisualStyleBackColor = true;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(82, 101);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(48, 20);
            this.txtPort.TabIndex = 2;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(82, 78);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(170, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // txtIPaddress
            // 
            this.txtIPaddress.Location = new System.Drawing.Point(82, 55);
            this.txtIPaddress.Name = "txtIPaddress";
            this.txtIPaddress.Size = new System.Drawing.Size(170, 20);
            this.txtIPaddress.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Port:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP Address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAddDevice);
            this.groupBox2.Controls.Add(this.lstDevices);
            this.groupBox2.Location = new System.Drawing.Point(12, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 233);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Available Temperature Devices";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(114, 173);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(66, 31);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // btnAddDevice
            // 
            this.btnAddDevice.Location = new System.Drawing.Point(31, 173);
            this.btnAddDevice.Name = "btnAddDevice";
            this.btnAddDevice.Size = new System.Drawing.Size(66, 31);
            this.btnAddDevice.TabIndex = 1;
            this.btnAddDevice.Text = "Add";
            this.btnAddDevice.UseVisualStyleBackColor = true;
            // 
            // lstDevices
            // 
            this.lstDevices.FormattingEnabled = true;
            this.lstDevices.Location = new System.Drawing.Point(7, 20);
            this.lstDevices.Name = "lstDevices";
            this.lstDevices.Size = new System.Drawing.Size(211, 147);
            this.lstDevices.TabIndex = 0;
            // 
            // btnStopService
            // 
            this.btnStopService.Location = new System.Drawing.Point(536, 92);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(146, 30);
            this.btnStopService.TabIndex = 7;
            this.btnStopService.Text = "Stop Service";
            this.btnStopService.UseVisualStyleBackColor = true;
            this.btnStopService.Click += new System.EventHandler(this.btnStopService_Click);
            // 
            // btnStartService
            // 
            this.btnStartService.Location = new System.Drawing.Point(536, 56);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(146, 30);
            this.btnStartService.TabIndex = 6;
            this.btnStartService.Text = "Start Service";
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(536, 328);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 30);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(536, 283);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(146, 30);
            this.btnOK.TabIndex = 8;
            this.btnOK.Text = "Save";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBrowseLogFilePath);
            this.groupBox4.Controls.Add(this.txtLogFileFullPath);
            this.groupBox4.Location = new System.Drawing.Point(12, 295);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(508, 69);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Temperature Log Fle Folder";
            // 
            // btnBrowseLogFilePath
            // 
            this.btnBrowseLogFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseLogFilePath.Location = new System.Drawing.Point(465, 29);
            this.btnBrowseLogFilePath.Name = "btnBrowseLogFilePath";
            this.btnBrowseLogFilePath.Size = new System.Drawing.Size(24, 24);
            this.btnBrowseLogFilePath.TabIndex = 1;
            this.btnBrowseLogFilePath.Text = "...";
            this.btnBrowseLogFilePath.UseVisualStyleBackColor = true;
            this.btnBrowseLogFilePath.Click += new System.EventHandler(this.btnBrowseLogFilePath_Click);
            // 
            // txtLogFileFullPath
            // 
            this.txtLogFileFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogFileFullPath.Location = new System.Drawing.Point(14, 30);
            this.txtLogFileFullPath.Name = "txtLogFileFullPath";
            this.txtLogFileFullPath.Size = new System.Drawing.Size(445, 20);
            this.txtLogFileFullPath.TabIndex = 0;
            // 
            // tmrServiceCheckStatus
            // 
            this.tmrServiceCheckStatus.Interval = 5000;
            this.tmrServiceCheckStatus.Tick += new System.EventHandler(this.tmrServiceCheckStatus_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 380);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnStopService);
            this.Controls.Add(this.btnStartService);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pnlStatus);
            this.Name = "frmMain";
            this.Text = "Multi Blower Temperature Service Manager...";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pnlStatus.ResumeLayout(false);
            this.pnlStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDwn_CBWInterval)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlStatus;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Label lblServiceStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCBWMins;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numUpDwn_CBWInterval;
        private System.Windows.Forms.CheckBox chkCBW_Enabled;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtIPaddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAddDevice;
        private System.Windows.Forms.ListBox lstDevices;
        private System.Windows.Forms.Button btnStopService;
        private System.Windows.Forms.Button btnStartService;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBrowseLogFilePath;
        private System.Windows.Forms.TextBox txtLogFileFullPath;
        private System.Windows.Forms.Timer tmrServiceCheckStatus;
    }
}

