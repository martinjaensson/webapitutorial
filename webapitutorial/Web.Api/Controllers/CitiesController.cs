using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entities;
using Web.Api.Models;
using Web.Api.Services;

namespace Web.Api.Controllers
{
    [Route("api/cities")]
    public class CitiesController : Controller
    {
        private CityInfoContext _context; 
        public CitiesController(CityInfoContext context)
        {
            _context = context;
        }

        [HttpGet()]
        public IActionResult GetCities() {
            var cityEntities = _context.Cities.ToList();
            var result = new List<CityWithoutPointsOfInterestDto>();
            foreach (var cityEntity in cityEntities)
            {
                result.Add(new CityWithoutPointsOfInterestDto()
                {
                    Id = cityEntity.Id,
                    Description = cityEntity.Description,
                    Name = cityEntity.Name
                });
            }
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetCity(int id, bool includePointsOfInterest)
        {
            if (includePointsOfInterest)
            {
                var cityEntity = _context.Cities.Where(c => c.Id == id).FirstOrDefault();
                var result = new CityDto() {
                    Id = cityEntity.Id,
                    Description = cityEntity.Description,
                    Name = cityEntity.Name,
                    PointsOfInterest = cityEntity.PointsOfInterest
                };
            }
            //var cityToReturn = CitiesDataStore.Current.Cities.FirstOrDefault(c => c.Id == id);
            //if (cityToReturn == null) {
            //    return NotFound();
            //}
            //return Ok(cityToReturn);
        }
    }
}
