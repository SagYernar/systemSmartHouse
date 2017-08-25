using System;

namespace SystemSmartHouse
{
    public class ServiceController :IController
    {
        public bool Signal { get; set; }

        public void Handler()
        {
            char key;

            for (;;)
            {
                Console.Clear();
                Console.WriteLine("0-Turn On");
                Console.WriteLine("1-Turn Off");
                Console.WriteLine("2-Back");
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
                else if (key == '2')
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }
}