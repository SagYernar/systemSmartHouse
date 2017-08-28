using System;

namespace SystemSmartHouse
{
    public class Electricity : IResource
    {

        private bool state;
        public Electricity()
        {
            state = true;
        }

        public bool GetState
        {
            get { return state; }
            set { state = value; }
        }

        public void CheckState()
        {
            if (!state)
            {
                Console.WriteLine("Voltage is exists!");
            }
            else
                Console.WriteLine("Voltage isn't exists!");
        }

        public void DistributeResource()
        {
            Console.WriteLine("Electricity successfully сirculated!");
        }

        public void MakeRequest()
        {
            Console.WriteLine("Not enough water! You must make request!");
        }
    }
}