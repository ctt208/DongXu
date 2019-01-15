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
                string sql = @"";
                int i = conn.Execute(sql, targetDetails);
                return i;
            }
        }

        public int DeleteTargetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public TargetDetails GetTargetDetailById(int id)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// 显示目标详情信息
        /// </summary>
        /// <returns></returns>
        public List<TargetDetails> GetTargetDetails()
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = @"select a.id,a.targetid, a.indextypeid,a.targetunitid,a.indexlevelid, a.feedbacknumid,a.starttime,a.finishtime,a.period,a.dutyunitid,a.dutyman,a.assessmentweight,a.reportedman,a.organizer,a.formula,a.source,a.indexdecompositionid,a.tabulation,a.affirmflow,a.annualtarget,b.name,c.targettypename,d.targetunitname,e.levelname,f.feedbackname,g.dutyunitname,h.id,h.month,h.targetdetailsid,h.monthtarget from TARGETDETAILS a inner join TARGET b on a.targetid=b.id inner join TARGETTYPE c on a.indextypeid=c.id inner join TARGETUNIT d on a.targetunitid=d.id inner join INDEXLEVEL e on a.indexlevelid = e.id inner join feedbacknum f on a.feedbacknumid = f.id inner join dutyunit g on a.dutyunitid=g.dutyunitid inner join indexdecomposition h on a.indexdecompositionid = h.id";
                IEnumerable<TargetDetails> targetDetailslist = conn.Query<TargetDetails>(sql, null);
                return targetDetailslist.ToList();
            }
        }

        public int UpdateTargetDetails(TargetDetails targetDetail)
        {
            throw new NotImplementedException();
        }
    }
}
