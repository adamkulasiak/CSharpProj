using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kolekcje
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<string> names = new List<string>(){"Ala", "Adam", "Marta", "Zenon", "Katarzyna", "Kaya" };
            var sortredNames = names.OrderBy(x => x.Length);
            var test = names.Where(x => !x.Contains('a'));

            Console.WriteLine("before");
            Console.WriteLine();
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            Console.WriteLine("after");
            Console.WriteLine();
            foreach (var item in sortredNames)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            foreach (var item in test)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
