using ServerApps.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerApps
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "admin" && txtPassword.Text == "QJu4uy5Q6Vb@sgThhG") 
            {
                ConfigServer formConfig = new ConfigServer();
                formConfig.ShowDialog();

            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
