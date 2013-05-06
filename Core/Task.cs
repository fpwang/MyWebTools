using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
	/// <summary>
	/// 任务执行周期类型，按天执行、按小时执行、按分钟执行
	/// </summary>
    public enum TaskCycleBy : int
    {


		/// <summary>
		/// 按天安排任务，在每天零时后即安排任务执行。
		/// </summary>
		Day,
		/// <summary>
		/// 按小时安排任务，进行一次任务后，经过指定小时数，安排下一次任务执行
		/// </summary>
		Hour,
		/// <summary>
		/// 按分钟安排任务，进行一次任务后，经过指定分钟数，安排下一次任务执行
		/// </summary>
		Minute


	}
	/// <summary>
	/// 自动化任务类，定义了任务执行间隔和需要执行的动作代码
	/// </summary>
    public class Task
    {
		/// <summary>
		/// 任务要执行的代码
		/// </summary>
		private string code;
		/// <summary>
		/// 任务执行周期类型，可以为：按天执行、按小时执行、按分钟执行
		/// </summary>
		private TaskCycleBy cycleBy;
		/// <summary>
		/// 任务间隔时间，依据CycleBy枚举值，为指定的天、小时或分钟数
		/// </summary>
		private int cycleTime;

    
		/// <summary>
		/// 任务要执行的代码
		/// </summary>
		public string Code{
			get{
				return code;
			}
			set{
				code = value;
			}
		}

		/// <summary>
		/// 任务执行周期类型，可以为：按天执行、按小时执行、按分钟执行
		/// </summary>
		public TaskCycleBy CycleBy{
			get{
				return cycleBy;
			}
			set{
				cycleBy = value;
			}
		}

		/// <summary>
		/// 任务间隔时间，依据CycleBy枚举值，为指定的天、小时或分钟数
		/// </summary>
		public int CycleTime{
			get{
				return cycleTime;
			}
			set{
				cycleTime = value;
			}
		}
}
}
