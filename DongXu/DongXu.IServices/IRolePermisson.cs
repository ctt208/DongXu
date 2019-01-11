using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DongXu.Entity;

namespace DongXu.IServices
{
    public interface IRolePermisson
    {
        List<RolePerMission> showRolesById(int id);
    }
}
