using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    public class Status
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 状态名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 状态图片
        /// </summary>
        public string Image { get; set; }
        /// <summary>
        /// 目标详情ID
        /// </summary>
        public int TargetDetailsId { get; set; }
    }
}
