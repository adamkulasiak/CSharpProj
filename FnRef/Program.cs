using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FnRef
{
    class Program
    {
        static void Inkrementacja(int l)
        {
            l++;
        }

        static void InkrementacjaRef(ref int l)
        {
            l++;
        }

        static void Main(string[] args)
        {
            int liczba = 0;
            Console.WriteLine("Liczba: {0}", liczba);
            Inkrementacja(liczba);
            Console.WriteLine("Inkrementacja przez wartosc: {0}", liczba);
            InkrementacjaRef(ref liczba);
            Console.WriteLine("Inkrementacja przez referencje: {0}", liczba);

            Console.ReadKey();
        }
    }
}
