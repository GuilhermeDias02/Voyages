using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    public class Client
    {
        protected int id;
        protected string nom;
        protected string prenom;
        protected string adresse;
        protected string mail;

        public Client(int unId, string unNom, string unPrenom, string uneAdresse, string unMail)
        {
            this.id = unId;
            this.nom = unNom;
            this.prenom = unPrenom;
            this.adresse = uneAdresse;
            this.mail = unMail;
        }

        public int getId()
        {
            return this.id;
        }
        public string getNom()
        {
            return this.nom;
        }
        public string getPrenom()
        {
            return this.prenom;
        }
        public string getAdresse()
        {
            return this.adresse;
        }
        public string getMail()
        {
            return this.mail;
        }

        public void setAdresse(string nvAdresse)
        { 
            this.adresse = nvAdresse;
        }
        public void setMail(string nvMail)
        {
            this.mail= nvMail;
        }

        public string infosClient()
        {
            return (this.id + " " + this.nom + " " + this.prenom + " " + this.adresse + " " + this.mail);
        }
    }
}
