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
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 父级Id
        /// </summary>
        public int pId { get; set; }
        /// <summary>
        /// 目标名称
        /// </summary>
        public string name { get; set; }
    }
}
