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
        public int AddEmployee(Employee emploYee)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"insert into employee(employeename,employeepwd,employeephone,employeeentrytime,employeesex,employeeage,empnickname) values(:employeename,:employeepwd,:employeephone,:employeeentrytime,:employeesex,:employeeage,:empnickname)";
                int result = conn.Execute(sql, emploYee);
                return result;
            }
        }

        public int DeleteEmployee(int employeeId)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"delete from employee where employeeId=:employeeId";
                int result = conn.Execute(sql, new { employeeId = employeeId });
                return result;
            }
        }

        public List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }

        public int UpdateEmployee(Employee emploYee)
        {
            throw new NotImplementedException();
        }
    }
}
