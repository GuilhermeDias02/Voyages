using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo1
{
    internal class ClientDao
    {
        private static string provider = "localhost";
        private static string dataBase = "voyages";
        private static string uid = "root";
        private static string mdp = "";

        private static Connexion maConnexionSql;

        private static MySqlCommand Ocom;


        public static List<Client> getClients()
        {
            List<Client> lc = new List<Client>();

            try
            {

                maConnexionSql = Connexion.getInstance(provider, dataBase, uid, mdp);


                maConnexionSql.openConnection();


                Ocom = maConnexionSql.reqExec("Select * from client");


                MySqlDataReader reader = Ocom.ExecuteReader();

                Client c;




                while (reader.Read())
                {
                    int id = (int)reader.GetValue(0);
                    string nom = (string)reader.GetValue(1);
                    string prenom = (string)reader.GetValue(2);
                    string adresse = (string)reader.GetValue(3);
                    string mail = (string)reader.GetValue(4);

                    //Instanciation d'un Emplye
                    c = new Client(id, nom, prenom, adresse, mail);

                    // Ajout de cet employe à la liste 
                    lc.Add(c);


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
