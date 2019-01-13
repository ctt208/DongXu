using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 层级用户关联表
    /// </summary>
   public class HierarchyRole
    {
        public int CId { get; set; }
        /// <summary>
        /// 层级Id
        /// </summary>
        public int HierarchyId { get; set; }
        /// <summary>
        /// 角色Id
        /// </summary>
        public int RolesId { get; set; }
    }
}
