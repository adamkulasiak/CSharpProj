using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> colors = new Dictionary<string, string>();
            colors.Add("red", "czerwony");
            colors.Add("blue", "niebieski");
            colors.Add("green", "zielony");
            colors.Add("yellow", "zolty");
            colors.Add("black", "czarny");
            colors.Add("white", "bialy");
            colors.Add("orange", "pomaranczowy");

            var orderByPl = colors.OrderBy(x => x.Value).ToList();
            var orderbByEng = colors.OrderBy(x => x.Key).ToList();

            foreach (var item in orderByPl)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var item in orderbByEng)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
        
    }
}
