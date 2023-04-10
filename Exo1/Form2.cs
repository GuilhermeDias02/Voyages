using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo1
{
    public partial class Form2 : Form
    {
        private Voyage voyage;
        private Resa nvResa;
        private List<Client> lClients;

        private Client c;

        public Form2(Voyage unVoyage)
        {
            InitializeComponent();
          
            this.voyage = unVoyage;

            nvResa = new Resa(0, voyage);//rajouter client dans resa pour pouvoir l'utiliser dans dans calculmontant

            lClients = new List<Client>();

            Client c1 = new Client(1, "Baptiste", "Jean", "Paris", "jean.baptiste@outlook.fr");
            Client c2 = new ClientFidele(2, "Dupont", "Albert", "Marseille", "albert.dupont@outlook.fr");
            //créer un menu dans la menubar pour créer un nouveau client

            lClients.Add(c1);
            lClients.Add(c2);

            linklistBox();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (nvResa.resaPossible())
            {
                label2.Text = "Votre réservation a bien été confirmée";
            }
            else
            {
                label2.Text = "Pas assez de places disponibles";
            }

            //sauvegarde
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                nvResa.setNbPersonne(Convert.ToInt32(textBox1.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "VEUILLEZ CHOISIR UN NOMBRE DE PERSONNES, stp");
            }
            label1.Text = "Le montant est de " + nvResa.calculMontant() + "€";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linklistBox()
        {
            listBoxClients.Items.Clear();
            for (int i = 0; i <= lClients.Count - 1; i++)
            {
                listBoxClients.Items.Add(lClients[i].infosClient());
            }
        }

        private void listBoxClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listBoxClients.SelectedIndex;
            c = lClients[i];
        }
    }
}
