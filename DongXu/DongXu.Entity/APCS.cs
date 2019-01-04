using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 审批流程配置表
    /// </summary>
    public class APCS
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int APCSID { get; set; }
        /// <summary>
        /// 审批节点ID
        /// </summary>
        public int LOAPID { get; set; }
        /// <summary>
        /// 审批人部门
        /// </summary>
        public string ApprocerDepartment { get; set; }
        /// <summary>
        /// 审批人ID
        /// </summary>
        public int RoleID { get; set; }
        /// <summary>
        /// 下一步审批人ID
        /// </summary>
        public int NextRoleID { get; set; }
        /// <summary>
        /// 使用流程目标ID
        /// </summary>
        public int ID { get; set; }
        /// <summary>
        /// 是否允许修改
        /// </summary>
        public int IsOrNoUp { get; set; }
        /// <summary>
        /// 审批状态
        /// </summary>
        public int SPZT { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 审批意见
        /// </summary>
        public string SPYJ { get; set; }
        /// <summary>
        /// 审批时间
        /// </summary>
        public string SPTime { get; set; }
    }
}
