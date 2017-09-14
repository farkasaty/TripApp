using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace TripApp.Models
{
    public class TripRepository : ITripRepository
    {
        private TripContext db;
        private readonly ILogger<TripRepository> _logger;

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
