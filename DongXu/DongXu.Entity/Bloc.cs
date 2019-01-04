using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 集团表
    /// </summary>
    public class Bloc
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int BlocID { get; set; }
        /// <summary>
        /// 集团名称
        /// </summary>
        public string BlocName { get; set; }
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
