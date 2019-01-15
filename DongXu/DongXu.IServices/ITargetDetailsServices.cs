using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.IServices
{
    using Entity;
    public interface ITargetDetailsServices
    {
        /// <summary>
        /// 添加目标详情
        /// </summary>
        /// <param name="perMission"></param>
        /// <returns></returns>
        int AddTargetDetails(TargetDetails targetDetails);
        /// <summary>
        /// 显示权限
        /// </summary>
        /// <returns></returns>
        List<TargetDetails> GetTargetDetails();
        /// <summary>
        /// 删除权限
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DeleteTargetDetails(int id);
        /// <summary>
        /// 修改权限
        /// </summary>
        /// <param name="perMission"></param>
        /// <returns></returns>
        int UpdateTargetDetails(TargetDetails targetDetail);
        /// <summary>
        /// 根据ID显示单个权限信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        TargetDetails GetTargetDetailById(int id);
    }
}
