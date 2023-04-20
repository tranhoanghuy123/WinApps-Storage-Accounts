namespace SavingAccounts
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.categoryAccount = new Bunifu.Framework.UI.BunifuDropdown();
            this.txtPassword = new Quiz_Project.LoginControl();
            this.txtUsername = new Quiz_Project.LoginControl();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new Quiz_Project.LoginControl();
            this.btnSave = new Quiz_Project.CustomButton();
            this.btnViewAccountsSaved = new Quiz_Project.CustomButton();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Header.Controls.Add(this.pictureBox1);
            this.Header.Controls.Add(this.btnClose);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(670, 25);
            this.Header.TabIndex = 0;
            this.Header.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
            this.Header.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Header_MouseMove);
            this.Header.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Header_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Image = global::SavingAccounts.Properties.Resources.CloseBtn;
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(631, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 25);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::SavingAccounts.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.btnViewAccountsSaved);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.categoryAccount);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtUsername);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(670, 337);
            this.panel1.TabIndex = 1;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Malgun Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Navy;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(670, 68);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "SAVING ACCOUNTS";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật khẩu:";
            // 
            // categoryAccount
            // 
            this.categoryAccount.BackColor = System.Drawing.Color.Transparent;
            this.categoryAccount.BorderRadius = 3;
            this.categoryAccount.DisabledColor = System.Drawing.Color.Gray;
            this.categoryAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.categoryAccount.Items = new string[] {
        "Facebook",
        "Email",
        "Microsoft",
        "Youtube",
        "Riot",
        "Steam",
        "Zalo",
        "What\'s App",
        "Instagram",
        "Bank"};
            this.categoryAccount.Location = new System.Drawing.Point(388, 108);
            this.categoryAccount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryAccount.Name = "categoryAccount";
            this.categoryAccount.NomalColor = System.Drawing.Color.DarkCyan;
            this.categoryAccount.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.categoryAccount.selectedIndex = -1;
            this.categoryAccount.Size = new System.Drawing.Size(269, 32);
            this.categoryAccount.TabIndex = 5;
            this.categoryAccount.Tag = "";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtPassword.BoderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtPassword.BoderFocusColor = System.Drawing.Color.HotPink;
            this.txtPassword.BoderSize = 2;
            this.txtPassword.BorderRadius = 0;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.Location = new System.Drawing.Point(13, 178);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtPassword.PasswordChar = false;
            this.txtPassword.PlaceholderColor = System.Drawing.SystemColors.ControlText;
            this.txtPassword.PlaceholderText = "Password ...";
            this.txtPassword.Size = new System.Drawing.Size(259, 32);
            this.txtPassword.TabIndex = 3;
            this.txtPassword.UderlinedStyle = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtUsername.BoderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtUsername.BoderFocusColor = System.Drawing.Color.HotPink;
            this.txtUsername.BoderSize = 2;
            this.txtUsername.BorderRadius = 0;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Location = new System.Drawing.Point(13, 108);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtUsername.PasswordChar = false;
            this.txtUsername.PlaceholderColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.PlaceholderText = "Username ...";
            this.txtUsername.Size = new System.Drawing.Size(259, 32);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.UderlinedStyle = true;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(384, 83);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(112, 20);
            this.bunifuCustomLabel2.TabIndex = 6;
            this.bunifuCustomLabel2.Text = "Loại tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Mô tả:";
            // 
            // txtDescription
            // 
            this.txtDescription.BackColor = System.Drawing.Color.PaleTurquoise;
            this.txtDescription.BoderColor = System.Drawing.Color.MediumSeaGreen;
            this.txtDescription.BoderFocusColor = System.Drawing.Color.HotPink;
            this.txtDescription.BoderSize = 2;
            this.txtDescription.BorderRadius = 0;
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDescription.Location = new System.Drawing.Point(388, 178);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Multiline = false;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDescription.PasswordChar = false;
            this.txtDescription.PlaceholderColor = System.Drawing.SystemColors.ControlText;
            this.txtDescription.PlaceholderText = "Có thể ghi hoặc không";
            this.txtDescription.Size = new System.Drawing.Size(269, 32);
            this.txtDescription.TabIndex = 7;
            this.txtDescription.UderlinedStyle = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderSize = 0;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.ForeColor = System.Drawing.Color.Navy;
            this.btnSave.Location = new System.Drawing.Point(391, 248);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 40);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Lưu tài khoản";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnViewAccountsSaved
            // 
            this.btnViewAccountsSaved.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnViewAccountsSaved.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnViewAccountsSaved.BorderRadius = 5;
            this.btnViewAccountsSaved.BorderSize = 0;
            this.btnViewAccountsSaved.FlatAppearance.BorderSize = 0;
            this.btnViewAccountsSaved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewAccountsSaved.ForeColor = System.Drawing.Color.Navy;
            this.btnViewAccountsSaved.Location = new System.Drawing.Point(103, 248);
            this.btnViewAccountsSaved.Name = "btnViewAccountsSaved";
            this.btnViewAccountsSaved.Size = new System.Drawing.Size(169, 40);
            this.btnViewAccountsSaved.TabIndex = 10;
            this.btnViewAccountsSaved.Text = "Xem tài khoản đã lưu";
            this.btnViewAccountsSaved.UseVisualStyleBackColor = false;
            this.btnViewAccountsSaved.Click += new System.EventHandler(this.btnViewAccountsSaved_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SavingAccounts.Properties.Resources.main;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(670, 362);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Header);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.Header.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel Header;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Quiz_Project.LoginControl txtUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDropdown categoryAccount;
        private System.Windows.Forms.Label label2;
        private Quiz_Project.LoginControl txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Quiz_Project.LoginControl txtDescription;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Quiz_Project.CustomButton btnSave;
        private Quiz_Project.CustomButton btnViewAccountsSaved;
    }
}