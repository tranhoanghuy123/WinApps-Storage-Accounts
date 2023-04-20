using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SavingAccounts
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            foreach(var process in Process.GetProcessesByName("SavingAccount"))
            {
                process.Kill();
            }
        }
        private int mov;
        private int movX;
        private int movY;   
        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void Header_MouseUp(object sender, MouseEventArgs e)
        {
            this.mov = 0;
        }

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            this.mov = 1;
            this.movX = e.X;
            this.movY = e.Y;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAccountsSaved_Click(object sender, EventArgs e)
        {

        }
    }
}
