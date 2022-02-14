using System;

namespace les01
{
    class Program
    {
        static void Main(string[] args)
        {
            int tijd = 0;
            Console.WriteLine(tijd);
            System.Threading.Thread.Sleep(1000);
            while (tijd != -1) {
                System.Threading.Thread.Sleep(1000);
                string time = DateTime.Now.ToString("h:mm:ss tt");
                Console.WriteLine("Het is nu {0}", time);
            }
        }
    }
}
