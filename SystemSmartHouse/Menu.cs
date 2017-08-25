using System;

namespace SystemSmartHouse
{
    public class Menu : IMenu
    {

        User user;
        IGeneralService service;
        public Menu()
        {
            user = new User();
            service = new GeneralService();
        }
        public void SetCommand(int command)
        {
            throw new NotImplementedException();
        }

        public int GetCommand()
        {
            throw new NotImplementedException();
        }

        public void Handler()
        {
            char key;
            Console.WriteLine("Write Password:");
            user.Password=Console.ReadLine();
            for (;;)
            {
                Console.WriteLine("0-Automate house");
                Console.WriteLine("1-Water");
                Console.WriteLine("2-Electricity");
                Console.WriteLine("3-Food");
                key = Console.ReadKey().KeyChar;
                if(key == '0') {
                    Console.Clear();
                    Console.WriteLine("0-Turn On");
                    Console.WriteLine("1-Turn Off");
                    if (key == '0')
                    {
                        if (!service.Controller.Signal)
                        {
                            service.Controller.Signal = true;
                        }
                    }
                }
                //serviceresource.CheckState();
            }
        }
        
    }


}