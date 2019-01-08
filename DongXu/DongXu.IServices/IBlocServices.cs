using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.IServices
{
    using DongXu.Entity;
   public interface IBlocServices
    {
        /// <summary>
        /// 添加组织名称
        /// </summary>
        /// <param name="blocs"></param>
        /// <returns></returns>
        int AddBloc(Bloc blocs);
        /// <summary>
        /// 获取组织名称
        /// </summary>
        /// <returns></returns>
        List<Bloc> GetBlocs();
        /// <summary>
        /// 修改组织名称
        /// </summary>
        /// <param name="blocs"></param>
        /// <returns></returns>
        int UpdateBloc(Bloc blocs);

        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        List<Bloc> GetBlocById(int Id);
     
    }
}
