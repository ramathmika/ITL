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
            TrafficSignal tr = new TrafficSignal();
            TrafficDel tryy = tr.Yellow;
            tryy();
            TrafficDel trr = tr.Red;
            trr();
            TrafficDel trg = tr.Green;
            trg();
        }
    }
}
