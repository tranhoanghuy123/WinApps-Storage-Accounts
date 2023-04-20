using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SavingAccounts
{
    public partial class MessBox : Form
    {
        public MessBox()
        {
            InitializeComponent();
        }
        private  bool status;
        private static bool isOk = true;

        public static bool IsOk { get => isOk; set => isOk = value; }

        public MessBox(string mess,bool status)
        {
            InitializeComponent();
            MessContent.Text = mess;
            if(!status)
            {
                icon_delay.Interval = 2000;
            }
            this.status = status;
            this.icon.Image = status ? Properties.Resources.Success : Properties.Resources.error;

        }
        private void bunifuFormFadeTransition1_TransitionEnd(object sender, EventArgs e)
        {
            icon_delay.Start();
            icon.Enabled = true;
        }

        private void icon_delay_Tick(object sender, EventArgs e)
        {
            icon.Enabled = false;
            icon_delay.Stop();
            btnConfirm.Enabled = true;
        }

        private void MessBox_Load_1(object sender, EventArgs e)
        {
            bunifuFormFadeTransition1.ShowAsyc(this);
            btnConfirm.Enabled = false;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            isOk = false;
            this.Close();
        }
    }
}
