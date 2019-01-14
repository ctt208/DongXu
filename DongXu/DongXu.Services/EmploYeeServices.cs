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
                string sql1 = @"select EmployeeName from employee where EmployeeName=:EmployeeName";
                var result1 = conn.Query<Employee>(sql1, emploYee);
                int i = -1;
                if (result1.Count()==0)
                {
                    string sql = @"insert into employee(employeename,employeepwd,empnickname,BlocId) values(:employeename,:employeepwd,:empnickname,:BlocId)";
                    int result = conn.Execute(sql, emploYee);
                    return result;
                }
               
                return i;
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
                string sql = @"select EmployeeName  from employee";
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
        public List<Employee> GetEmployeeById(int BlocId)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select e.employeeid,e.employeename,e.empnickname,b.id as BlocId from employee e inner join bloc b on e.blocid=b.id where b.id="+BlocId;
                var result = conn.Query<Employee>(sql, null);
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
