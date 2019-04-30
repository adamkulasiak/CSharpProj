using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpZaliczenie
{
    class Czlowiek
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public uint Wiek { get; set; }

        public Czlowiek(string imie, string naz, uint wiek)
        {
            Imie = imie;
            Nazwisko = naz;
            Wiek = wiek;
        }
    }
}
