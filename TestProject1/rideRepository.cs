using System.Collections.Generic;
using CabServiceDay23;

namespace TestProject1
{

public class rideRepository
    {
        public Dictionary<string, List<Ride>> rideRepository;
        public void AddToRideRepository(string userId, Ride ride)
        {
            if (rideRepository.ContainsKey(userId))
            {
                rideRepository[userId].Add(ride);
            }
            else
            {
                rideRepository.Add(userId, new List<Ride>());
            }
        }
        public rideRepository()
        {
            rideRepository = new Dictionary<string, List<Ride>>();
        }
        public List<Ride> returnListByUserId(string userId)
        {
            if (rideRepository.ContainsKey(userId))
            {
                return rideRepository[userId];
            }
            else
                throw new InvoiceGeneratorException(InvoiceGeneratorException.ExceptionType.INVALID_USER_ID, "Invalid user id encountered");
        }
    }
}