using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Models;

namespace Web.Api
{
    public class CitiesDataStore
    {
        public static CitiesDataStore Current { get; } = new CitiesDataStore();
        public List<CityDto> Cities { get; set; }

        public CitiesDataStore()
        {
            // init dummy data 
            Cities = new List<CityDto>()
            {
                new CityDto()
                {
                    Id = 1,
                    Name = "Linköping",
                    Description = "My hometown",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Stora Torget",
                            Description = "Ett torg",
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Trädgårstorget",
                            Description = "Ett annat torg"
                        }
                    }
                },
                new CityDto()
                {
                    Id = 2,
                    Name = "Stockholm",
                    Description = "Capital of Sweden",
                    PointsOfInterest = new List<PointOfInterestDto>()
                    {
                        new PointOfInterestDto()
                        {
                            Id = 1,
                            Name = "Södermalm",
                            Description = "Hippsterställe",
                        },
                        new PointOfInterestDto()
                        {
                            Id = 2,
                            Name = "Sergelstorg",
                            Description = "Knarkartorg"
                        }
                    }
                }
            };

        }
    }
}
