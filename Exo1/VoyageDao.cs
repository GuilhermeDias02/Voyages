using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    internal class VoyageDao
    {
        private static string provider = "localhost";
        private static string dataBase = "voyages";
        private static string uid = "root";
        private static string mdp = "";

        private static Connexion maConnexionSql;

        private static MySqlCommand Ocom;


        public static List<Voyage> getClients()
        {
            List<Voyage> lc = new List<Voyage>();

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from voyage");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Voyage v;




                while (reader.Read())
                {

                    string dest = (string)reader.GetValue(1);
                    double prix = (double)reader.GetValue(2);
                    double taxe = (double)reader.GetValue(3);
                    Date dateDepart = (Date)reader.GetValue(4);
                    Date dateRetour = (Date)reader.GetValue(5);
                    int nbPlaces = (int)reader.GetValue(6);

                    //Instanciation d'un Emplye
                    v = new Voyage(dest, prix, taxe, dateDepart, dateRetour, nbPlaces);

                    // Ajout de cet employe à la liste 
                    lc.Add(v);


                }



                reader.Close();

                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager
                return (lc);


            }

            catch (Exception e)
            {

                throw (e);

            }
        }
    }
}
