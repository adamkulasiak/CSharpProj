using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpZaliczenie
{
    interface IDrukujPracownikow
    {
        void PrintAllData(IList<Pracownik> pracownicy);
    }
}
