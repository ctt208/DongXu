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

    public class TargetDetailsServices : ITargetDetailsServices
    {
        /// <summary>
        /// 添加目标详情信息
        /// </summary>
        /// <param name="targetDetails"></param>
        /// <returns></returns>

        public int AddTargetDetails(TargetDetails targetDetails)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"Insert into targetdetails(targetId,indextypeid,statusid,blocid,indexlevelid,feedbacknumid,starttime,finishtime,dutyman,assessmentweight,reportedman,organizer,remark,affirmflow,annualtarget)values(:targetId,:indextypeid,:statusid,:blocid,:indexlevelid,:feedbacknumid,:starttime,:finishtime,:dutyman,:assessmentweight,:reportedman,:organizer,:remark,:affirmflow,:annualtarget)";
                int i = conn.Execute(sql, targetDetails);
                return i;
            }
        }

        public int DeleteTargetDetails(int id)
        {
            throw new NotImplementedException();
        }


        /// <summary>
        /// 显示目标信息
        /// </summary>
        /// <returns></returns>
        public List<TargetDetails> GetTargetDetails()
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select a.*,b.name as TargetName,c.targettypename as targettypename,d.image as StatusImage,d.name as StatusName,e.name as BlocName,f.feedbackname  from targetdetails a inner join target b on a.targetid = b.id inner join targettype c on a.indextypeid = c.targettypeid  inner join status d on a.statusid = d.id inner join bloc e on a.blocid=e.id inner join feedbacknum f on a.feedbacknumid = f.id  ";
                IEnumerable<TargetDetails> targetDetailslist = conn.Query<TargetDetails>(sql, null);
                return targetDetailslist.ToList();
            }
        }

        public int UpdateTargetDetails(TargetDetails targetDetail)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 根据ID显示指标内容
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public List<TargetDetails> GetTargetDetailsById(int Id)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select a.*,b.name as TargetName,c.targettypename as targettypename,d.image as StatusImage,d.name as StatusName,e.name as BlocName,f.feedbackname,c.targettypename,b.id from targetdetails a inner join target b on a.targetid = b.id inner join targettype c on a.indextypeid = c.targettypeid  inner join status d on a.statusid = d.id inner join bloc e on a.blocid=e.id inner join feedbacknum f on a.feedbacknumid = f.id  where a.id=" + Id;
                var result = conn.Query<TargetDetails>(sql, null);
                return result.ToList();

            }
        }
        /// <summary>
        /// 添加子目标
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        public int AddTarget(Target t)
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"Insert into Target(pId,name)values(:pId,:name)";
                t.pId = 2;
                int i = conn.Execute(sql, t);
                return i;
            }
        }
        /// <summary>
        /// 获取目标状态
        /// </summary>
        /// <returns></returns>
        public List<Status> GetStatuses()
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 显示反馈频次
        /// </summary>
        /// <returns></returns>
        public List<FeedbackNum> GetFeedbackNums()
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select * from FeedbackNum";
                var result = conn.Query<FeedbackNum>(sql, null);
                return result.ToList();
            }
        }
    }
}
