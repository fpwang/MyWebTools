using System;

namespace AutoSign {

    //public delegate void FormConfigChangedEventHandler(object sender, EventArgs e);
	/// <summary>
	/// 主窗体配置参数
	/// </summary>
	public class FormConfig {

		/// <summary>
		/// 主窗体是否最大化
		/// </summary>
		private bool m_MaximizeOnStart;
		/// <summary>
		/// 窗体高度
		/// </summary>
		private int m_Height;
		/// <summary>
		/// 窗体宽度
		/// </summary>
		private int m_Width;

        public event EventHandler FormConfigChanged;

		public FormConfig(){

		}

		~FormConfig(){

		}

		public virtual void Dispose(){

		}

		/// <summary>
		/// 主窗体是否最大化
		/// </summary>
		public bool MaximizeOnStart{
			get{
				return m_MaximizeOnStart;
			}
			set{
				m_MaximizeOnStart = value;
                OnRaiseFormConfigChanged();
            }
		}

		/// <summary>
		/// 窗体高度
		/// </summary>
		public int Height{
			get{
				return m_Height;
			}
			set{
				m_Height = value;
                OnRaiseFormConfigChanged();
            }
		}

		/// <summary>
		/// 窗体宽度
		/// </summary>
		public int Width{
			get{
				return m_Width;
			}
			set{
				m_Width = value;
                OnRaiseFormConfigChanged();
            }
		}

        private void OnRaiseFormConfigChanged()
        {
            EventHandler handler = FormConfigChanged;

            if (handler != null)
            {
                handler(this, new EventArgs());
            }
        }

	}//end MainFormConfig

}//end namespace AutoSign