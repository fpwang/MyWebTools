using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWebTools.Core
{
	/// <summary>
	/// ����ִ�����ࡣ������֯���񡢶������д�����б��룬����֯����С�
	/// </summary>
    public class Executor
    {
		/// <summary>
		/// ��������
		/// </summary>
		public List<Activity> Activities{
			get{
				return m_Activities;
			}
			set{
				m_Activities = value;
			}
		}

		/// <summary>
		/// �����б�
		/// </summary>
		public List<Task> tasks{
			get{
				return m_tasks;
			}
			set{
				m_tasks = value;
			}
		}

		/// <summary>
		/// ��������
		/// </summary>
		private List<Activity> m_Activities;
		/// <summary>
		/// �����б�
		/// </summary>
		private List<Task> m_tasks;
    }
}
