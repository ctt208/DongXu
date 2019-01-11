using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Services
{
    using DongXu.IServices;
    using Dapper;
    using Oracle.ManagedDataAccess.Client;
    using DongXu.Entity;
    using DongXu.Common;
    public class TargetServices : ITargetServices
    {
        public int AddTarget(Target target)
        {
            using(OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = $"insert into Target(TargetName,pId) values(:TargetName,:pId)";
                int result = conn.Execute(sql, target);
                return result;
            }
        }

        public int DeleteTarget(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Target> GetTargets()
        {
            using(OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = "select Id,name,pId from Target";
                var targetList = conn.Query<Target>(sql, null);
                return targetList.ToList();
            }
        }

        public int UpdateTarget(Target target)
        {
            throw new NotImplementedException();
        }
    }
}
