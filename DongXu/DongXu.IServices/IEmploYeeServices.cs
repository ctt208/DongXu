using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.IServices
{
    using DongXu.Entity;
    public interface IEmploYeeServices
    {
        /// <summary>
        /// 新增员工
        /// </summary>
        /// <param name="emploYee"></param>
        /// <returns></returns>
        int AddEmploYee(EmploYee emploYee);
        /// <summary>
        /// 根据Id删除员工
        /// </summary>
        /// <param name="emploYeeId"></param>
        /// <returns></returns>
        int DeleteEmploYee(int emploYeeId);
        /// <summary>
        /// 获取所有员工
        /// </summary>
        /// <returns></returns>
        List<EmploYee> GetEmploYees();
        /// <summary>
        /// 修改员工信息
        /// </summary>
        /// <param name="emploYee"></param>
        /// <returns></returns>
        int UpdateEmploYee(EmploYee emploYee);
    }
}
