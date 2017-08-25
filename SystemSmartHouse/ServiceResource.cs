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
            water = new Water();
            food = new Food();
            electricity = new Electricity();
        }

        public void handler()
        {
            char key;
            Console.Clear();
            Console.WriteLine("0-Water");
            Console.WriteLine("1-Electricity");
            Console.WriteLine("2-Food");
            key = Console.ReadKey().KeyChar;
            if (key == '0')
            {
                Console.WriteLine("0-Check state of water");
                Console.WriteLine("1-Make request for water");
                Console.WriteLine("2-Distribute water");
                key = Console.ReadKey().KeyChar;
                if (key == '0')
                {
                    water.CheckState();
                }
                else if (key == '1')
                {
                    water.MakeRequest();
                }
                else if (key == '2')
                {
                    water.DistributeResource();
                }
            }
            else if (key == '1')
            {
                Console.WriteLine("0-Check state of Electricity");
                Console.WriteLine("1-Make request for Electricity");
                Console.WriteLine("2-Distribute Electricity");
                key = Console.ReadKey().KeyChar;
                if (key == '0')
                {
                    electricity.CheckState();
                }
                else if (key == '1')
                {
                    electricity.MakeRequest();
                }
                else if (key == '2')
                {
                    electricity.DistributeResource();
                }
            }
            else if (key == '2')
            {
                Console.WriteLine("0-Check state of Food");
                Console.WriteLine("1-Make request for Food");
                Console.WriteLine("2-Distribute Food");
                key = Console.ReadKey().KeyChar;
                if (key == '0')
                {
                    food.CheckState();
                }
                else if (key == '1')
                {
                    food.MakeRequest();
                }
                else if (key == '2')
                {
                    food.DistributeResource();
                }
            }
        }
    }
}