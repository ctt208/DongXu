using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.IServices
{
    using DongXu.Entity;
    public interface IStateService
    {
        /// <summary>
        /// 显示AAA
        /// </summary>
        /// <returns></returns>
        List<State> GetStates();
        /// <summary>
        /// 显示AA
        /// </summary>
        /// <returns></returns>
        List<State> States();
    }
}
