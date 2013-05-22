using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWebTools.Core
{
	/// <summary>
	/// 任务执行器类。负责组织任务、对任务中代码进行编译，并组织活动队列。
	/// </summary>
    public class Executor
    {
		/// <summary>
		/// 任务活动序列
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
		/// 任务列表
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
		/// 任务活动序列
		/// </summary>
		private List<Activity> m_Activities;
		/// <summary>
		/// 任务列表
		/// </summary>
		private List<Task> m_tasks;
    }
}
