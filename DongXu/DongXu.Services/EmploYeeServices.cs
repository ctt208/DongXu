using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Services
{
    using DongXu.IServices;
    using DongXu.Entity;
    using DongXu.Common;
    using Oracle.ManagedDataAccess.Client;
    using Dapper;

    public class EmployeeServices : IEmployeeServices
    {
        /// <summary>
        /// 添加员工
        /// </summary>
        /// <param name="emploYee"></param>
        /// <returns></returns>
        public int AddEmployee(Employee emploYee)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"insert into employee(employeename,employeepwd,empnickname) values(:employeename,:employeepwd,:empnickname)";
                int result = conn.Execute(sql, emploYee);
                return result;
            }
        }
        /// <summary>
        /// 删除员工
        /// </summary>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public int DeleteEmployee(int employeeId)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"delete from employee where employeeID=:employeeID";
                int result = conn.Execute(sql, new { employeeId = employeeId });
                return result;
            }
        }
        /// <summary>
        /// 显示员工
        /// </summary>
        /// <returns></returns>
        public List<Employee> GetEmployees()
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select EmployeeName,EmployeePwd,EmpNickName from employee";
                var result = conn.Query<Employee>(sql, null);
                return result.ToList();
            }
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="emploYee"></param>
        /// <returns></returns>
        public int UpdateEmployee(Employee emploYee)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"update Employee set EmployeeName=:EmployeeName,EmployeePwd=:EmployeePwd,EmpNickName=:EmpNickName where EMPLOYEEID=:EMPLOYEEID";
                int result = conn.Execute(sql, emploYee);
                return result;
            }
        }
        /// <summary>
        /// 根据Id获取员工
        /// </summary>
        /// <param name="EmployeeID"></param>
        /// <returns></returns>
        public List<Employee> GetEmployeeById(int EmployeeID)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select  EmployeeName,EmployeePwd,EmpNickName from Employee where EmployeeID=:EmployeeID";
                var Collectlist = new { EmployeeID = EmployeeID };
                var result = conn.Query<Employee>(sql, Collectlist);
                return result.ToList();
            }
        }
        /// <summary>
        /// 登陆
        /// </summary>
        /// <returns></returns>
        public int LoginEmp(string empName, string empPwd)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();               
                string sql = @"select * from EMPLOYEE where EmployeeName=:empName and EmployeePwd=:empPwd";
                var result = conn.Query<Employee>(sql, new { empName = empName, empPwd = empPwd });
                return result.Count();
            }
        }

    
    }
}
