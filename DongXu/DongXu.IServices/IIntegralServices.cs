using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.IServices
{
    using DongXu.Entity;
   public interface IIntegralServices
    {
        /// <summary>
        /// 显示积分
        /// </summary>
        /// <returns></returns>
        List<Integral> GetIntegral();
    }
}
