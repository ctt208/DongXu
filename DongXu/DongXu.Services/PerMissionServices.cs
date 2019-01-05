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

    public class PerMissionServices : IPerMission
    {
        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="perMission"></param>
        /// <returns></returns>
        public int AddPerMission(PerMission perMission)
        {
            using (OracleConnection conn=DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"insert into PERMISSION(permissionname,establishtime,uptime) values(:permissionname,:establishtime,:uptime)";
                int i = conn.Execute(sql,perMission);
                return i;
            }
        }
        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DeletePerMission(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"delete from PERMISSION where permissionid=:id";
                int i = conn.Execute(sql,id);
                return i;
            }
        }
        /// <summary>
        /// 根据ID显示单个权限信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public PerMission GetPerMissionById(int id)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select permissionname,establishtime,uptime from PERMISSION where permissionid=:id";
                PerMission perMission= conn.Query<PerMission>(sql, id).FirstOrDefault();
                return perMission;
            }
        }

        /// <summary>
        /// 显示权限信息
        /// </summary>
        /// <returns></returns>
        public List<PerMission> GetPerMissions()
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select permissionname,establishtime,uptime from PERMISSION ";
               IEnumerable<PerMission> list = conn.Query<PerMission>(sql,null);
                return list.ToList();
            }
        }
        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="perMission"></param>
        /// <returns></returns>
        public int UpdatePerMission(PerMission perMission)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"update PERMISSION set permissionname=:permissionname,establishtime=:establishtime,uptime=:uptime where permissionid=:permissionid";
                int i = conn.Execute(sql,perMission);
                return i;
            }
        }
    }
}
