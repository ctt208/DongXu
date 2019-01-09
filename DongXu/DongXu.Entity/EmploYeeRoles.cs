using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 员工角色关联表
    /// </summary>
    public class EmployeeRoles
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int EmployeeRolesID { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleID { get; set; }
    }
}
