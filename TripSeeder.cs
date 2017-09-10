using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripApp.Models;

namespace TripApp
{
    public class TripSeeder
    {
        private TripContext _context;

        public TripSeeder(TripContext context)
        {
            _context = context;
        }

        public async Task EnsureSeed()
        {
            await _context.Database.EnsureCreatedAsync();

            if (!_context.Trips.Any())
            {
                // create entity
                var trip = new Trip
                {
                    UserName = "Me",
                    DateCreated = DateTime.Now,
                    Stops = new List<Stop>
                    {
                        new Stop { Name = "Home", Latitude = 47.5603017, Longtitude = 19.2290849, Order = 1 }
                    }
                };

                // add to db
                _context.Trips.Add(trip);
                _context.AddRange(trip.Stops);

                await _context.SaveChangesAsync();
            }

            
        }
    }
}
