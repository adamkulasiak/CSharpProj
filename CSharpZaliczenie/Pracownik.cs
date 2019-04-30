using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpZaliczenie
{
    class Pracownik: Czlowiek
    {
        public int Id { get; set; }
        public string Stanowisko { get; set; }
        public int PensjaMiesieczna { get; set; }
        public DateTime DataZatrudnienia { get; set; }
        public int IloscDniUrlopu { get; set; }


        public Pracownik(int id, string imie, string naz, uint wiek, string stanowisko, int pensja, DateTime dataZatr, int iloscUrl)
            :base(imie, naz, wiek)
        {
            Stanowisko = stanowisko;
            PensjaMiesieczna = pensja;
            DataZatrudnienia = dataZatr;
            IloscDniUrlopu = iloscUrl;
        }

        public static double SredniaZarobkow(IList<Pracownik> pracownicy)
        {
            var srednia = pracownicy.Average(x => x.PensjaMiesieczna);
            return srednia;
        }
    }
}
