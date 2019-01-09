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
                string sql = @"insert into bloc(name,pId,Isorno)values(:name,:Pid,:Isorno)";
                int result = conn.Execute(sql, blocs);
                return result;
            }
        }

        public List<Bloc> GetBlocs()
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select id,pid,name from bloc";
                var result = conn.Query<Bloc>(sql,null);
                return result.ToList();
            }
        }

        public int UpdateBloc(Bloc blocs)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"update bloc set name=:name,pId=:pId,Isorno=:Isorno where id=:id";
                int result = conn.Execute(sql, blocs);
                return result;
            }
        }
        public List<Bloc> GetBlocById(int Id)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select * from bloc where Id=:Id ";
                var Collectlist = new { Id = Id };
                var result = conn.Query<Bloc>(sql, Collectlist);
                return result.ToList();
            }
        }
    }
}
