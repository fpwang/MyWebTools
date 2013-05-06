using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AutoSign
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            this.Visible = false;
            this.Hide();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 显示隐藏主窗体ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.Visible == false)
            {
                this.Visible = true;
                this.Show();
            }
            else
            {
                this.Visible = false;
                this.Hide();
            }
        }
    }
}
