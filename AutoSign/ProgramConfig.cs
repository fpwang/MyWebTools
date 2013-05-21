using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Text.RegularExpressions;

namespace AutoSign
{
    public class ProgramConfig
    {

        /// <summary>
        /// 主窗体参数
        /// </summary>
        private FormConfig m_MainForm = new FormConfig();
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
            this.MainForm.FormConfigChanged += MainForm_FormConfigChanged;
        }

        void MainForm_FormConfigChanged(object sender, EventArgs e)
        {
            this.Changed = true;
        }
        /// <summary>
        /// 主窗体参数
        /// </summary>
        public FormConfig MainForm
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
        public ProgramConfig Load(string configFileName)
        {
            this.ConfigFileName = configFileName;
            return this.Load();
        }

        /// <summary>
        /// 从配置文件中读取配置参数，
        /// </summary>
        public ProgramConfig Load()
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
            return cfg;
        }

        /// <summary>
        /// 将配置参数存储到配置文件中
        /// </summary>
        public void Save()
        {
            if (this.Changed)
            {
                DialogResult dr = DialogResult.Cancel;
                do
                {
                    try
                    {
                        string j = Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
                        using (StreamWriter w = new StreamWriter(this.ConfigFileName))
                        {
                            w.Write(j);
                            w.Close();
                            this.Changed = false;
                        }
                    }
                    catch (IOException)
                    {
                        string s = Regex.Replace(Properties.Resources.strSaveFileErrorMessage, "{filename}", ConfigFileName);//?
                        dr = MessageBox.Show(s, Properties.Resources.strFileErrorMessageBoxTitle, MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    }
                } while (dr == DialogResult.Retry);

            }
        }

        /// <summary>
        /// 将配置参数存储到配置文件中
        /// </summary>
        /// <param name="ConfigFileName"></param>
        public void Save(String ConfigFileName)
        {
            this.ConfigFileName = ConfigFileName;
            this.Save();
        }

        /// <summary>
        /// 使用反射将临时变量中所有属性复制到this的属性中
        /// </summary>
        /// <param name="tmp">要复制属性的临时变量</param>
        private void CloneProperties(ProgramConfig tmp)
        {
            
        }

    }
}
