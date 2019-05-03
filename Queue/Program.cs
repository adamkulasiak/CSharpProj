using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numbers = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Enqueue(i);
            }

            Console.WriteLine("Zawartosc kolejki: ");
            foreach (var item in numbers)
            {
                Console.Write(item +",");
            }
            Console.WriteLine();

            Console.WriteLine("Usuwam 2 elementy z kolejki: ");
            numbers.Dequeue();
            numbers.Dequeue();

            Console.WriteLine("Zawartosc kolejki po usunieciu 2 elementow: ");
            foreach (var item in numbers)
            {
                Console.Write(item + ",");
            }
            Console.ReadKey();
        }
    }
}
