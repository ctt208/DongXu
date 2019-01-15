using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    public class State
    {
        /// <summary>
        /// 主键
        /// </summary>
        public int StateID { get; set; }
        /// <summary>
        /// 名称
        /// </summary>
        public string StateName { get; set; }
        /// <summary>
        /// 级别
        /// </summary>
        public string StateJB { get; set; }
        /// <summary>
        /// 红灯
        /// </summary>
        public int StateRed { get; set; }
        /// <summary>
        /// 黄灯
        /// </summary>
        public int StateYellow { get; set; }
        /// <summary>
        /// 绿灯
        /// </summary>
        public int StateGrenn { get; set; }
        /// <summary>
        /// 积分
        /// </summary>
        public int StateFen { get; set; }
    }
}
