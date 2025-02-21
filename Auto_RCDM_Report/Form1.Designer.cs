
namespace Auto_RCDM_Report
{
    partial class frmAuto_RCDM_Reports
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
            this.txtRunPath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtReadINI_DB = new System.Windows.Forms.TextBox();
            this.txtReadINI_Server = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btnGen = new System.Windows.Forms.Button();
            this.dpDisplayReportDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.dpRunReportDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtPathReport = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFormatReportDate = new System.Windows.Forms.TextBox();
            this.btnConnecting = new System.Windows.Forms.Button();
            this.txtDBServer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFixPathReport = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPathLog = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtRunPath
            // 
            this.txtRunPath.Location = new System.Drawing.Point(113, 251);
            this.txtRunPath.Multiline = true;
            this.txtRunPath.Name = "txtRunPath";
            this.txtRunPath.ReadOnly = true;
            this.txtRunPath.Size = new System.Drawing.Size(298, 139);
            this.txtRunPath.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 251);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 45;
            this.label10.Text = "Run Path";
            // 
            // txtReadINI_DB
            // 
            this.txtReadINI_DB.Location = new System.Drawing.Point(531, 287);
            this.txtReadINI_DB.Name = "txtReadINI_DB";
            this.txtReadINI_DB.ReadOnly = true;
            this.txtReadINI_DB.Size = new System.Drawing.Size(228, 22);
            this.txtReadINI_DB.TabIndex = 44;
            // 
            // txtReadINI_Server
            // 
            this.txtReadINI_Server.Location = new System.Drawing.Point(531, 251);
            this.txtReadINI_Server.Name = "txtReadINI_Server";
            this.txtReadINI_Server.ReadOnly = true;
            this.txtReadINI_Server.Size = new System.Drawing.Size(228, 22);
            this.txtReadINI_Server.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(449, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "Server";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(449, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 41;
            this.label1.Text = "DB";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.progressBar1);
            this.groupBox2.Controls.Add(this.btnGen);
            this.groupBox2.Controls.Add(this.dpDisplayReportDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dpRunReportDate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(21, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 222);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Run Report";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.Lime;
            this.progressBar1.Location = new System.Drawing.Point(14, 178);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(376, 23);
            this.progressBar1.TabIndex = 18;
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(130, 109);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(137, 53);
            this.btnGen.TabIndex = 10;
            this.btnGen.Text = "Manual GenReportFile";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // dpDisplayReportDate
            // 
            this.dpDisplayReportDate.Location = new System.Drawing.Point(148, 72);
            this.dpDisplayReportDate.Name = "dpDisplayReportDate";
            this.dpDisplayReportDate.Size = new System.Drawing.Size(200, 22);
            this.dpDisplayReportDate.TabIndex = 17;
            this.dpDisplayReportDate.ValueChanged += new System.EventHandler(this.dpDisplayReportDate_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "Run ณวันที่";
            // 
            // dpRunReportDate
            // 
            this.dpRunReportDate.Enabled = false;
            this.dpRunReportDate.Location = new System.Drawing.Point(148, 39);
            this.dpRunReportDate.Name = "dpRunReportDate";
            this.dpRunReportDate.Size = new System.Drawing.Size(200, 22);
            this.dpRunReportDate.TabIndex = 16;
            this.dpRunReportDate.ValueChanged += new System.EventHandler(this.dpRunReportDate_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "แสดงรายงานของวันที่";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(228, 22);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "C:\\fromtandem\\TLFTEXT4.txt";
            // 
            // txtPathReport
            // 
            this.txtPathReport.Location = new System.Drawing.Point(148, 59);
            this.txtPathReport.Name = "txtPathReport";
            this.txtPathReport.ReadOnly = true;
            this.txtPathReport.Size = new System.Drawing.Size(228, 22);
            this.txtPathReport.TabIndex = 11;
            this.txtPathReport.Text = "D:\\ReportFiles\\";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "Report File Path";
            // 
            // txtFormatReportDate
            // 
            this.txtFormatReportDate.Location = new System.Drawing.Point(170, 186);
            this.txtFormatReportDate.Name = "txtFormatReportDate";
            this.txtFormatReportDate.ReadOnly = true;
            this.txtFormatReportDate.Size = new System.Drawing.Size(100, 22);
            this.txtFormatReportDate.TabIndex = 26;
            this.txtFormatReportDate.Visible = false;
            // 
            // btnConnecting
            // 
            this.btnConnecting.Location = new System.Drawing.Point(14, 154);
            this.btnConnecting.Name = "btnConnecting";
            this.btnConnecting.Size = new System.Drawing.Size(128, 47);
            this.btnConnecting.TabIndex = 23;
            this.btnConnecting.Text = "Test Connecting Database";
            this.btnConnecting.UseVisualStyleBackColor = true;
            this.btnConnecting.Click += new System.EventHandler(this.btnConnecting_Click);
            // 
            // txtDBServer
            // 
            this.txtDBServer.Location = new System.Drawing.Point(148, 128);
            this.txtDBServer.Multiline = true;
            this.txtDBServer.Name = "txtDBServer";
            this.txtDBServer.ReadOnly = true;
            this.txtDBServer.Size = new System.Drawing.Size(228, 52);
            this.txtDBServer.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "DB Server ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "LTF Text File Path";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtPathLog);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.txtFixPathReport);
            this.groupBox4.Controls.Add(this.txtFormatReportDate);
            this.groupBox4.Controls.Add(this.btnConnecting);
            this.groupBox4.Controls.Add(this.txtDBServer);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtPathReport);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.textBox1);
            this.groupBox4.Location = new System.Drawing.Point(423, 11);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(396, 222);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Default Master Config";
            // 
            // txtFixPathReport
            // 
            this.txtFixPathReport.Location = new System.Drawing.Point(276, 186);
            this.txtFixPathReport.Name = "txtFixPathReport";
            this.txtFixPathReport.ReadOnly = true;
            this.txtFixPathReport.Size = new System.Drawing.Size(100, 22);
            this.txtFixPathReport.TabIndex = 27;
            this.txtFixPathReport.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 28;
            this.label6.Text = "Log File Path";
            // 
            // txtPathLog
            // 
            this.txtPathLog.Location = new System.Drawing.Point(148, 92);
            this.txtPathLog.Name = "txtPathLog";
            this.txtPathLog.ReadOnly = true;
            this.txtPathLog.Size = new System.Drawing.Size(228, 22);
            this.txtPathLog.TabIndex = 29;
            this.txtPathLog.Text = "D:\\Logs\\AMLO_Reports";
            // 
            // frmAuto_RCDM_Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 405);
            this.Controls.Add(this.txtRunPath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtReadINI_DB);
            this.Controls.Add(this.txtReadINI_Server);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Name = "frmAuto_RCDM_Reports";
            this.Text = "Auto RCDM Report";
            this.Load += new System.EventHandler(this.frmAuto_RCDM_Reports_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRunPath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtReadINI_DB;
        private System.Windows.Forms.TextBox txtReadINI_Server;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.DateTimePicker dpDisplayReportDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dpRunReportDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPathReport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFormatReportDate;
        private System.Windows.Forms.Button btnConnecting;
        private System.Windows.Forms.TextBox txtDBServer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtFixPathReport;
        private System.Windows.Forms.TextBox txtPathLog;
        private System.Windows.Forms.Label label6;
    }
}

