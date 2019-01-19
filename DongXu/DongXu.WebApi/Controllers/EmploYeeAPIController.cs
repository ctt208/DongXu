using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using DongXu.Common;

namespace DongXu.WebApi.Controllers
{
    using DongXu.Entity;
    using DongXu.IServices;
    using DongXu.Services;
    using DongXu.Common;
    [RoutePrefix("DongXu")]
    public class EmployeeAPIController : ApiController
    {
        public IEmployeeServices EmployeeServices { get; set; }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="employee"></param>
        /// <returns></returns>
        [Route("AddEmployee")]
        [HttpPost]
        public int AddEmployee(Employee employee)
        {
            employee.EmployeePwd = EncryHelper.GetMd5Str(employee.EmployeePwd);
            return EmployeeServices.AddEmployee(employee);
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [Route("GetEmployee")]
        [HttpGet]
        public List<Employee> GetEmployees()
        {
            return EmployeeServices.GetEmployees();
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [Route("DeleteEmployee")]
        [HttpGet]
        public int DeleteEmployee(int EmployeeID)
        {
            return EmployeeServices.DeleteEmployee(EmployeeID);
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="emploYee"></param>
        /// <returns></returns>
        [Route("UpdateEmployee")]
        [HttpPost]
        public int UpdateEmployee(Employee emploYee)
        {
            return EmployeeServices.UpdateEmployee(emploYee);
        }
        /// <summary>
        /// 根据Id显示
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        [Route("GetEmloyeeById")]
        [HttpGet]
        public List<Employee> GetEmployeeById(int BlocId)
        {
            return EmployeeServices.GetEmployeeById(BlocId);
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <param name="empName"></param>
        /// <param name="empPwd"></param>
        /// <returns></returns>
        [Route("LoginEmp")]
        [HttpGet]
        public int LoginEmp(string empName, string empPwd)
        {
            empPwd = EncryHelper.GetMd5Str(empPwd);
            return EmployeeServices.LoginEmp(empName,empPwd);
        }
        /// <summary>
        /// 角色显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetRoles")]
        public List<Roles> GetRoles()
        {
            return EmployeeServices.GetRoles();
        }
    }
}
