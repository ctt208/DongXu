using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 反馈表
    /// </summary>
   public class Feedback
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 反馈动作名
        /// </summary>
        public string FeedbackName { get; set; }
        /// <summary>
        /// 反馈图片
        /// </summary>
        public string FeedbackPicture { get; set; }
        /// <summary>
        /// 目标详情Id
        /// </summary>
        public int TargetDetailsId { get; set; }
    }
}
