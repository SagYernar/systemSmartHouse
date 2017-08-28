using System;

namespace SystemSmartHouse
{
    public class Food : IResource
    {
        private bool state;
        public Food()
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
                Console.WriteLine("Enough food!");
            }
            else
                Console.WriteLine("Not enough food!");
        }

        public void DistributeResource()
        {
            
        }

        public void MakeRequest()
        {
            Console.WriteLine("Not enough food!! You must make request!");
        }
    }
}