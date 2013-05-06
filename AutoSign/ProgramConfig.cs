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
		private MainFormConfig m_MainFormCfg;

    
		/// <summary>
		/// 主窗体参数
		/// </summary>
		public MainFormConfig MainFormCfg{
			get{
				return m_MainFormCfg;
			}
			set{
				m_MainFormCfg = value;
			}
		}
}
}
