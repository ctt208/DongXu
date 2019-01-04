using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 用户角色关联表
    /// </summary>
    public class EmploYeeRoles
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int EmploYeeRolesID { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public int EmploYeeID { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public int RoleID { get; set; }
    }
}
