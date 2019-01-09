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
    [RoutePrefix("DongXu")]
    public class EmployeeAPIController : ApiController
    {
        public IEmployeeServices EmployeeServices { get; set; }
        [Route("AddEmployee")]
        [HttpPost]
        public int AddEmployee(Employee employee)
        {
            return EmployeeServices.AddEmployee(employee);
        }
    }
}
