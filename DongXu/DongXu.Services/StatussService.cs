using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Dapper;

namespace DongXu.Services
{
    using DongXu.Entity;
    using DongXu.Common;
    using DongXu.IServices;
    public class StatussService:IStatussService
    {
        public List<Statuss> GetStatusses()
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                string sql = string.Format("select ss.statussid,ss.red,ss.yellow,ss.green,ss.redpercentile,ss.num,ss.yellowpercentile,ss.greenpercentile,b.name from statuss ss join bloc b on ss.pid=b.id");
                var getstatuss = conn.Query<Statuss>(sql, null);
                return getstatuss.ToList();
            }
        }
    }
}
