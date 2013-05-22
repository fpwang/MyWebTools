using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyWebTools.AutoSign
{
    public partial class FormMain : Form
    {
		/// <summary>
		/// 程序配置数据
		/// </summary>
		private ProgramConfig m_Config=new ProgramConfig();

        public FormMain()
        {
            InitializeComponent();
        }

        #region 托盘图标处理相关程序
        private void FormMain_Shown(object sender, EventArgs e)
        {
            //第一次显示窗体时，将其隐藏，
            this.Visible = false;
            this.Hide();

            //设置配置文件路径，读取配置文件,并
            this.Config.ConfigFileName=System.Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)+ Properties.Resources.strConfigFileName;
            this.Config.Load();
            this.ApplyConfig();
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
        #endregion 托盘图标处理相关程序

        #region 程序配置参数处理相关程序
        /// <summary>
		/// 程序配置数据
		/// </summary>
		public ProgramConfig Config{
			get{
				return m_Config;
			}
			set{
				m_Config = value;
			}
		}

        private void ApplyConfig()
        {
            if (this.Config != null)
            {
                if (this.Config.MainForm != null)
                {
                    if(this.Config.MainForm.Size!=null)
                    {
                        if (this.Config.MainForm.Size.Height == 0)
                        {
                            this.Config.MainForm.Size = this.Size;
                        }
                        else
                        {
                            this.Size = this.Config.MainForm.Size;
                        }
                    }

                    if (this.Config.MainForm.MaximizeOnStart)
                    {
                        this.WindowState = FormWindowState.Maximized;
                    }

                }
            }
        }

        private void FormMain_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.Config.MainForm.Size = this.Size;
            }          
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.Config.Changed)
            {
                this.Config.Save();
            }
        }
        #endregion 程序参数处理相关程序

    }
}
