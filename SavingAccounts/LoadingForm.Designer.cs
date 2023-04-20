namespace SavingAccounts
{
    partial class LoadingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadingForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.timeLoading = new Bunifu.Framework.UI.BunifuCircleProgressbar();
            this.countTime = new System.Windows.Forms.Timer(this.components);
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 31);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(398, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(31, 199);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(31, 199);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(31, 199);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(367, 31);
            this.panel4.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Transparent;
            this.panel5.Controls.Add(this.timeLoading);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(31, 31);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(367, 168);
            this.panel5.TabIndex = 3;
            // 
            // timeLoading
            // 
            this.timeLoading.animated = false;
            this.timeLoading.animationIterval = 5;
            this.timeLoading.animationSpeed = 3;
            this.timeLoading.BackColor = System.Drawing.Color.Transparent;
            this.timeLoading.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("timeLoading.BackgroundImage")));
            this.timeLoading.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timeLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.timeLoading.ForeColor = System.Drawing.Color.SeaGreen;
            this.timeLoading.LabelVisible = false;
            this.timeLoading.LineProgressThickness = 8;
            this.timeLoading.LineThickness = 5;
            this.timeLoading.Location = new System.Drawing.Point(119, 9);
            this.timeLoading.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.timeLoading.MaxValue = 100;
            this.timeLoading.Name = "timeLoading";
            this.timeLoading.ProgressBackColor = System.Drawing.Color.Transparent;
            this.timeLoading.ProgressColor = System.Drawing.Color.SeaGreen;
            this.timeLoading.Size = new System.Drawing.Size(147, 147);
            this.timeLoading.TabIndex = 0;
            this.timeLoading.Value = 0;
            // 
            // countTime
            // 
            this.countTime.Interval = 5;
            this.countTime.Tick += new System.EventHandler(this.countTime_Tick);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SavingAccounts.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(429, 230);
            this.ControlBox = false;
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoadingForm";
            this.Opacity = 0.5D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.Framework.UI.BunifuCircleProgressbar timeLoading;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer countTime;
    }
}