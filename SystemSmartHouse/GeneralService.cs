using System;

namespace SystemSmartHouse
{
    public class GeneralService : IGeneralService
    {
        public int NumberOfService { get; set; }

        IController controller;
        IServiceResource resource;
        public IController Controller {
            get
            {
                return controller;
            }
        }

        public IServiceResource Resource {
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