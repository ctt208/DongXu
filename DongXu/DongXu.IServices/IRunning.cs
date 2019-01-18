using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.IServices
{
    using Entity;
    public interface IRunning
    {
        /// <summary>
        /// 获取运行情况
        /// </summary>
        /// <returns></returns>
        List<TargetDetails> GetRunnings();
    }
}
