using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 员工表
    /// </summary>
    public class Employee
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int EmployeeID { get; set; }
        /// <summary>
        /// 员工用户名
        /// </summary>
        public string EmployeeName { get; set; }
        /// <summary>
        /// 员工密码
        /// </summary>
        public string EmployeePwd { get; set; }
    


    
        /// <summary>
        /// 员工真实姓名
        /// </summary>
        public string EmpNickName { get; set; }
        /// <summary>
        /// 集团Id
        /// </summary>
        public int BlocId { get; set; }
        /// <summary>
        /// 角色ID
        /// </summary>
        public string RoleID { get; set; }

    }
}
