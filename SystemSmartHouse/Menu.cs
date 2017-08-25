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
            Console.Clear();
            char key;
            Console.WriteLine("Write Password:");
            string checkPassword = Console.ReadLine();
            if (checkPassword == user.Password)
            {
                for (;;)
                {
                    Console.WriteLine("0-Automate house");
                    Console.WriteLine("1-Resource");
                    key = Console.ReadKey().KeyChar;
                    if (key == '0') {
                        service.Controller.handler();
                    }
                    else if (key == '1')
                    {
                        service.Resource.handler();
                    }

                    //serviceresource.CheckState();
                }
            }
            else
            {
                Console.WriteLine("Wrong password!");
                Console.ReadLine();
                Handler();
            }
        }
    }


}