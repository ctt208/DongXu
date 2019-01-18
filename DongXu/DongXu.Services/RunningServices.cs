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
    public class RunningServices : IRunning
    {
        /// <summary>
        /// 显示运行情况
        /// </summary>
        /// <returns></returns>
        public List<TargetDetails> GetRunnings()
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select b.name,a.numberids,a.per from (select statusid,count(1) as numberids,TRUNC(count(1)/(select count(1)  from targetdetails )*100,2) as per from targetdetails group by statusid)  a inner join status b on a.statusid = b.id";
                IEnumerable<TargetDetails> targetDetailslist = conn.Query<TargetDetails>(sql, null);
                return targetDetailslist.ToList();
            }
        }
    }
}
