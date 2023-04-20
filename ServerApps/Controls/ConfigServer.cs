using SuperSimpleTcp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerApps.Controls
{
    public partial class ConfigServer : Form
    {
        public ConfigServer()
        {
            InitializeComponent();
        }
        private void LockedButtons()
        {
            btnCreateAcc.Enabled = false;
            btnStop.Enabled = false;
            btnViewMessage.Enabled = false;
            btnViewReported.Enabled = false;
        }
        private void ConfigServer_Load(object sender, EventArgs e)
        {
            LockedButtons();
            
        }
        private static SimpleTcpServer server;
        private string connectionString;
        private int CountCharOfString(string str,char ch)
        {
            int count = 0;
            foreach(char c in str)
            {
                if(c == ch)
                    count++;
            }
            return count;
        }
        private bool IsValidHost(string host)
        {
            IPAddress outHost;
            if (string.IsNullOrEmpty(host) || host.Contains(" ") || !host.Contains(".") || !IPAddress.TryParse(host, out outHost))
                return false;
            return true;
        }
        private bool IsValidPortNum(string port)
        {
            int result = 1000;
            if (!int.TryParse(port, out result) || string.IsNullOrEmpty(port)) return false;
            int portNum = Convert.ToInt32(port);
            if (portNum < 1000 || portNum > 9999) return false; 
            return true;
        }
        private bool IsValidStringConnection()
        {
            if (string.IsNullOrEmpty(txtDbName.Text) || string.IsNullOrEmpty(txtDbPassword.Text) || string.IsNullOrEmpty(txtDbServer.Text) || string.IsNullOrEmpty(txtDbUsername.Text)) return false;
            return true;
        }
        private void btnViewPass_Click(object sender, EventArgs e)
        {
            txtDbPassword.UseSystemPasswordChar = !txtDbPassword.UseSystemPasswordChar;
        }
        private void UnlockButtons()
        {
            btnCreateAcc.Enabled = true;
            btnStop.Enabled = true;
            btnViewMessage.Enabled = true;
            btnViewReported.Enabled = true;
        }
        private void btnClearAll_Click(object sender, EventArgs e)
        {           
            txtDbName.Text = "";
            txtDbPassword.Text = "";
            txtDbServer.Text = "";
            txtDbUsername.Text = "";
            txtIp.Text = "";
            txtPortNum.Text = "";
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (IsValidHost(txtIp.Text) && IsValidPortNum(txtPortNum.Text) && IsValidStringConnection())
            {
                connectionString = "Data Source=" + txtDbServer.Text + ";Initial Catalog=" + txtDbName.Text + ";User ID=" + txtDbUsername.Text + ";Password=" + txtDbPassword.Text;
                //MessageBox.Show(connectionString, "Thông báo!");
                btnStart.Enabled = false;
                txtDbName.Enabled = false;
                txtDbPassword.Enabled = false;
                txtDbServer.Enabled = false;
                txtDbUsername.Enabled = false;
                txtIp.Enabled = false;
                txtPortNum.Enabled = false;
                UnlockButtons();
                server = new SimpleTcpServer(txtIp.Text, Convert.ToInt32(txtPortNum.Text));
                try
                {
                    server.Start();

                }
                catch (Exception)
                {
                    MessageBox.Show("Ấn Stop và kiểm tra lại các thông tin", "Server can't start!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                

            }
            else
            {
                MessageBox.Show("Kiểm tra lại các trường dữ liệu điền vào! Lưu ý:\r\n1/ IP phải tồn tại 3 ký tự '.' và trước các ký tự . phải từ 1-254\r\n2/ Port number phải là số nguyên từ 1000-9999\r\n3/ Các trường dữ liệu không được bỏ trống", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnStop_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateAcc_Click(object sender, EventArgs e)
        {

        }

        private void btnViewReported_Click(object sender, EventArgs e)
        {

        }

        private void btnViewMessage_Click(object sender, EventArgs e)
        {

        }

    }
}
