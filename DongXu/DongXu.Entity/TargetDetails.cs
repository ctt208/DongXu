using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 目标详情表
    /// </summary>
    public class TargetDetails
    {
        /// <summary>
        /// 主键Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 目标Id
        /// </summary>
        public int TargetId { get; set; }
        public string TargetName { get; set; }
        public string StatusImage { get; set; }
        public string StatusName { get; set; }
        public string BlocName { get; set; }
        public string feedbackname { get; set; }
        public string targettypename { get; set; }
        public string Name { get; set; }
        public int Numberids { get; set; }
        public double Per { get; set; }
        /// <summary>
        /// 目标类别Id
        /// </summary>
        public int IndexTypeId { get; set; }
        /// <summary>
        /// 目标状态ID
        /// </summary>
        public int StatusId { get; set; }
        /// <summary>
        /// 目标单位Id
        /// </summary>
        public int BlocId { get; set; }
        /// <summary>
        /// 目标等级Id
        /// </summary>
        public string IndexLevelId { get; set; }
        /// <summary>
        /// 反馈频次Id
        /// </summary>
        public int FeedbackNumId { get; set; }
        /// <summary>
        /// 开始时间
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime FinishTime { get; set; }
        /// <summary>
        /// 责任人
        /// </summary>
        public string DutyMan { get; set; }
        /// <summary>
        /// 考核权重
        /// </summary>
        public string AssessmentWeight { get; set; }
        /// <summary>
        /// 填报人
        /// </summary>
        public string ReportedMan { get; set; }
        /// <summary>
        /// 协办方
        /// </summary>
        public string Organizer {get;set;}
        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
        /// <summary>
        /// 确认流程
        /// </summary>
        public string Affirmflow { get; set; }
        /// <summary>
        /// 年度目标
        /// </summary>
        public string AnnualTarget { get; set; }
    }
}
