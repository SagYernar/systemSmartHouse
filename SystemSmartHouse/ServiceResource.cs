using System;

namespace SystemSmartHouse
{
    public class ServiceResource:GeneralService,IServiceResource
    {
        public Water water;
        public Food food;
        public Electricity electricity;
        public ServiceResource()
        {
            
        }
        public void CheckState()
        {
            if (water.CheckState())
            {
                
            }
        }

    }
}