using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 活动表
    /// </summary>
    public class ConfigurationActivites
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 审批配置表Id
        /// </summary>
        public int ApcsId { get; set; }
        /// <summary>
        /// 审批节点表Id
        /// </summary>
        public int LoapId { get; set; }
        /// <summary>
        /// 审批部门
        /// </summary>
        public string Apporverdepartment { get; set; }
        /// <summary>
        /// 审批人Id
        /// </summary>
        public int RoleId { get; set; }
        /// <summary>
        /// 下一步审批人Id
        /// </summary>
        public int NextRoleId { get; set; }
        /// <summary>
        /// 目标详情Id
        /// </summary>
        public int TargetDetailsId { get; set; }
        /// <summary>
        /// 是否允许修改
        /// </summary>
        public int Isornoup { get; set; }
        /// <summary>
        /// 审批状态
        /// </summary>
        public int SPZT { get; set; }
        /// <summary>
        /// 审批意见
        /// </summary>
        public string Option { get; set; }
        /// <summary>
        /// 审批时间
        /// </summary>
        public DateTime OpinionTime { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
    }
}
