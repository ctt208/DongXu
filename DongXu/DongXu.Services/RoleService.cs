using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DongXu.Services
{
    using DongXu.Entity;
    using DongXu.IServices;
    using DongXu.Common;
    using Dapper;
    
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
                string sql = "select * from roles where RoleName like '%" + name + "%'";
                var roleslist = conn.Query<Roles>(sql, name);
                return roleslist.ToList();
            }
        }
        /// <summary>
        /// 角色添加
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        public int AddRoles(Roles role)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                string sql = string.Format("insert into Roles(RoleName,RoleDescribe) values(:RoleName,:RoleDescribe)");
                var add = conn.Execute(sql, role);
                string sql1 = string.Format("select RoleID from Roles where RoleName=:RoleName");
                var id = conn.Query<int>(sql1, role).FirstOrDefault();
                var roles = role.PerMissionID.Split(',');
                for (int i = 0; i < roles.Length; i++)
                {
                    RolePerMission rolePerMission = new RolePerMission();
                    rolePerMission.RoleID = id;
                    rolePerMission.PerMissionID = roles[i];
                    string sql2 = string.Format("insert into RolePerMission (PerMissionID,RoleID) values(:PerMissionID,:RoleID)");
                    var addrole = conn.Execute(sql2, rolePerMission);
                }
                return add;
            }
        }
        /// <summary>
        /// 获取信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<ShowRoles> RolesByID(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                string sql = string.Format("select * from roles r join rolepermission rp on r.roleid=rp.roleid where r.roleid=:roleid");
                var rolesbyid = conn.Query<ShowRoles>(sql, new { roleid = id });
                return rolesbyid.ToList();
            }
        }
        public int UpdateRoles(Roles role)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                string sql = string.Format("update roles set RoleName=:RoleName,RoleDescribe=:RoleDescribe where RoleID=:RoleID");
                var add = conn.Execute(sql, role);
                var roles = role.PerMissionID.Split(',');
                string sql1 = string.Format("DELETE FROM RolePerMission where RoleID=:RoleID");
                var id = conn.Query<int>(sql1, new { RoleID = role.RoleID });
                
                for (int i = 0; i < roles.Length; i++)
                {
                    RolePerMission rolePerMission = new RolePerMission();
                    rolePerMission.RoleID = role.RoleID;
                    rolePerMission.PerMissionID = roles[i];
                    string sql2 = string.Format("insert into RolePerMission (PerMissionID,RoleID) values(:PerMissionID,:RoleID)");
                    var addrole = conn.Execute(sql2, rolePerMission);
                }
                return add;
            }
        }
        //public List<Roles> GetSearch(string name)
        //{
        //    using (OracleConnection conn = DapperHelper.GetConnectionString())
        //    {
        //        string sql = "select * from roles where RoleName like '%" + name + "%'";
        //        var getsearch = conn.Query<Roles>(sql, name);
        //        return getsearch.ToList();
        //    }
        //}

        public int DelRoles(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                string sql = string.Format("delete from Roles where RoleID=:id");
                var delroles = conn.Execute(sql, new { id = id });
                if(delroles>0)
                {
                    string sql1 = string.Format("delete from rolepermission where RoleID=:id");
                    var del = conn.Execute(sql1, new { id = id });
                    return del;
                }
                return delroles;
            }
        }
    }
}
