using System;
using ConsoleApp6.Services;

namespace ConsoleApp6
{
    public class TruckTest
    {
        private readonly ITruck _truck;

        public TruckTest(ITruck truck)
        {
            _truck = truck;
        }
        
        public void Run()
        {
            _truck.Drive();
        }
    }
}