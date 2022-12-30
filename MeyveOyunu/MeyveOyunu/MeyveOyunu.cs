using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeyveOyunu
{
    class Narenciye:IVitaminDeposu
    {
        public int Avitamini(int secim)
        {
            int[] adizi = { 247, 3, 22,476 };

            return adizi[secim];

        }
        public int Cvitamini(int secim)
        {
            int[] cdizi = { 49,48,70,18 };

            return cdizi[secim];
        }
        public int Agirlik(int secim)
        {
            int[] agdizi ={110,110,100,70 };
            int[] verim = { 50, 40, 30, 45 };

            int toplam_agirlik = (verim[secim] * agdizi[secim]) / 100;

            return toplam_agirlik;
        }
        public string Bilgi(int secim)
        {
            string[] meyveler = { "Portakal", "Greyfurt", "Limon", "Mandalina" };
            int[] agdizi = { 110, 110, 100, 70 };
            int[] verim = { 50, 40, 30, 45 };
            int[] cdizi = { 49, 48, 70, 18 };
            int[] adizi = { 247, 3, 22, 476 };

            string bilgi = "\n"+agdizi[secim]+" gr "+meyveler[secim]+"'da"+adizi[secim]+" (iu) A vitamini "
                +cdizi[secim]+" (mg) C vitamini var\n (Verim : % "+verim[secim]+" )";
            return bilgi;
        }
    }
    class KatıMeyve:IVitaminDeposu
    {
        public int Avitamini(int secim)
        {
            int[] adizi = {48,27,10,3 };

            return adizi[secim];

        }
        public int Cvitamini(int secim)
        {
            int[] cdizi = { 4, 5, 50, 18 };

            return cdizi[secim];
        }
        public int Agirlik(int secim)
        {
            int[] agdizi = { 90, 110, 75, 70 };
            int[] verim = { 80, 85, 90, 85 };

            int toplam_agirlik = (verim[secim] * agdizi[secim]) / 100;

            return toplam_agirlik;
        }
        public string Bilgi(int secim)
        {
            int[] adizi = { 48, 27, 10, 3 };
            int[] cdizi = { 4, 5, 50, 18 };
            int[] agdizi = { 90, 110, 75, 70 };
            int[] verim = { 80, 85, 90, 85 };
            
            string[] meyveler = { "Elma", "Armut", "Kivi", "Çilek" };
            
            string bilgi = "\n"+agdizi[secim] + " gr " + meyveler[secim] + "'da" + adizi[secim] + " (iu) A vitamini "
                + cdizi[secim] + " (mg) C vitamini var\n (Verim : % " + verim[secim] + " ) ";
            return bilgi;
        }
    }

}
