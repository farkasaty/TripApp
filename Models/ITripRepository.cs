using System.Collections.Generic;

namespace TripApp.Models
{
    public interface ITripRepository
    {
        List<Trip> GetAllTrips();
    }
}