﻿using System;
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


        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItemShowHideForm_Click(object sender, EventArgs e)
        {
            this.ShowHideForm();
        }
 
        private void notifyIconAutoSign_Click(object sender, EventArgs e)
        {
            //只在左键单击时响应，右键单击时显示菜单
            if (((System.Windows.Forms.MouseEventArgs)e).Button == MouseButtons.Left)
            {
                this.ShowHideForm();
            }
        }

        private void ShowHideForm()
        {
            if (this.Visible == false)
            {
                this.Visible = true;
                this.Show();

                //将TopMost设置为True以使窗体显示在最前端，然后将其设为false以使其随后不再保持在最前端。
                this.TopMost=true;
                this.TopMost = false;
            }
            else
            {
                this.Visible = false;
                this.Hide();
            }
        }

    }
}
