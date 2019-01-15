using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    public class ShowRoles
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleID { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RoleName { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string RoleDescribe { get; set; }
        /// <summary>
        /// 权限ID
        /// </summary>
        public string PerMissionID { get; set; }
    }
}
