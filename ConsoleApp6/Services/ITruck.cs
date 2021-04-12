using System;

namespace ConsoleApp6.Services
{
    public interface ITruck
    {
        void Drive();
    }

    class ScaniaTruck : ITruck
    {
        private readonly IBilRadio _bilradio;

        public ScaniaTruck(IBilRadio bilradio)
        {
            _bilradio = bilradio;
        }
        public void Drive()
        {
            _bilradio.Play();
            //Drive...
            for(int i = 0; i < 10; i++)
                Console.WriteLine("Brum brum brum");
            _bilradio.Stop();
        }
    }
}