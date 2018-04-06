using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using J.S.R_Holdings.Database;
using J.S.R_Holdings.Entity;

namespace J.S.R_Holdings.Services
{
    public class PassengerServices
    {
       private static PassengerDataAcces passengerDataAccess = new PassengerDataAcces();

        public int Add(Passenger passenger)
        {
            return passengerDataAccess.Add(passenger);
        }
        public int Remove(Passenger passenger)
        {
            return passengerDataAccess.Remove(passenger);
        }
        public int Update(Passenger passenger)
        {
            return passengerDataAccess.Update(passenger);
        }

        public Passenger GetByPassport(Passenger passenger)
        {
           return PassengerServices.passengerDataAccess.GetByPassport(passenger);
        }

        public List<Passenger> GetListByAgent(Passenger passenger)
        {
            return passengerDataAccess.GetListByAgent(passenger);
        }
        public List<Passenger> GetListByCompany(Passenger passenger)
        {
            // return restaurantDataAccess.GetSearchListByName(restaurant);
            return passengerDataAccess.GetListByCompany(passenger);
        }
        public List<Passenger> GetListByPassport(Passenger passenger)
        {
            // return restaurantDataAccess.GetSearchListByName(restaurant);
            return passengerDataAccess.GetListByPassport(passenger);
        }
    }
}
