using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpZaliczenie
{
    class ProgramManager
    {
        private WorkerManager _workerManager;

        public ProgramManager()
        {
            _workerManager = new WorkerManager();
        }

        private void PokazMenu()
        {
            Console.Clear();
            Console.WriteLine("Wybierz co chcesz zrobic.");
            Console.WriteLine("1. Dodaj pracownika");
            Console.WriteLine("2. Usun pracownika");
            Console.WriteLine("0. Koniec");
        }

        private int WybranaAkcja()
        {
            Console.Write("Akcja nr: ");
            string akcja = Console.ReadLine();
            if (string.IsNullOrEmpty(akcja))
            {
                return -1;
            }
            return int.Parse(akcja);
        }

        public void Start()
        {
            int akcja;
            do
            {
                PokazMenu();
                akcja = WybranaAkcja();

                switch (akcja)
                {
                    case 1:
                        DodajPracownika();
                        Console.ReadKey();
                        break;

                    case 2:
                        UsunPracownika();
                        Console.ReadKey();
                        break;
                }
            } while (akcja != 0);
        }

        private void UsunPracownika()
        {
            Console.WriteLine("Usun pracownika");
        }

        private void DodajPracownika()
        {
            Console.WriteLine("Dodaj pracownika");
        }
    }

}
