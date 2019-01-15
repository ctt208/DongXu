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
    [RoutePrefix("State")]
    public class StateAPIController : ApiController
    {
        public IStateService stateService { get; set; }
        [HttpGet]
        [Route("GetStates")]
        public List<State> GetStates()
        {
            return stateService.GetStates();
        }
        [HttpGet]
        [Route("States")]
        public List<State> States()
        {
            return stateService.States();
        }
    }
}