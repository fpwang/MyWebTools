using System;
using System.Drawing;

namespace MyWebTools.AutoSign {

    /// <summary>
	/// 主窗体配置参数
	/// </summary>
	public class MainFormConfig {

		/// <summary>
		/// 程序启动时主窗体是否最大化
		/// </summary>
		private bool m_MaximizeOnStart;
		/// <summary>
		/// 主窗体尺寸
		/// </summary>
		private Size m_Size;

		/// <summary>
		/// 主窗体配置参数发生改变时，引发FormConfigChanged事件
		/// </summary>
        public event EventHandler<ConfigChangeEventArgs> FormConfigChanged;

		public MainFormConfig(){

		}

		~MainFormConfig(){

		}

		public virtual void Dispose(){

		}

		/// <summary>
		/// 程序启动时主窗体是否最大化
		/// </summary>
		public bool MaximizeOnStart{
			get{
				return m_MaximizeOnStart;
			}
			set{
				m_MaximizeOnStart = value;
                OnRaiseFormConfigChanged("MaximizeOnStart");
            }
		}

		/// <summary>
		/// 主窗体尺寸
		/// </summary>
		public Size Size{
			get{
				return m_Size;
			}
			set{
				m_Size = value;
                OnRaiseFormConfigChanged("Size");
            }
		}

		/// <summary>
		/// 引发FormConfigChanged事件的辅助函数
		/// </summary>
		/// <param name="configName">发生改变的参数名称</param>
        private void OnRaiseFormConfigChanged(string configName)
        {
            EventHandler<ConfigChangeEventArgs> handler = FormConfigChanged;

            if (handler != null)
            {
                handler(this, new ConfigChangeEventArgs(configName));
            }
        }

        /// <summary>
        /// 将临时变量中的属性复制到此对象中
        /// </summary>
        /// <param name="formConfig">要复制的临时变量</param>
        public void Copy(MainFormConfig formConfig)
        {
            this.m_MaximizeOnStart=formConfig.MaximizeOnStart;
            this.m_Size = formConfig.Size;
        }
    }//end MainFormConfig

}//end namespace MyWebTools.AutoSign