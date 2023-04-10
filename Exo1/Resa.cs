using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    [Serializable]
    public class Resa
    {
        private Voyage leVoyage;
        private int nbPersonne;

        public Resa(int unNbPersonne, Voyage unVoyage) 
        { 
            this.nbPersonne = unNbPersonne;
            this.leVoyage = unVoyage;
        }
        public void setNbPersonne(int unNbPersonne)
        {
            this.nbPersonne = unNbPersonne;
        }
        /*public string toString()
        { 

        }*/
        public double calculMontant() 
        {
            double prix = this.leVoyage.getPrix();
            double taxe = 100;
            double unMontant = (prix+taxe)*nbPersonne;
            return unMontant;
        }
        public Boolean resaPossible()
        {
            if (this.nbPersonne <= 25){
                return true;
            }
            else{
                return false;
            }
        }
        public void confirmeResa(Boolean resaPossible)
        {
            if (resaPossible == true) {
                this.calculMontant();
            }
        }
    }
}