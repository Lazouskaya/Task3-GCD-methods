using System;
using GCDMethods;


namespace GCDApplic
{
    class Program
    {
        static void Main(string[] args)
        {
            TimeSpan time = new TimeSpan();
            Console.WriteLine(Nod.Evclidean(12, 16, out time));
            Console.WriteLine(time);
            Console.WriteLine(Nod.Evclidean(out time, 18, 6, 27, 36));
            Console.WriteLine(time);
            Console.WriteLine(Nod.Stain(16, 12, out time));
            Console.WriteLine(time);
            Console.WriteLine(Nod.Stain(out time, 18, 6, 27, 36, 0, 0));
            Console.WriteLine(time);
            Console.ReadKey();
        }
    }
}
