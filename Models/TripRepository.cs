using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripApp.Models
{
    public class TripRepository : ITripRepository
    {
        private TripContext db;

        public TripRepository(TripContext context)
        {
            db = context;
        }

        public List<Trip> GetAllTrips()
        {
            return db.Trips.ToList();
        }
    }
}
