using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpZaliczenie
{
    abstract class Czlowiek
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Wiek { get; set; }

        public Czlowiek(string imie, string naz, int wiek)
        {
            Imie = imie;
            Nazwisko = naz;
            Wiek = wiek;
        }
    }
}
