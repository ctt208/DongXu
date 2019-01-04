using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Entity
{
    /// <summary>
    /// 权限表
    /// </summary>
    public class PerMission
    {
        /// <summary>
        /// 权限ID
        /// </summary>
        public int PerMissionID { get; set; }
        /// <summary>
        /// 权限名称
        /// </summary>
        public string PerMissionName { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime EstablishTime { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpTime { get; set; }
    }
}
