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


        public Pracownik(string imie, string naz, int wiek, int id, string stanowisko, int pensja, int iloscUrl)
            :base(imie, naz, wiek)
        {
            Id = id;
            Stanowisko = stanowisko;
            PensjaMiesieczna = pensja;
            DataZatrudnienia = DateTime.Now;
            IloscDniUrlopu = iloscUrl;
        }

        public static double SredniaZarobkow(IList<Pracownik> pracownicy)
        {
            var srednia = pracownicy.Average(x => x.PensjaMiesieczna);
            return srednia;
        }
    }
}
