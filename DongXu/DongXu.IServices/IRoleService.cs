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
        int DelRoles(int id);
        /// <summary>
        /// 角色添加
        /// </summary>
        /// <param name="r"></param>
        /// <returns></returns>
        int AddRoles(Roles r);
        /// <summary>
        /// 角色修改
        /// </summary>
        /// <param name="roles"></param>
        /// <returns></returns>
        int UpdateRoles(Roles role);
        List<ShowRoles> RolesByID(int id);

    }
}
