using System;

namespace SystemSmartHouse
{
    public class Water:IResource
    {
        private bool state;
        public Water()
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
            if (!state) {
                Console.WriteLine("Enough water!");
            }
            else
                Console.WriteLine("Not enough water!");
        }

        public void DistributeResource()
        {
            Console.WriteLine("Water successfully distributed!");
        }

        public void MakeRequest()
        {
            Console.WriteLine("Not enough water! You must make request!");
        }

  
    }
}