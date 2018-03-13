using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Api.Entities;
using Web.Api.Models;

namespace Web.Api
{
    public static class CityInfoContextExtensions
    {
        public static void EnsureSeedDataForContext(this CityInfoContext context)
        {
            if (context.Cities.Any())
            {
                return;
            }

            // init seed data
            // init dummy data 
            var cities = new List<City>()
            {
                new City()
                {
                    Name = "Linköping",
                    Description = "My hometown",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Stora Torget",
                            Description = "Ett torg",
                        },
                        new PointOfInterest()
                        {
                            Name = "Trädgårstorget",
                            Description = "Ett annat torg"
                        }
                    }
                },
                new City()
                {
                    Name = "Stockholm",
                    Description = "Capital of Sweden",
                    PointsOfInterest = new List<PointOfInterest>()
                    {
                        new PointOfInterest()
                        {
                            Name = "Södermalm",
                            Description = "Hippsterställe",
                        },
                        new PointOfInterest()
                        {
                            Name = "Sergelstorg",
                            Description = "Knarkartorg"
                        }
                    }
                }
            };
            context.Cities.AddRange(cities);
            context.SaveChanges();

        }
    }
}
