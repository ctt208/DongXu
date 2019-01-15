using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 积分表
    /// </summary>
    public class Integral
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Inid { get; set; }
        /// <summary>
        /// 集团Id
        /// </summary>
        public int BlocId { get; set; }
        /// <summary>
        /// 目标详情Id
        /// </summary>
        public int TargetDetailsId { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        public int IntegralNum { get; set; }
        /// <summary>
        /// 集团名字
        /// </summary>
        public string name { get; set; }
        
        public int id { get; set; }
 
    }
}
