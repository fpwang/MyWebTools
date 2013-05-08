using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoSign
{
    public class ProgramConfig
    {

		/// <summary>
		/// 主窗体参数
		/// </summary>
		private FormConfig m_MainForm;
		/// <summary>
		/// 配置文件路径
		/// </summary>
		private string m_ConfigFilePath;

    
		/// <summary>
		/// 主窗体参数
		/// </summary>
		public FormConfig MainForm{
			get{
				return m_MainForm;
			}
			set{
				m_MainForm = value;
			}
		}

		/// <summary>
		/// 配置文件路径
		/// </summary>
		public string ConfigFilePath{
			get{
				return m_ConfigFilePath;
			}
			set{
				m_ConfigFilePath = value;
			}
		}
}
}
