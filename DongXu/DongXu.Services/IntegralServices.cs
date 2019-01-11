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

    public class IntegralServices:IIntegralServices
    {
        /// <summary>
        /// 积分显示
        /// </summary>
        /// <returns></returns>
        public List<Integral> GetIntegral()
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select b.id,inte.inid,b.name,inte.IntegralNum from bloc b inner join Integral Inte on b.id=Inte.Inid";
                //string sql = @"select * from Integral";
                IEnumerable<Integral> list = conn.Query<Integral>(sql, null);
                return list.ToList();
            }
        }
    }
}
