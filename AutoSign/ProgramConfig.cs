using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace MyWebTools.AutoSign
{
    /// <summary>
    /// 应用程序配置参数
    /// </summary>
    public class ProgramConfig
    {

        /// <summary>
        /// 主窗体参数
        /// </summary>
        private MainFormConfig m_MainForm = new MainFormConfig();
        /// <summary>
        /// 配置文件名
        /// </summary>
        private string m_ConfigFileName;
        /// <summary>
        /// 标记是否发生需要存储的改变。
        /// </summary>
        private bool m_Changed = false;


        public ProgramConfig()
        {
            //注册子配置对象改变事件处理函数
            this.m_MainForm.FormConfigChanged += MainForm_FormConfigChanged;
        }

        private void MainForm_FormConfigChanged(object sender, ConfigChangeEventArgs e)
        {
            //主窗体配置参数改变时，标记参数发生改变，需进行保存
            this.Changed=true;
        }

        /// <summary>
        /// 主窗体参数
        /// </summary>
        public MainFormConfig MainForm
        {
            get
            {
                return m_MainForm;
            }
            set
            {
                m_MainForm = value;
            }
        }

        /// <summary>
        /// 配置文件名
        /// </summary>
        [JsonIgnore]
        public string ConfigFileName
        {
            get
            {
                return m_ConfigFileName;
            }
            set
            {
                m_ConfigFileName = value;
            }
        }

        /// <summary>
        /// 标记是否发生需要存储的改变。
        /// </summary>
        [JsonIgnore]
        public bool Changed
        {
            get
            {
                return m_Changed;
            }
            set
            {
                m_Changed = value;
            }
        }
        /// <summary>
        /// 从配置文件中读取配置参数
        /// </summary>
        /// <param name="ConfigFileName">配置文件名</param>
        public void Load(string configFileName)
        {
            this.ConfigFileName = configFileName;
            this.Load();
        }

        /// <summary>
        /// 从配置文件中读取配置参数，
        /// </summary>
        public void Load()
        {
            ProgramConfig cfg=null;
            if (this.ConfigFileName != null && File.Exists(this.ConfigFileName))
            {
                using (StreamReader r = new StreamReader(this.ConfigFileName))
                {
                    string json = r.ReadToEnd();

                    JsonSerializerSettings setting = new JsonSerializerSettings();
                    setting.MissingMemberHandling = MissingMemberHandling.Ignore;
                    cfg = JsonConvert.DeserializeObject<ProgramConfig>(json, setting);
                }
            }
            if (cfg != null)
            {
                //将读取的配置参数从临时变量复制到正式的配置变量中
                this.MainForm.Copy(cfg.MainForm);
            }
            this.Changed = false;
        }

        /// <summary>
        /// 将配置参数存储到配置文件中
        /// </summary>
        public void Save()
        {
            if (this.Changed)
            {
                bool retry = false;
                do
                {
                    try
                    {
                        string j = Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
                        string path=Path.GetDirectoryName(this.ConfigFileName);
                        if (!Directory.Exists(path))
                        {
                            Directory.CreateDirectory(path);
                        }
                        using (StreamWriter w = new StreamWriter(this.ConfigFileName))
                        {
                            w.Write(j);
                            w.Close();
                            this.Changed = false;
                            retry = false;
                        }
                    }
                    catch (IOException)
                    {
                        string s = Regex.Replace(Properties.Resources.strSaveFileErrorMessage, "{filename}", ConfigFileName);//?
                        DialogResult dr=MessageBox.Show(s, Properties.Resources.strFileErrorMessageBoxTitle, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                        retry=(dr == DialogResult.Retry);
                    }
                } while (retry);

            }
        }

        /// <summary>
        /// 将配置参数存储到配置文件中
        /// </summary>
        /// <param name="ConfigFileName">配置文件名</param>
        public void Save(String ConfigFileName)
        {
            this.ConfigFileName = ConfigFileName;
            this.Save();
        }
    }
}
