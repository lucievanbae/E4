using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TableauDeBord
{
    class Occupation
    {
        public string mois;
        public int pourcentageTotal;

        public Occupation(string pMois, int pPourcentageTotal)
        {
            mois = pMois;
            pourcentageTotal = pPourcentageTotal;
        }         
               

        public string getMois()
        {
            return mois;
        }

        public int getPourcentageTotal()
        {
            return pourcentageTotal;
        }
        
    }
}
