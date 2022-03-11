using System;

namespace les01ReturnFunctie
{
    class Kishan
    {
        string firstName;
        public string FirstName { get { return firstName; } set { firstName = value; } }

        public Kishan(string naam)
        {
            firstName = naam;
        }
        public string naam()
        {
            string x = "kishan";
            return x;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Kishan x = new Kishan("kishan");
            Console.WriteLine("{0}", naam);
        }
    }
}