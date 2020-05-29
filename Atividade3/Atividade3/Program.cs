using System;

namespace Atividade3
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2019, 12, 24);
            DateTime d2 = new DateTime(2019, 12, 24, 15, 20, 12);
            DateTime d3 = new DateTime(2019, 12, 24, 15, 20, 12, 500);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;
            
            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);
        }
    }
}
