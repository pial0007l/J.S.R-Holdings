

namespace J.S.R_Holdings.Services
{
    public class ServiceFactory
    {
        public PassengerServices GetPersonServicesInstance()
        {
            return new PassengerServices();
        }
    }
}
