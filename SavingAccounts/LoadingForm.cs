﻿using System;
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
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            timeLoading.Value = 0;
            countTime.Start();
        }

        private void countTime_Tick(object sender, EventArgs e)
        {
            timeLoading.Value++;
            if (timeLoading.Value == 100)
            {
                countTime.Stop();
                this.Close();
            }
        }
    }
}
