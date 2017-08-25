using System;

namespace SystemSmartHouse
{
    public class ServiceController : GeneralService,IController
    {
        public bool Signal { get; set; }

        public void handler()
        {
            char key;
            Console.Clear();
            Console.WriteLine("0-Turn On");
            Console.WriteLine("1-Turn Off");
            key = Console.ReadKey().KeyChar;
            if (key == '0')
            {
                if (!Signal)
                {
                    Signal = true;
                }
            }
            else if (key == '1')
            {
                if (Signal)
                {
                    Signal = false;
                }
            }
            
        }
    }
}