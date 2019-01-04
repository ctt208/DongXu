using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 目标表
    /// </summary>
   public class Target
    {/// <summary>
    /// 主键Id
    /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 目标名称
        /// </summary>
        public string TargetName { get; set; }
        /// <summary>
        /// 完成情况
        /// </summary>
        public string Condition { get; set; }
        /// <summary>
        /// 等级
        /// </summary>
        public string Grade { get; set; }
        /// <summary>
        /// 负责人
        /// </summary>
        public string dutyMan { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime FinishTime { get; set; }
        /// <summary>
        /// 当前进度
        /// </summary>
        public string CurrentProgress { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public string State { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 负责单位
        /// </summary>
        public string DutyUnit { get; set; }

    }
}
