using System;

namespace SystemSmartHouse
{
    public class ServiceController : GeneralService,IController
    {
        public bool Signal { get; set; }
    }
}