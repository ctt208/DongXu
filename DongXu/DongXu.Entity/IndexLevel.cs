using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{

    /// <summary>
    /// 指标等级表
    /// </summary>
    public class IndexLevel
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 指标等级名称
        /// </summary>
        public string LevelName{get;set;}
    }
}
