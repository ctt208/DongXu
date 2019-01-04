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
        /// <summary>
        /// 指标类别Id
        /// </summary>
        public int IndexTypeId { get; set; }
        /// <summary>
        /// 指标单位Id
        /// </summary>
        public int TargetUnitId { get; set; }
        /// <summary>
        /// 主指标
        /// </summary>
        public string MainIndex { get; set; }
        /// <summary>
        /// 指标等级Id
        /// </summary>
        public int IndexLevelId { get; set; }
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
        /// 周期
        /// </summary>
        public string Period { get; set; }
        /// <summary>
        /// 负责单位Id
        /// </summary>
        public int DutyUnitId { get; set; }
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
        /// 计算公式
        /// </summary>
        public string Formula { get; set; }
        /// <summary>
        /// 数据来源
        /// </summary>
        public string Source { get; set; }
        /// <summary>
        /// 指标分解Id
        /// </summary>
        public int IndexdeCompositionId { get; set; }
        /// <summary>
        /// 支持表格
        /// </summary>
        public string Tabulation { get; set; }
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
