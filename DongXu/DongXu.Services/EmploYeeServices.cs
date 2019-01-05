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

    public class EmploYeeServices : IEmploYeeServices
    {
        public int AddEmploYee(EmploYee emploYee)
        {
            using(OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"insert into employee(employeename,employeepwd,employeephone,employeeentrytime,employeesex,employeeage,empnickname) values(:employeename,:employeepwd,:employeephone,:employeeentrytime,:employeesex,:employeeage,:empnickname)";
                int result = conn.Execute(sql, emploYee);
                return result;
            }
        }

        public int DeleteEmploYee(int emploYeeId)
        {
            throw new NotImplementedException();
        }

        public List<EmploYee> GetEmploYees()
        {
            throw new NotImplementedException();
        }

        public int UpdateEmploYee(EmploYee emploYee)
        {
            throw new NotImplementedException();
        }
    }
}
