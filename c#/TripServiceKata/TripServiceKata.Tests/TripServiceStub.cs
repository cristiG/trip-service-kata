using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TripServiceKata.Trip;

namespace TripServiceKata.Tests
{
    class TripServiceStub : TripService
    {
        public TripServiceStub()
        {
            StubUser = new User.User();
            stubTrips = new List<Trip.Trip>();
        }

        protected override User.User GetLoggedUser()
        {
            return StubUser;
        }

        protected override List<Trip.Trip> FindTripsByUser(User.User user)
        {
            return user.Trips;
        }

        public User.User StubUser { get; set; }

        public List<Trip.Trip> stubTrips { get; set; }
    }
}
