using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.IServices
{
    using Entity;
    public interface IPerMission
    {
        /// <summary>
        /// 添加权限
        /// </summary>
        /// <param name="perMission"></param>
        /// <returns></returns>
        int AddPerMission(PerMission perMission);
        /// <summary>
        /// 显示权限
        /// </summary>
        /// <returns></returns>
        List<PerMission> GetPerMissions();
        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeletePerMission(int id);
        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="perMission"></param>
        /// <returns></returns>
        int UpdatePerMission(PerMission perMission);
        /// <summary>
        /// 根据ID显示单个权限信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        PerMission GetPerMissionById(int id);
    }
}
