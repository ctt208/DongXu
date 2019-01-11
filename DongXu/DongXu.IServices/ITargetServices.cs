using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.IServices
{
    using DongXu.Entity;
    public interface ITargetServices
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        int AddTarget(Target target);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        int DeleteTarget(int Id);
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="target"></param>
        /// <returns></returns>
        int UpdateTarget(Target target);
        /// <summary>
        /// 获取所有目标
        /// </summary>
        /// <returns></returns>
        List<Target> GetTargets();
    }
}
