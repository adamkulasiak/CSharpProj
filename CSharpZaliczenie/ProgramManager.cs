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
        private Printer _printer;

        public ProgramManager()
        {
            _workerManager = new WorkerManager();
            _printer = new Printer();
        }

        private void ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("Wybierz co chcesz zrobic.");
            Console.WriteLine("1. Dodaj pracownika");
            Console.WriteLine("2. Usun pracownika");
            Console.WriteLine("3. Lista wszystkich pracownikow");
            Console.WriteLine("4. Wyszukaj pracownika");
            Console.WriteLine("5. Podaj wszystkich pracownikow na danym stanowisku: ");
            Console.WriteLine("0. Koniec");
        }

        private int Action()
        {
            Console.Write("Akcja nr: ");
            string action = Console.ReadLine();
            if (string.IsNullOrEmpty(action))
            {
                return -1;
            }
            return int.Parse(action);
        }

        public void Start()
        {
            int action;
            do
            {
                ShowMenu();
                action = Action();

                switch (action)
                {
                    case 1:
                        AddWorker();
                        Console.ReadKey();
                        break;

                    case 2:
                        DeleteWorker();
                        Console.ReadKey();
                        break;

                    case 3:
                        ListAllWorkers();
                        Console.ReadKey();
                        break;

                    case 4:
                        FindWorker();
                        Console.ReadKey();
                        break;

                    case 5:
                        GetWorkersOnWorksite();
                        Console.ReadKey();
                        break;
                }
            } while (action != 0);
        }

        private WorkerData ReadWorkerData()
        {
            Console.WriteLine("Dodaj nowego pracownika: ");
            Console.Write("Imie: ");
            string imie = Console.ReadLine();
            Console.Write("Nazwisko: ");
            string nazwisko = Console.ReadLine();
            Console.Write("Wiek: ");
            int wiek = int.Parse(Console.ReadLine());
            Console.Write("Stanowisko: ");
            string stanowisko = Console.ReadLine();
            Console.Write("Pensja miesieczna: ");
            int pensja = int.Parse(Console.ReadLine());
            Console.Write("Ilosc dni urlopu do wykorzystania: ");
            int urlop = int.Parse(Console.ReadLine());
            return new WorkerData(imie, nazwisko, wiek, stanowisko, pensja, urlop);

        }

        private void GetWorkersOnWorksite()
        {
            Console.Clear();
            string worksite = GetWorkSite();
            var workers = _workerManager.GetWorkersOnWorksite(worksite);
            foreach (var item in workers)
            {
                _printer.PrintAllData(item);
            }
        }

        private void FindWorker()
        {
            Console.Clear();
            string input = FindByLastName();
            var workers = _workerManager.GetWorker(input);
            foreach (var item in workers)
            {
                _printer.PrintAllData(item);
            }
        }

        private void ListAllWorkers()
        {
            Console.Clear();
            Console.WriteLine("Lista pracownikow: ");
            Console.WriteLine();
            foreach (var worker in _workerManager.GetAllWorkers())
            {
                _printer.PrintAllData(worker);
            }
            Console.ReadKey();
        }

        private void DeleteWorker()
        {
            Console.Clear();
            int id = GetWorkerId();
            _workerManager.DeleteWorker(id);
            Console.WriteLine("Poprawnie usunieto pracownika");
        }

        private void AddWorker()
        {
            Console.Clear();
            WorkerData data = ReadWorkerData();
            Pracownik prac = _workerManager.AddWorker(data.Imie, data.Nazwisko, data.Wiek, data.Stanowisko, data.PensjaMiesieczna, data.IloscDniUrlopu);
            Console.Clear();
            Console.WriteLine("Pomyslnie dodano pracownika");
            _printer.PrintAllData(prac);
            Console.ReadKey();
        }

        private int GetWorkerId()
        {
            Console.Write("Podaj id pracownika: ");
            int id = int.Parse(Console.ReadLine());
            return id;
        }

        private string FindByLastName()
        {
            Console.Write("Podaj nazwisko pracownika ktorego chcesz wyszukac: ");
            string nazw = Console.ReadLine();
            return nazw;
        }

        private string GetWorkSite()
        {
            Console.Write("Podaj stanowisko: ");
            string worksite = Console.ReadLine();
            return worksite;
        }
    }

    class WorkerData
    {
        public string Imie { get; }
        public string Nazwisko { get; }
        public int Wiek { get; }
        public string Stanowisko { get; }
        public int PensjaMiesieczna { get; }
        public DateTime DataZatrudnienia { get; }
        public int IloscDniUrlopu { get; }

        public WorkerData(string imie, string nazwisko, int wiek, string stanowisko, int pensja, int urlop)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Wiek = wiek;
            Stanowisko = stanowisko;
            PensjaMiesieczna = pensja;
            DataZatrudnienia = DateTime.Now;
            IloscDniUrlopu = urlop;
        }
    }
}
