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
    public class EmploYee
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int EmploYeeID { get; set; }
        /// <summary>
        /// 员工用户名
        /// </summary>
        public string EmploYeeName { get; set; }
        /// <summary>
        /// 员工密码
        /// </summary>
        public string EmploYeePwd { get; set; }
        /// <summary>
        /// 员工手机号
        /// </summary>
        public string EmploYeePhone { get; set; }
        /// <summary>
        /// 入职时间
        /// </summary>
        public DateTime EmploYeeEntryTime { get; set; }
        /// <summary>
        /// 员工性别
        /// </summary>
        public int EmploYeeSxe { get; set; }
        /// <summary>
        /// 员工年龄
        /// </summary>
        public int EmploYeeAge { get; set; }
        /// <summary>
        /// 员工真实姓名
        /// </summary>
        public string EmpNickName { get; set; }
    }
}
