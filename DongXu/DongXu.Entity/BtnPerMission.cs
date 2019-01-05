using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 按钮权限关联表
    /// </summary>
    public class BtnPerMission
    {
        /// <summary>
        /// 主键ID
        /// </summary>
        public int BtnPerMissionID { get; set; }
        /// <summary>
        /// 按钮名称
        /// </summary>
        public string ButtonName { get; set; }
        /// <summary>
        /// 权限ID
        /// </summary>
        public int PerMissionID { get; set; }
        /// <summary>
        /// 员工Id
        /// </summary>
        public int EmploYeeID { get; set; }
    }
}
