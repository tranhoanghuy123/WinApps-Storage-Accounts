using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingAccounts
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private int mov;
        private int movX;
        private int movY;   
        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            this.mov = 0;
        }
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            this.mov = 1;
            this.movX = e.X;
            this.movY = e.Y;
          
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoadingForm waitTime = new LoadingForm();
            waitTime.Show();
            waitTime.FormClosed += WaitTime_FormClosed;
        }

        private void WaitTime_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessBox message;
            this.Opacity = 70;
            if (txtUsername.Text == "admin" && txtPassword.Text == "123456a@")
            {
                message = new MessBox("Verify Successfully.", true);
                message.Show();
                message.FormClosed += Message_FormClosed;
            }
            else
            {
                message = new MessBox("Verify Unsuccessfuly.", false);
                message.Show();
            }
        }

        private void Message_FormClosed(object sender, FormClosedEventArgs e)
        {
            Client client = new Client();
            this.Hide();
            client.Show();
        }

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.White;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.ForeColor = Color.Navy;
        }
    }
}
