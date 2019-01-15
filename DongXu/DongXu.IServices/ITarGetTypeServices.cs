using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.IServices
{
    using Entity;
    public interface ITarGetTypeServices
    {
        /// <summary>
        /// 显示目标类别
        /// </summary>
        /// <returns></returns>
        List<TarGetType> GetTarGetTypes();
    }
}
