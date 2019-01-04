using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 审批结点表
    /// </summary>
    public class LOAP
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int LOAPID { get; set; }
        /// <summary>
        /// 结点名称
        /// </summary>
        public string LOAPName { get; set; }
        /// <summary>
        /// 负责角色
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 创建人
        /// </summary>
        public string Founder { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
