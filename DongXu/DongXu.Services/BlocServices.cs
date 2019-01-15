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
        /// <summary>
        /// 组织添加
        /// </summary>
        /// <param name="blocs"></param>
        /// <returns></returns>
        public int AddBloc(Bloc blocs)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
               
                conn.Open();
                string sql1 = "select name from bloc where name=:name";
                var result1 = conn.Query<Bloc>(sql1, blocs);
                int z = -1;
                if (result1.Count() == 0)
                {
                    string sql = @"insert into bloc(name,pId)values(:name,:Pid)";
                    int result = conn.Execute(sql, blocs);
                    return result;
                }
                return z;
               
            }
        }
    /// <summary>
    /// 组织显示
    /// </summary>
    /// <returns></returns>

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
        /// <summary>
        /// 组织修改
        /// </summary>
        /// <param name="blocs"></param>
        /// <returns></returns>

        public int UpdateBloc(Bloc blocs)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"update bloc set name=:name,pId=:pId where id=:id";
                int result = conn.Execute(sql, blocs);
                return result;
            }
        }
        /// <summary>
        /// 根据id显示组织层级
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
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
