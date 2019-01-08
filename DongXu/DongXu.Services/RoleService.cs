using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using DongXu.Entity;
using DongXu.Common;
using Dapper;
namespace DongXu.Services
{
    using DongXu.IServices;
    public class RoleService:IRoleService
    {
        /// <summary>
        /// 角色显示
        /// </summary>
        /// <returns></returns>
        public List<Roles> GetRoles(string name)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = "select RoleID, RoleName,RoleDescribe from roles where RoleName like '%" + name + "%'";
                var getrole = conn.Query<Roles>(sql,name).ToList();
                return getrole;
            }
        }
        /// <summary>
        /// 角色删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelteRole(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                string sql ="delete from Roles where RoleID=" + id;
                var deleterole = conn.Execute(sql, id);
                return deleterole;
            }
        }
        /// <summary>
        /// 角色查询
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        //public List<Roles> GetRolescha(string name)
        //{
        //    using (OracleConnection conn = DapperHelper.GetConnectionString())
        //    {
        //        string sql = "select * from Roles where RoleName like '%" + name+"%'";
        //        var getrolecha = conn.Query<Roles>(sql, name).ToList();
        //        return getrolecha;
        //    }
        //}
        /// <summary>
        /// 角色添加
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        public int AddRoles(Roles r)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                string sql = "insert into Roles(RoleName,RoleDescribe,RoleEstablishTime,RoleUpTime)values(:RoleName,:RoleDescribe,:RoleEstablishTime,:RoleUpTime)";
                r.RoleEstablishTime = System.DateTime.Now;
                r.RoleUpTime = System.DateTime.Now;
                var roleslist = new { RoleName = r.RoleName, RoleDescribe = r.RoleDescribe, RoleEstablishTime=r.RoleEstablishTime, RoleUpTime=r.RoleUpTime };
                var addroles = conn.Execute(sql, roleslist);
                return addroles;
            }
        }
    }
}
