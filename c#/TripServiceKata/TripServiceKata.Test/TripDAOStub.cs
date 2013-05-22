using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TripServiceKata.Trip;

namespace TripServiceKata.Test
{
    class TripDAOStub: ITripDAO
    {
        List<Trip.Trip> ITripDAO.FindTripsByUser(User.User user)
        {
            return user.Trips();
        }
    }
}
