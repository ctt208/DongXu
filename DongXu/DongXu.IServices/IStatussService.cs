using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.IServices
{
    using DongXu.Entity;
    
    public interface IStatussService
    {
        List<Statuss> GetStatusses();
    }
}
