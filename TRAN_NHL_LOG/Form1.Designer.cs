namespace TRAN_NHL_LOG
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.bgWLog = new System.ComponentModel.BackgroundWorker();
            this.CBShowDetail = new System.Windows.Forms.CheckBox();
            this.lbcycleTime = new System.Windows.Forms.Label();
            this.lbPW = new System.Windows.Forms.Label();
            this.tBPW = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbDateTime = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbMCPath = new System.Windows.Forms.Label();
            this.lbPath = new System.Windows.Forms.Label();
            this.lbNProcess = new System.Windows.Forms.Label();
            this.lbProcess = new System.Windows.Forms.Label();
            this.lbNameMC = new System.Windows.Forms.Label();
            this.lbMC = new System.Windows.Forms.Label();
            this.lbNproject = new System.Windows.Forms.Label();
            this.lbProject = new System.Windows.Forms.Label();
            this.bStart = new System.Windows.Forms.Button();
            this.timerLogdata = new System.Windows.Forms.Timer(this.components);
            this.rTBResult = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // bgWLog
            // 
            this.bgWLog.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWLog_DoWork);
            this.bgWLog.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgWLog_RunWorkerCompleted);
            // 
            // CBShowDetail
            // 
            this.CBShowDetail.AutoSize = true;
            this.CBShowDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBShowDetail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CBShowDetail.Location = new System.Drawing.Point(12, 253);
            this.CBShowDetail.Name = "CBShowDetail";
            this.CBShowDetail.Size = new System.Drawing.Size(94, 17);
            this.CBShowDetail.TabIndex = 87;
            this.CBShowDetail.Text = "Show Detail";
            this.CBShowDetail.UseVisualStyleBackColor = true;
            // 
            // lbcycleTime
            // 
            this.lbcycleTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbcycleTime.AutoSize = true;
            this.lbcycleTime.BackColor = System.Drawing.Color.DimGray;
            this.lbcycleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcycleTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbcycleTime.Location = new System.Drawing.Point(711, 107);
            this.lbcycleTime.Name = "lbcycleTime";
            this.lbcycleTime.Size = new System.Drawing.Size(20, 25);
            this.lbcycleTime.TabIndex = 86;
            this.lbcycleTime.Text = "-";
            this.lbcycleTime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPW
            // 
            this.lbPW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbPW.AutoSize = true;
            this.lbPW.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPW.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPW.Location = new System.Drawing.Point(645, 7);
            this.lbPW.Name = "lbPW";
            this.lbPW.Size = new System.Drawing.Size(51, 20);
            this.lbPW.TabIndex = 85;
            this.lbPW.Text = "P/W :";
            // 
            // tBPW
            // 
            this.tBPW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tBPW.Location = new System.Drawing.Point(702, 7);
            this.tBPW.Name = "tBPW";
            this.tBPW.Size = new System.Drawing.Size(117, 20);
            this.tBPW.TabIndex = 84;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.BackColor = System.Drawing.Color.DimGray;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbStatus.Location = new System.Drawing.Point(458, 107);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(20, 25);
            this.lbStatus.TabIndex = 83;
            this.lbStatus.Text = "-";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(760, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 25);
            this.label4.TabIndex = 82;
            this.label4.Text = "Sec.";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(620, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 81;
            this.label2.Text = "Cycle :";
            // 
            // bStop
            // 
            this.bStop.BackColor = System.Drawing.Color.Red;
            this.bStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStop.Location = new System.Drawing.Point(12, 198);
            this.bStop.Name = "bStop";
            this.bStop.Size = new System.Drawing.Size(166, 49);
            this.bStop.TabIndex = 80;
            this.bStop.Text = "Stop Transfer";
            this.bStop.UseVisualStyleBackColor = false;
            this.bStop.Click += new System.EventHandler(this.bStop_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(288, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(531, 20);
            this.label5.TabIndex = 79;
            this.label5.Text = "SIIX EMS(THAILAND) CO.,LTD. V 5.0 DRM UPDATE 10-12-2019";
            // 
            // lbDateTime
            // 
            this.lbDateTime.AutoSize = true;
            this.lbDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbDateTime.Location = new System.Drawing.Point(144, 107);
            this.lbDateTime.Name = "lbDateTime";
            this.lbDateTime.Size = new System.Drawing.Size(20, 25);
            this.lbDateTime.TabIndex = 78;
            this.lbDateTime.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 77;
            this.label3.Text = "Date Time:";
            // 
            // lbMCPath
            // 
            this.lbMCPath.AutoSize = true;
            this.lbMCPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMCPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMCPath.Location = new System.Drawing.Point(188, 82);
            this.lbMCPath.Name = "lbMCPath";
            this.lbMCPath.Size = new System.Drawing.Size(20, 25);
            this.lbMCPath.TabIndex = 76;
            this.lbMCPath.Text = "-";
            // 
            // lbPath
            // 
            this.lbPath.AutoSize = true;
            this.lbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPath.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbPath.Location = new System.Drawing.Point(12, 82);
            this.lbPath.Name = "lbPath";
            this.lbPath.Size = new System.Drawing.Size(170, 25);
            this.lbPath.TabIndex = 75;
            this.lbPath.Text = "Machine Path :";
            // 
            // lbNProcess
            // 
            this.lbNProcess.AutoSize = true;
            this.lbNProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNProcess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNProcess.Location = new System.Drawing.Point(129, 32);
            this.lbNProcess.Name = "lbNProcess";
            this.lbNProcess.Size = new System.Drawing.Size(20, 25);
            this.lbNProcess.TabIndex = 74;
            this.lbNProcess.Text = "-";
            // 
            // lbProcess
            // 
            this.lbProcess.AutoSize = true;
            this.lbProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbProcess.Location = new System.Drawing.Point(12, 32);
            this.lbProcess.Name = "lbProcess";
            this.lbProcess.Size = new System.Drawing.Size(111, 25);
            this.lbProcess.TabIndex = 73;
            this.lbProcess.Text = "Process :";
            // 
            // lbNameMC
            // 
            this.lbNameMC.AutoSize = true;
            this.lbNameMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameMC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNameMC.Location = new System.Drawing.Point(200, 57);
            this.lbNameMC.Name = "lbNameMC";
            this.lbNameMC.Size = new System.Drawing.Size(20, 25);
            this.lbNameMC.TabIndex = 72;
            this.lbNameMC.Text = "-";
            // 
            // lbMC
            // 
            this.lbMC.AutoSize = true;
            this.lbMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbMC.Location = new System.Drawing.Point(12, 57);
            this.lbMC.Name = "lbMC";
            this.lbMC.Size = new System.Drawing.Size(182, 25);
            this.lbMC.TabIndex = 71;
            this.lbMC.Text = "Machine Name :";
            // 
            // lbNproject
            // 
            this.lbNproject.AutoSize = true;
            this.lbNproject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNproject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbNproject.Location = new System.Drawing.Point(118, 7);
            this.lbNproject.Name = "lbNproject";
            this.lbNproject.Size = new System.Drawing.Size(20, 25);
            this.lbNproject.TabIndex = 70;
            this.lbNproject.Text = "-";
            // 
            // lbProject
            // 
            this.lbProject.AutoSize = true;
            this.lbProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProject.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbProject.Location = new System.Drawing.Point(12, 7);
            this.lbProject.Name = "lbProject";
            this.lbProject.Size = new System.Drawing.Size(95, 25);
            this.lbProject.TabIndex = 69;
            this.lbProject.Text = "Server :";
            // 
            // bStart
            // 
            this.bStart.BackColor = System.Drawing.Color.LightGreen;
            this.bStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bStart.Location = new System.Drawing.Point(12, 143);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(166, 49);
            this.bStart.TabIndex = 68;
            this.bStart.Text = "Start Transfer";
            this.bStart.UseVisualStyleBackColor = false;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // timerLogdata
            // 
            this.timerLogdata.Tick += new System.EventHandler(this.timerLogdata_Tick);
            // 
            // rTBResult
            // 
            this.rTBResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBResult.Location = new System.Drawing.Point(184, 143);
            this.rTBResult.Name = "rTBResult";
            this.rTBResult.Size = new System.Drawing.Size(635, 236);
            this.rTBResult.TabIndex = 67;
            this.rTBResult.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(831, 408);
            this.Controls.Add(this.CBShowDetail);
            this.Controls.Add(this.lbcycleTime);
            this.Controls.Add(this.lbPW);
            this.Controls.Add(this.tBPW);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bStop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbMCPath);
            this.Controls.Add(this.lbPath);
            this.Controls.Add(this.lbNProcess);
            this.Controls.Add(this.lbProcess);
            this.Controls.Add(this.lbNameMC);
            this.Controls.Add(this.lbMC);
            this.Controls.Add(this.lbNproject);
            this.Controls.Add(this.lbProject);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.rTBResult);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Traceability Transfer NHL Log Data";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker bgWLog;
        private System.Windows.Forms.CheckBox CBShowDetail;
        private System.Windows.Forms.Label lbcycleTime;
        private System.Windows.Forms.Label lbPW;
        private System.Windows.Forms.TextBox tBPW;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bStop;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbDateTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbMCPath;
        private System.Windows.Forms.Label lbPath;
        private System.Windows.Forms.Label lbNProcess;
        private System.Windows.Forms.Label lbProcess;
        private System.Windows.Forms.Label lbNameMC;
        private System.Windows.Forms.Label lbMC;
        private System.Windows.Forms.Label lbNproject;
        private System.Windows.Forms.Label lbProject;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Timer timerLogdata;
        private System.Windows.Forms.RichTextBox rTBResult;
    }
}

