using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpZaliczenie
{
    class WorkerManager
    {
        private IList<Pracownik> _pracownicy;

        public WorkerManager()
        {
            _pracownicy = new List<Pracownik>();
        }

        public Pracownik DodajPracownika(string imie, string naz, uint wiek, string stanowisko, int pensja, DateTime dataZatr, int iloscUrl)
        {
            int id = NadajId();
            Pracownik prac = new Pracownik(id, imie, naz, wiek, stanowisko, pensja, dataZatr, iloscUrl);
            _pracownicy.Add(prac);
            return prac;
        }

        public IEnumerable<Pracownik> PobierzPracownikow()
        {
            return _pracownicy;
        }

        public IEnumerable<Pracownik> PobierzPracownikowNaStanowisku(string stanowisko)
        {
            return _pracownicy.Where(x => x.Stanowisko == stanowisko);
        }

        public int NadajId()
        {
            var id = 1;
            if(_pracownicy.Any())
            {
                id = _pracownicy.Max(x => x.Id) + 1;
            }
            return id;
        }
    }
}
