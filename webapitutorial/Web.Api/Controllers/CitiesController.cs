using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {

        [HttpGet()]
        public IActionResult GetCities() {
            return Ok(new JsonResult(CitiesDataStore.Current.Cities));
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id)
        {
            var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            if (cityToReturn == null) {
                return NotFound();
            }

            return Ok(cityToReturn);
        }
    }
}
