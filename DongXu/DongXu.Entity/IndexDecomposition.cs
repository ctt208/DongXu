using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 指标分配表
    /// </summary>
   public class IndexDecomposition
    {
        public int Id { get; set; }
        /// <summary>
        /// 月份
        /// </summary>
        public string Month { get; set; }
        /// <summary>
        /// 目标详情Id
        /// </summary>
        public int TargetDetailsId { get; set; }
        /// <summary>
        /// 月份目标值
        /// </summary>
        public string MonthTarget { get; set; }
    }
}
