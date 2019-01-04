using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 角色权限关联表
    /// </summary>
    public class RolePerMission
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int RolePerMissionID { get; set; }
        /// <summary>
        /// 权限ID
        /// </summary>
        public int PerMissionID { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleID { get; set; }
    }
}
