using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyWebTools.Core
{
	/// <summary>
	/// 任务活动类。为程序根据Task类中的任务定义安排的活动单元。
	/// </summary>
    public class Activity
    {
		/// <summary>
		/// 任务完成时间
		/// </summary>
		private DateTime m_CompleteTime;
		/// <summary>
		/// 任务开始时间
		/// </summary>
		private DateTime m_StartTime;
		/// <summary>
		/// 定义该活动的Task名称
		/// </summary>
		private string m_TaskName;

    
		/// <summary>
		/// 任务完成时间
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
		/// 任务开始时间
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
		/// 定义该活动的Task名称
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
