using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWebTools.AutoSign
{
    /// <summary>
	/// 配置更改事件参数类
	/// </summary>
    public class ConfigChangeEventArgs : EventArgs 
    {
		/// <summary>
		/// 发生改变的参数名称
		/// </summary>
        private string m_ConfigName;

        /// <summary>
        /// 用指定的配置参数名生成配置更改事件参数类实例
        /// </summary>
        /// <param name="configName">发生改变的参数名称</param>
        public ConfigChangeEventArgs(string configName)
        {
            this.m_ConfigName = configName;
        }
		/// <summary>
		/// 发生改变的参数名称
		/// </summary>
		public string ConfigName{
			get{
				return m_ConfigName;
			}
			set{
				m_ConfigName = value;
			}
		}

    }
}
