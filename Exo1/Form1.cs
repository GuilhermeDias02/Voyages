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
    public partial class Form1 : Form
    {
        private Date dateD;
        private Date dateR;
        private List<Voyage> lVoyages;

        private Voyage v;
        public Form1()
        {
            InitializeComponent();
            lVoyages = new List<Voyage>();

            dateD = new Date(15, 09, 22);
            dateR = new Date(22, 09, 22);
            Voyage bali = new Voyage("Bali", 1800, 100, dateD, dateR, 25);
            Voyage londres = new Voyage("Londres", 20, 50, dateD, dateR, 25);

            lVoyages.Add(bali);
            lVoyages.Add(londres);
            linklistBox();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(v);

            f.ShowDialog();
        }

        private void listBoxVoyages_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupInfosVoyage.Visible = true;
            int i = listBoxVoyages.SelectedIndex;
            v = lVoyages[i];
            labelInfosVoyage.Text = v.ToString();//mieux de mettre chaque information dans des labels séparés
        }
        private void linklistBox()
        {
            listBoxVoyages.Items.Clear();
            for (int i = 0; i <= lVoyages.Count - 1; i++)
            {
                listBoxVoyages.Items.Add(lVoyages[i].getDestination());
            }
        }
    }
}