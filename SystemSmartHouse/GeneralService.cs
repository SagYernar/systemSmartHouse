using System;

namespace SystemSmartHouse
{
    public class GeneralService : IGeneralService
    {
        public int NumberOfService { get; set; }

        ServiceController controller;
        ServiceResource resource;
        public ServiceController Controller {
            get
            {
                return controller;
            }
        }

        public ServiceResource Resource {
            get
            {
                return resource;
            }
        }


        public GeneralService()
        {
            controller = new ServiceController();
            resource = new ServiceResource();
        }
       
        public void DeleteService()
        {
            throw new NotImplementedException();
        }

        public GeneralService RegistryService( )
        {
            throw new NotImplementedException();
        }
    }
}