using System;

namespace q3
{
    public delegate void TrafficDel();
    class TrafficSignal
    {
        public void Yellow()
        {
            Console.WriteLine("Yellow");
        }
        public void Green()
        {
            Console.WriteLine("Green");
        }
        public void Red()
        {
            Console.WriteLine("Red");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //TrafficSignal class object
            TrafficSignal trafficSignal = new TrafficSignal();
            
            //Create and assign the delegate to Red delegate method and then call it
            TrafficDel signalDelegate = trafficSignal.Red;
            signalDelegate();

            //Assign the delegate to Yellow delegate method and then call it
            signalDelegate = trafficSignal.Yellow;
            signalDelegate();

            //Assign the delegate to Green delegate method and then call it
            signalDelegate = trafficSignal.Green;
            signalDelegate();

            
        }
    }
}
