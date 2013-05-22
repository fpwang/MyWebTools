using MyWebTools.AutoSign.Properties;

namespace MyWebTools.AutoSign
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTaskManage = new System.Windows.Forms.TabPage();
            this.splitContainerTaskManage = new System.Windows.Forms.SplitContainer();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.richTextBoxTaskCode = new System.Windows.Forms.RichTextBox();
            this.panelTaskTime = new System.Windows.Forms.Panel();
            this.tabPageExecute = new System.Windows.Forms.TabPage();
            this.tabPageConfig = new System.Windows.Forms.TabPage();
            this.contextMenuStripAutoSign.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageTaskManage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTaskManage)).BeginInit();
            this.splitContainerTaskManage.Panel1.SuspendLayout();
            this.splitContainerTaskManage.Panel2.SuspendLayout();
            this.splitContainerTaskManage.SuspendLayout();
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
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageTaskManage);
            this.tabControlMain.Controls.Add(this.tabPageExecute);
            this.tabControlMain.Controls.Add(this.tabPageConfig);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(641, 562);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageTaskManage
            // 
            this.tabPageTaskManage.Controls.Add(this.splitContainerTaskManage);
            this.tabPageTaskManage.Location = new System.Drawing.Point(4, 22);
            this.tabPageTaskManage.Name = "tabPageTaskManage";
            this.tabPageTaskManage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTaskManage.Size = new System.Drawing.Size(633, 536);
            this.tabPageTaskManage.TabIndex = 0;
            this.tabPageTaskManage.Text = "任务";
            this.tabPageTaskManage.UseVisualStyleBackColor = true;
            // 
            // splitContainerTaskManage
            // 
            this.splitContainerTaskManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerTaskManage.IsSplitterFixed = true;
            this.splitContainerTaskManage.Location = new System.Drawing.Point(3, 3);
            this.splitContainerTaskManage.Name = "splitContainerTaskManage";
            // 
            // splitContainerTaskManage.Panel1
            // 
            this.splitContainerTaskManage.Panel1.Controls.Add(this.listBoxTasks);
            // 
            // splitContainerTaskManage.Panel2
            // 
            this.splitContainerTaskManage.Panel2.Controls.Add(this.richTextBoxTaskCode);
            this.splitContainerTaskManage.Panel2.Controls.Add(this.panelTaskTime);
            this.splitContainerTaskManage.Size = new System.Drawing.Size(627, 530);
            this.splitContainerTaskManage.SplitterDistance = 209;
            this.splitContainerTaskManage.TabIndex = 0;
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 12;
            this.listBoxTasks.Location = new System.Drawing.Point(0, 0);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(209, 530);
            this.listBoxTasks.TabIndex = 0;
            // 
            // richTextBoxTaskCode
            // 
            this.richTextBoxTaskCode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxTaskCode.Location = new System.Drawing.Point(0, 80);
            this.richTextBoxTaskCode.Name = "richTextBoxTaskCode";
            this.richTextBoxTaskCode.Size = new System.Drawing.Size(414, 450);
            this.richTextBoxTaskCode.TabIndex = 1;
            this.richTextBoxTaskCode.Text = "";
            // 
            // panelTaskTime
            // 
            this.panelTaskTime.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTaskTime.Location = new System.Drawing.Point(0, 0);
            this.panelTaskTime.Name = "panelTaskTime";
            this.panelTaskTime.Size = new System.Drawing.Size(414, 80);
            this.panelTaskTime.TabIndex = 0;
            // 
            // tabPageExecute
            // 
            this.tabPageExecute.Location = new System.Drawing.Point(4, 22);
            this.tabPageExecute.Name = "tabPageExecute";
            this.tabPageExecute.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageExecute.Size = new System.Drawing.Size(633, 536);
            this.tabPageExecute.TabIndex = 1;
            this.tabPageExecute.Text = "运行";
            this.tabPageExecute.UseVisualStyleBackColor = true;
            // 
            // tabPageConfig
            // 
            this.tabPageConfig.Location = new System.Drawing.Point(4, 22);
            this.tabPageConfig.Name = "tabPageConfig";
            this.tabPageConfig.Size = new System.Drawing.Size(633, 536);
            this.tabPageConfig.TabIndex = 2;
            this.tabPageConfig.Text = "配置";
            this.tabPageConfig.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 562);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormMain";
            this.Text = "AutoSign自动签到工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.SizeChanged += new System.EventHandler(this.FormMain_SizeChanged);
            this.contextMenuStripAutoSign.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTaskManage.ResumeLayout(false);
            this.splitContainerTaskManage.Panel1.ResumeLayout(false);
            this.splitContainerTaskManage.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerTaskManage)).EndInit();
            this.splitContainerTaskManage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIconAutoSign;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripAutoSign;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemShowHideForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTaskManage;
        private System.Windows.Forms.TabPage tabPageExecute;
        private System.Windows.Forms.TabPage tabPageConfig;
        private System.Windows.Forms.SplitContainer splitContainerTaskManage;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.RichTextBox richTextBoxTaskCode;
        private System.Windows.Forms.Panel panelTaskTime;
    }
}

