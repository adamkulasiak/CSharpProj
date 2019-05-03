using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortedListt
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> sl = new SortedList<int, string>();
            sl.Add(1, "One");
            sl.Add(2, "Two");
            sl.Add(3, "Three");
            sl.Add(4, "Four");
            sl.Add(5, "Five");
            sl.Add(6, "Six");
            sl.Add(7, "Seven");
            sl.Add(8, "Eight");
            sl.Add(9, "Nine");
            sl.Add(10, "Ten");
            int key = 1;
            string val;
            do
            {
                try
                {
                    Console.Write("Podaj klucz: ");
                    key = int.Parse(Console.ReadLine());
                    Console.Write("Podaj wartosc: ");
                    val = Console.ReadLine();
                    sl.Add(key, val);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (key != 0);
            for (int i = 0; i < sl.Count; i++)
            {
                Console.WriteLine("key: {0}, value: {1}", sl.Keys[i], sl.Values[i]);
            }

            Console.ReadKey();
        }
    }
}
