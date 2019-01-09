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
        /// 员工手机号
        /// </summary>
        public string EmployeePhone { get; set; }
        /// <summary>
        /// 入职时间
        /// </summary>
        public DateTime EmployeeEntryTime { get; set; }
        /// <summary>
        /// 员工性别
        /// </summary>
        public int EmployeeSxe { get; set; }
        /// <summary>
        /// 员工年龄
        /// </summary>
        public int EmployeeAge { get; set; }
        /// <summary>
        /// 员工真实姓名
        /// </summary>
        public string EmpNickName { get; set; }
    }
}
