using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TripServiceKata.Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void IsFriendWith_Friends_ReturnTrue()        
        {
            User.User john = new User.User();
            User.User loggedUser = new User.User();
            john.AddFriend(loggedUser);

            Assert.IsTrue(john.IsFriendWith(loggedUser));
        }

        [TestMethod]
        public void IsFriendWith_NotFriends_ReturnFalse()
        {
            User.User john = new User.User();
            User.User loggedUser = new User.User();
           

            Assert.IsFalse(john.IsFriendWith(loggedUser));
        }
    }
}
