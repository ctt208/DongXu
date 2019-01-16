using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DongXu.Services
{
    using DongXu.IServices;
    using Dapper;
    using Oracle.ManagedDataAccess.Client;
    using DongXu.Entity;
    using DongXu.Common;
    public class TarGetTypeServices:ITarGetTypeServices
    {
        /// <summary>
        /// 显示目标类别信息
        /// </summary>
        /// <returns></returns>
        public List<TarGetType> GetTarGetTypes()
        {
            using (OracleConnection conn = DapperHelper.GetConnectionString())
            {
                conn.Open();
                string sql = " select TarGetTypeID,TarGetTypeName from TarGetType";
                IEnumerable<TarGetType> tarGetTypeList = conn.Query<TarGetType>(sql, null);
                return tarGetTypeList.ToList();
            }
        }      
    }
}
