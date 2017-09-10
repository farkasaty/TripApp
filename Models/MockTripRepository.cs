using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripApp.Models
{
    public class MockTripRepository : ITripRepository
    {
        public List<Trip> GetAllTrips()
        {
            var list = new List<Trip>
            {
                new Trip{
                    UserName = "You",
                    DateCreated = DateTime.Now.AddDays(100),
                    Stops = new List<Stop>{
                        new Stop { Name = "Home", Latitude = 47.5603017, Longtitude = 19.2290849, Order = 1 },
                        new Stop { Name = "Work", Latitude = 47.4903011, Longtitude = 19.1026445, Order = 2 }
                    }
                },
                new Trip{
                    UserName = "You",
                    DateCreated = DateTime.Now.AddDays(100),
                    Stops = new List<Stop>{
                        new Stop { Name = "Home", Latitude = 47.5603017, Longtitude = 19.2290849, Order = 1 },
                        new Stop { Name = "Work", Latitude = 47.4903011, Longtitude = 19.1026445, Order = 2 }
                    }
                }
            };

            return list;
        }
    }
}
