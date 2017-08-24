using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemSmartHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new Menu();

            IResource resurce = new ServiceResource();

            IController controller = new ServiceController();
        }
    }
}
