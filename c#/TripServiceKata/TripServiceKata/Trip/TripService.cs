using System.Collections.Generic;
using TripServiceKata.Exception;
using TripServiceKata.User;

namespace TripServiceKata.Trip
{
    public class TripService
    {
        private ITripDAO tripDao;
        public TripService(ITripDAO tripDao)
        {
            this.tripDao = tripDao;
        }

        public List<Trip> GetTripsByUser(User.User loggedUser, User.User user)
        {
            ValidateUser(loggedUser);

            return user.IsFriendWith(loggedUser) ? tripDao.FindTripsByUser(user) : new List<Trip>();
        }

        private void ValidateUser(User.User loggedUser)
        {
            if (loggedUser == null)
            {
                throw new UserNotLoggedInException();
            }
        }
    }

}
