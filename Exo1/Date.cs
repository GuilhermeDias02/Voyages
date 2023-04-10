using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    [Serializable]
    public class Date
    {
        private int jour;
        private int mois;
        private int annee;

        public Date(int j, int m, int a)
        {
            this.jour = j;
            this.mois = m;
            this.annee = a;
        }

        public override string ToString()
        {
            return(jour+"/"+mois+"/"+annee);
        }
        public int getJour()
        {
            return this.jour;
        }
        public int setJour(int j)
        {
            return this.jour = j;
        }
        public int getMois()
        {
            return this.mois;
        }
        public int getAnnee()
        {
            return this.annee;
        }
    }
}