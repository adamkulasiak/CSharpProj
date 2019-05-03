using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpZaliczenie
{
    class Printer : IDrukujPracownikow
    {
        public void PrintAllData(Pracownik pracownik)
        {
            Console.WriteLine("Id: {0}", pracownik.Id);
            Console.WriteLine("Imie: {0}", pracownik.Imie);
            Console.WriteLine("Nazwisko: {0}", pracownik.Nazwisko);
            Console.WriteLine("Wiek: {0}", pracownik.Wiek);
            Console.WriteLine("Stanowisko: {0}", pracownik.Stanowisko);
            Console.WriteLine("Pensja miesieczna: {0}", pracownik.PensjaMiesieczna);
            Console.WriteLine("Data zatrudnienia: {0}", pracownik.DataZatrudnienia);
            Console.WriteLine("Ilosc dni urlopu: {0}", pracownik.IloscDniUrlopu);
            Console.WriteLine();
        }

        public void PrintAllData(IList<Pracownik> pracownicy)
        {
            int i = 1;
            foreach (var pracownik in pracownicy)
            {
                Console.WriteLine("----------{0}----------", i++);
                Console.WriteLine("Id: {0}", pracownik.Id);
                Console.WriteLine("Imie: {0}", pracownik.Imie);
                Console.WriteLine("Nazwisko: {0}", pracownik.Nazwisko);
                Console.WriteLine("Wiek: {0}", pracownik.Wiek);
                Console.WriteLine("Stanowisko: {0}", pracownik.Stanowisko);
                Console.WriteLine("Pensja miesieczna: {0}", pracownik.PensjaMiesieczna);
                Console.WriteLine("Data zatrudnienia: {0}", pracownik.DataZatrudnienia);
                Console.WriteLine("Ilosc dni urlopu: {0}", pracownik.IloscDniUrlopu);
                Console.WriteLine();
            }
        }
    }
}
