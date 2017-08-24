using System;

namespace SystemSmartHouse
{
    public class Menu : IMenu
    {
       
        IGeneralService serviceresource = new ServiceResource();

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
            for (;;)
            {
                key = Console.ReadKey().KeyChar;
                if(key == '1') { }
                //serviceresource.CheckState();
            }
        }
        
    }


}