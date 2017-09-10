using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripApp.Models
{
    public class TripRepository : ITripRepository
    {
        private TripContext db;
        private ILogger<TripRepository> _logger;

        public TripRepository(TripContext context, ILogger<TripRepository> logger)
        {
            db = context;
            _logger = logger;
        }

        public List<Trip> GetAllTrips()
        {
            _logger.LogInformation("We are getting all the trips.");

            return db.Trips.ToList();
        }
    }
}
