using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TripServiceKata.Exception;
using TripServiceKata.Trip;

namespace TripServiceKata.Test
{
    [TestClass]
    public class TripServiceTest
    {
        private static User.User NON_LOGGED_USER = null;
        private static User.User UNUSED_USER = null;

        [TestMethod]
        [ExpectedException(typeof(UserNotLoggedInException))]
        public void ThrowsExceptionWhenUserIsNotLogged()
        {
            TripService target = createStub();
            target.GetTripsByUser(NON_LOGGED_USER, UNUSED_USER);
        }

        [TestMethod]
        public void NoTripsReturnedWhenUserIsNotFriend()
        {
            TripService target = createStub();
            
            List<Trip.Trip> trips = target.GetTripsByUser(new User.User(), new User.User());

            Assert.AreEqual(0, trips.Count);
        }

        [TestMethod]
        public void ReturnsTripsWhenUserIsFriend()
        {
            User.User john = new User.User();
            User.User loggedUser = new User.User();
            john.AddFriend(loggedUser);
            john.AddTrip(new Trip.Trip());
            TripService service = createStub();

            List<Trip.Trip> trips = service.GetTripsByUser(loggedUser, john);

            Assert.AreEqual(john.Trips()[0], trips[0]);            
        }



        private TripService createStub()
        {
            return new TripServiceStub();
        }
    }
}
