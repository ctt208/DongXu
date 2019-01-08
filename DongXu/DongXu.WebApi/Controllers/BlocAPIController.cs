using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DongXu.WebApi.Controllers
{
    using DongXu.Entity;
    using DongXu.IServices;
    using DongXu.Services;
    [RoutePrefix("Bloc")]
    public class BlocAPIController : ApiController
    {
        public IBlocServices BlocServices { get; set; }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="blocs"></param>
        /// <returns></returns>
        [Route("AddBloc")]
        [HttpPost]
        public int AddBloc(Bloc blocs)
        {
            return BlocServices.AddBloc(blocs);
        }
        /// <summary>
        /// 显示
        /// </summary>
        /// <returns></returns>
        [Route("GetBloc")]
        [HttpGet]
        public List<Bloc> GetBlocs()
        {
            return BlocServices.GetBlocs();
        }
        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="blocs"></param>
        /// <returns></returns>
        [Route("UpdateBloc")]
        [HttpPost]
        public int UpdateBloc(Bloc blocs)
        {
            return BlocServices.UpdateBloc(blocs);
        }
        /// <summary>
        /// 反填
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        [Route("GetBlocById")]
        [HttpGet]
        public List<Bloc> GetBlocById(int Id)
        {
            return BlocServices.GetBlocById(Id);
        }
    }
}
