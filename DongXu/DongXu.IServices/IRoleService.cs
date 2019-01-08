using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.IServices
{
    
    using DongXu.Entity;
    
    public interface IRoleService
    {
        /// <summary>
        /// 角色显示
        /// </summary>
        /// <returns></returns>
        List<Roles> GetRoles(string name);
        /// <summary>
        /// 角色删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int DelteRole(int id);
        /// <summary>
        /// 角色查询
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        //List<Roles> GetRolescha(string name);
        /// <summary>
        /// 角色添加
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        int AddRoles(Roles r);
    }
}
