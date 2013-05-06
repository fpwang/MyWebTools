using AutoSign.Properties;

namespace AutoSign
{
    public partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.notifyIconAutoSign = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStripAutoSign = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemShowHideForm = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripAutoSign.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIconAutoSign
            // 
            this.notifyIconAutoSign.ContextMenuStrip = this.contextMenuStripAutoSign;
            this.notifyIconAutoSign.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIconAutoSign.Icon")));
            this.notifyIconAutoSign.Text = "AutoSign";
            this.notifyIconAutoSign.Visible = true;
            this.notifyIconAutoSign.Click += new System.EventHandler(this.notifyIconAutoSign_Click);
            // 
            // contextMenuStripAutoSign
            // 
            this.contextMenuStripAutoSign.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemShowHideForm,
            this.toolStripSeparator1,
            this.toolStripMenuItemExit});
            this.contextMenuStripAutoSign.Name = "contextMenuStripAutoSign";
            this.contextMenuStripAutoSign.Size = new System.Drawing.Size(154, 54);
            // 
            // toolStripMenuItemShowHideForm
            // 
            this.toolStripMenuItemShowHideForm.Name = "toolStripMenuItemShowHideForm";
            this.toolStripMenuItemShowHideForm.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItemShowHideForm.Text = "显示/隐藏程序";
            this.toolStripMenuItemShowHideForm.Click += new System.EventHandler(this.toolStripMenuItemShowHideForm_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(150, 6);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItemExit.Text = "退出";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 562);
            this.IsMdiContainer = true;
            this.Name = "FormMain";
            this.Text = "AutoSign自动签到工具";
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.contextMenuStripAutoSign.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconAutoSign;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAutoSign;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowHideForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
    }
}

