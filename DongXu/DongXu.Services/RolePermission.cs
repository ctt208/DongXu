using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DongXu.Services
{
    using DongXu.Entity;
    using DongXu.Common;
    using Dapper;
    using IServices;
    public class RolePermission : IRolePermisson
    {
        public List<RolePerMission> showRolesById(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                string sql = "select pr.rolepermissionid,r.roleid,r.rolename,r.roledescribe,pr.permissionid from roles r, rolepermission pr where r.roleid = pr.roleid and r.roleid=" + id;
                var rolesbyid = conn.Query<RolePerMission>(sql, null);
                return rolesbyid.ToList();
            }
        }
    }
}
