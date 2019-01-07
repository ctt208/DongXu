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
    public class BlocServices : IBlocServices
    {
        public int AddBloc(Bloc blocs)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"insert into bloc(BLOCNAME,PID,Isorno)values(:BLOCNAME,:PID,:Isorno)";
                int result = conn.Execute(sql, blocs);
                return result;
            }
        }

        public List<Bloc> GetBlocs()
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select BLOCNAME,PID,ISORNO from bloc";
                var result = conn.Query<Bloc>(sql,null);
                return result.ToList();
            }
        }

        public int UpdateBloc(Bloc blocs)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"update bloc set BLOCNAME=:BLOCNAME,PID=:PID,ISORNO=:ISORNO where ID=:ID";
                int result = conn.Execute(sql, blocs);
                return result;
            }
        }
    }
}
