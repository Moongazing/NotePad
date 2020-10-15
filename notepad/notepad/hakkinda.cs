using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notepad
{
    public partial class hakkinda : Form
    {
        public hakkinda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hakkinda_Load(object sender, EventArgs e)
        {
            label1.Text=string.Format("Program Adı:{0}",Application.ProductName);
            label2.Text = string.Format("Program Versiyonu:{0}", Application.ProductVersion);
            label3.Text = "Copyright © HP Inc. 2020 Tunahan Ali Öztürk";
        }
    }
}
