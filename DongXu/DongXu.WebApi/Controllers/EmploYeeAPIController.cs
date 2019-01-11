using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DongXu.WebApi.Controllers
{
    using DongXu.Entity;
    using DongXu.IServices;
    using DongXu.Services;
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
        public int DeleteEmployee(int employeeId)
        {
            return EmployeeServices.DeleteEmployee(employeeId);
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
        public List<Employee> GetEmployeeById(int EmployeeID)
        {
            return EmployeeServices.GetEmployeeById(EmployeeID);
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
            return EmployeeServices.LoginEmp(empName,empPwd);
        }       
    }
}
