namespace ServerApps.Controls
{
    partial class ConfigServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.txtPortNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnViewPass = new System.Windows.Forms.Button();
            this.txtDbPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDbUsername = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDbName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDbServer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnClearAll = new System.Windows.Forms.Button();
            this.btnViewMessage = new System.Windows.Forms.Button();
            this.btnViewReported = new System.Windows.Forms.Button();
            this.btnCreateAcc = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Config Server";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP or Host";
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(132, 49);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(196, 26);
            this.txtIp.TabIndex = 2;
            // 
            // txtPortNum
            // 
            this.txtPortNum.Location = new System.Drawing.Point(132, 81);
            this.txtPortNum.Name = "txtPortNum";
            this.txtPortNum.Size = new System.Drawing.Size(196, 26);
            this.txtPortNum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Port number";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPortNum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtIp);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 200);
            this.panel1.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnViewPass);
            this.panel2.Controls.Add(this.txtDbPassword);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtDbUsername);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txtDbName);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtDbServer);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(365, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(347, 200);
            this.panel2.TabIndex = 6;
            // 
            // btnViewPass
            // 
            this.btnViewPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewPass.Location = new System.Drawing.Point(245, 170);
            this.btnViewPass.Name = "btnViewPass";
            this.btnViewPass.Size = new System.Drawing.Size(97, 26);
            this.btnViewPass.TabIndex = 9;
            this.btnViewPass.Text = "View Pass";
            this.btnViewPass.UseVisualStyleBackColor = true;
            this.btnViewPass.Click += new System.EventHandler(this.btnViewPass_Click);
            // 
            // txtDbPassword
            // 
            this.txtDbPassword.Location = new System.Drawing.Point(110, 142);
            this.txtDbPassword.Name = "txtDbPassword";
            this.txtDbPassword.Size = new System.Drawing.Size(232, 26);
            this.txtDbPassword.TabIndex = 8;
            this.txtDbPassword.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Password";
            // 
            // txtDbUsername
            // 
            this.txtDbUsername.Location = new System.Drawing.Point(110, 110);
            this.txtDbUsername.Name = "txtDbUsername";
            this.txtDbUsername.Size = new System.Drawing.Size(232, 26);
            this.txtDbUsername.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 5;
            this.label8.Text = "Username";
            // 
            // txtDbName
            // 
            this.txtDbName.Location = new System.Drawing.Point(110, 78);
            this.txtDbName.Name = "txtDbName";
            this.txtDbName.Size = new System.Drawing.Size(232, 26);
            this.txtDbName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Db Name";
            // 
            // txtDbServer
            // 
            this.txtDbServer.Location = new System.Drawing.Point(110, 46);
            this.txtDbServer.Name = "txtDbServer";
            this.txtDbServer.Size = new System.Drawing.Size(232, 26);
            this.txtDbServer.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Data Source";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(-1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(347, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "Config Database";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(65, 40);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(152, 35);
            this.btnStart.TabIndex = 7;
            this.btnStart.Text = "Start Server";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnClearAll);
            this.panel3.Controls.Add(this.btnViewMessage);
            this.panel3.Controls.Add(this.btnViewReported);
            this.panel3.Controls.Add(this.btnCreateAcc);
            this.panel3.Controls.Add(this.btnStop);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnStart);
            this.panel3.Location = new System.Drawing.Point(12, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(700, 131);
            this.panel3.TabIndex = 8;
            // 
            // btnClearAll
            // 
            this.btnClearAll.Location = new System.Drawing.Point(419, 81);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(206, 35);
            this.btnClearAll.TabIndex = 13;
            this.btnClearAll.Text = "Clear All Fields";
            this.btnClearAll.UseVisualStyleBackColor = true;
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // btnViewMessage
            // 
            this.btnViewMessage.Location = new System.Drawing.Point(419, 40);
            this.btnViewMessage.Name = "btnViewMessage";
            this.btnViewMessage.Size = new System.Drawing.Size(206, 35);
            this.btnViewMessage.TabIndex = 12;
            this.btnViewMessage.Text = "View Message From Client";
            this.btnViewMessage.UseVisualStyleBackColor = true;
            this.btnViewMessage.Click += new System.EventHandler(this.btnViewMessage_Click);
            // 
            // btnViewReported
            // 
            this.btnViewReported.Location = new System.Drawing.Point(223, 81);
            this.btnViewReported.Name = "btnViewReported";
            this.btnViewReported.Size = new System.Drawing.Size(190, 35);
            this.btnViewReported.TabIndex = 11;
            this.btnViewReported.Text = "View Reported";
            this.btnViewReported.UseVisualStyleBackColor = true;
            this.btnViewReported.Click += new System.EventHandler(this.btnViewReported_Click);
            // 
            // btnCreateAcc
            // 
            this.btnCreateAcc.Location = new System.Drawing.Point(223, 40);
            this.btnCreateAcc.Name = "btnCreateAcc";
            this.btnCreateAcc.Size = new System.Drawing.Size(190, 35);
            this.btnCreateAcc.TabIndex = 10;
            this.btnCreateAcc.Text = "Create Acc For Client";
            this.btnCreateAcc.UseVisualStyleBackColor = true;
            this.btnCreateAcc.Click += new System.EventHandler(this.btnCreateAcc_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(65, 81);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(152, 35);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop Server";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(-1, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(700, 27);
            this.label9.TabIndex = 8;
            this.label9.Text = "Control Server";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ConfigServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 363);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(744, 402);
            this.MinimumSize = new System.Drawing.Size(744, 402);
            this.Name = "ConfigServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Config Server";
            this.Load += new System.EventHandler(this.ConfigServer_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.TextBox txtPortNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtDbPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDbUsername;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDbName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDbServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnClearAll;
        private System.Windows.Forms.Button btnViewMessage;
        private System.Windows.Forms.Button btnViewReported;
        private System.Windows.Forms.Button btnCreateAcc;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnViewPass;
    }
}