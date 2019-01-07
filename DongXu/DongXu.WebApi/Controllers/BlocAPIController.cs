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
        [Route("AddBloc")]
        [HttpPost]
        public int AddBloc(Bloc blocs)
        {
            return BlocServices.AddBloc(blocs);
        }
        [Route("GetBloc")]
        [HttpGet]
        public List<Bloc> GetBlocs()
        {
            return BlocServices.GetBlocs();
        }
        [Route("UpdateBloc")]
        [HttpPost]
        public int UpdateBloc(Bloc blocs)
        {
            return BlocServices.UpdateBloc(blocs);
        }
    }
}
