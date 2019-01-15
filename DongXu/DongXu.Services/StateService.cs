using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Services
{
    using DongXu.Entity;
    using DongXu.Common;
    using DongXu.IServices;
    using Oracle.ManagedDataAccess.Client;
    using Dapper;
    public class StateService:IStateService
    {
        /// <summary>
        /// 显示AAA级别的
        /// </summary>
        /// <returns></returns>
        public List<State> GetStates()
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                string sql = "select * from state where statejb='AAA'";
                var getstate = conn.Query<State>(sql, null);
                return getstate.ToList();
            }
        }
        /// <summary>
        /// 显示AA级别的
        /// </summary>
        /// <returns></returns>
        public List<State> States()
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                string sql = "select * from state where statejb='AA'";
                var states = conn.Query<State>(sql, null);
                return states.ToList();
            }
        }
    }
}
