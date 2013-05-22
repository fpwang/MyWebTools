using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWebTools.Core
{
	/// <summary>
	/// �����ࡣΪ�������Task���е������尲�ŵĻ��Ԫ��
	/// </summary>
    public class Activity
    {
		/// <summary>
		/// �������ʱ��
		/// </summary>
		private DateTime m_CompleteTime;
		/// <summary>
		/// ����ʼʱ��
		/// </summary>
		private DateTime m_StartTime;
		/// <summary>
		/// ����û��Task����
		/// </summary>
		private string m_TaskName;

    
		/// <summary>
		/// �������ʱ��
		/// </summary>
		public DateTime CompleteTime{
			get{
				return m_CompleteTime;
			}
			set{
				m_CompleteTime = value;
			}
		}

		/// <summary>
		/// ����ʼʱ��
		/// </summary>
		public DateTime StartTime{
			get{
				return m_StartTime;
			}
			set{
				m_StartTime = value;
			}
		}

		/// <summary>
		/// ����û��Task����
		/// </summary>
		public string TaskName{
			get{
				return m_TaskName;
			}
			set{
				m_TaskName = value;
			}
		}
}
}
