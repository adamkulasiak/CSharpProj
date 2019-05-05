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

        public Pracownik AddWorker(string imie, string naz, int wiek, string stanowisko, int pensja, int iloscUrl)
        {
            int id = GetId();
            Pracownik prac = new Pracownik(imie, naz, wiek, id, stanowisko, pensja, iloscUrl);
            _pracownicy.Add(prac);
            return prac;
        }

        public void DeleteWorker(int id)
        {
            var toRemove = _pracownicy.Where(x => x.Id == id).ToList();
            foreach (var item in toRemove)
            {
                _pracownicy.Remove(item);
            }   
        }

        public IEnumerable<Pracownik> GetAllWorkers()
        {
            return _pracownicy;
        }

        public IEnumerable<Pracownik> GetWorker(string nazw)
        {
            IEnumerable<Pracownik> worker = _pracownicy.Where(x => x.Nazwisko.Contains(nazw));
            return worker;
        }

        public IEnumerable<Pracownik> GetWorkersOnWorksite(string stanowisko)
        {
            return _pracownicy.Where(x => x.Stanowisko.Contains(stanowisko));
        }

        public int GetId()
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
