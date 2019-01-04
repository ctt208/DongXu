using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 目标类别表
    /// </summary>
    public class TarGetType
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int TarGetTypeID { get; set; }
        /// <summary>
        /// 目标类别名称
        /// </summary>
        public string TarGetTypeName { get; set; }
        /// <summary>
        /// PID
        /// </summary>
        public int PID { get; set; }
        /// <summary>
        /// 是否启用
        /// </summary>
        public int IsOrNo { get; set; }
    }
}
