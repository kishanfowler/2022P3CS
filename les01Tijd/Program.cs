using System;

namespace les01Tijd
{
    class Program
    {
        static void Main(string[] args)
        {
            //int voor de loop
            int tijd = 0;
            Console.WriteLine(tijd);
            //zodat ie elke seconde iets print
            System.Threading.Thread.Sleep(1000);
            //de loop zelf
            while (tijd != -1) {
                System.Threading.Thread.Sleep(1000);
                string time = DateTime.Now.ToString("h:mm:ss tt");
                Console.WriteLine("Het is nu {0}", time);
            }
        }
    }
}
