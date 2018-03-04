using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entities;

namespace Web.Api.Controllers
{
    public class DummyController : Controller
    {
        private CityInfoContext _cityInfoContext;

        public DummyController(CityInfoContext cityInfoContext)
        {
            this._cityInfoContext = cityInfoContext;
        }

        [HttpGet]
        [Route("api/testdatabase")]
        public IActionResult TestDataBase() {
            return Ok();
        }
    }
}
