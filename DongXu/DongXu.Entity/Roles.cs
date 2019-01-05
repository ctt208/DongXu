using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 角色表
    /// </summary>
    public class Roles
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
        /// 角色描述
        /// </summary>
        public string RoleDescribe { get; set; }
        /// <summary>
        /// 角色创建时间
        /// </summary>
        public DateTime RoleEstablishTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime RoleUpTime { get; set; }
    }
}
