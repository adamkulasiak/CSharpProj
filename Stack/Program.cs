using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < 10; i++)
            {
                numbers.Push(i);
            }

            Console.WriteLine("Zawartosc stosu: ");
            foreach (var item in numbers)
            {
                Console.Write(item+ ", ");
            }
            Console.WriteLine();
            Console.WriteLine("Usuwam 2 elementy ze stosu");
            numbers.Pop();
            numbers.Pop();

            Console.WriteLine("Zawartosc stosu po usunieciu: ");
            foreach (var item in numbers)
            {
                Console.Write(item+ ", ");
            }
            Console.ReadKey();
        }
    }
}
