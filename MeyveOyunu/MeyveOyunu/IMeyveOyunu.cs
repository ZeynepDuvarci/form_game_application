using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeyveOyunu
{
    interface IVitaminDeposu
    {
        int Avitamini(int secim);
        int Cvitamini(int secim);
        int Agirlik(int secim);
        string Bilgi(int secim);
    }
    
}
