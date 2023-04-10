using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    [Serializable]
    public class Voyage
    {
        private string destination;
        private double prix;
        private double taxe;
        private Date dateDepart;
        private Date dateRetour;
        private int nbPlacesDispos;
        private List<Resa> lResa;

        public Voyage(string dest, double px, double tx, Date depart, Date retour, int nbPlaces)
        {
            this.destination = dest;
            this.prix = px;
            this.taxe = tx;
            this.dateDepart = depart;
            this.dateRetour = retour;
            this.nbPlacesDispos = nbPlaces;
            this.lResa = new List<Resa>();
        }
        public List<Resa> getLResa()
        {
            return this.lResa;
        }
        public void addLResa(Resa uneResa)
        {
            this.lResa.Add(uneResa);
        }
        public override string ToString()
        {
            return this.destination + "" + this.dateDepart + "" + this.dateRetour;
        }
        public double getPrix()
        {
            return (this.prix);
        }
        public string getDestination()
        {
            return this.destination;
        }
        public void setNbPlacesDispos(int nbPlaces)
        {
            this.nbPlacesDispos = nbPlaces;
        }
    }
}