using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using TripServiceKata.Trip;

namespace TripServiceKata.Test
{
    class TripServiceStub : TripService
    {
        public TripServiceStub(ITripDAO dao): base(dao)
        {
            
        }

        public TripServiceStub():base(new TripDAOStub())
        {
            
        }
       
    }
}
