using System;

namespace SystemSmartHouse
{
    public class ServiceController : GeneralService,IController
    {
        public SignalType Signal { get; set; }
    }
}