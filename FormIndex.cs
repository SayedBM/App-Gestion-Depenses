using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depenses
{
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
        }

        private void FormIndex_Load(object sender, EventArgs e)
        {
            List<Depenser> depenses = depenseDAO.GetList();
            listBox1.Items.Clear(); // Effacer les anciens éléments si nécessaire

            // Construire la chaîne de caractères des dépenses et l'ajouter à la ListBox
            foreach (Depenser depense in depenses)
            {
                listBox1.Items.Add("ID de la dépense : " + depense.Id);
                listBox1.Items.Add("Montant : " + depense.Montant);
                listBox1.Items.Add("Date de la dépense : " + depense.DateD);
                listBox1.Items.Add("Description : " + depense.Descrption);
                listBox1.Items.Add("ID de l'utilisateur : " + depense.UtilisaterID);
                listBox1.Items.Add("ID de la catégorie : " + depense.CategorieID);
                listBox1.Items.Add("-------------------------------------");
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void categorieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            categoei categei = new categoei();
            categei.Show();
            this.Hide();
        }

        private void depenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDepense formDepense = new FormDepense();    
            formDepense.Show();
            this.Hide();
        }
        DepenseDAO depenseDAO = new DepenseDAO();
        private void btnListD_Click(object sender, EventArgs e)
        {


            try
            {
                List<Depenser> depenses = depenseDAO.GetList();
                StringBuilder sb = new StringBuilder();

                // Construire la chaîne de caractères des dépenses
                foreach (Depenser depense in depenses)
                {
                    sb.AppendLine("ID de la dépense : " + depense.Id);
                    sb.AppendLine("Montant : " + depense.Montant);
                    sb.AppendLine("Date de la dépense : " + depense.DateD);
                    sb.AppendLine("Description : " + depense.Descrption);

                    sb.AppendLine("ID de l'utilisateur : " + depense.UtilisaterID);
                    sb.AppendLine("ID de la catégorie : " + depense.CategorieID);
                    sb.AppendLine("-------------------------------------");

                }

                // Afficher la chaîne de caractères des dépenses dans une boîte de dialogue
                MessageBox.Show("\b Liste de toutes les dépenses :\n" + sb.ToString());

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la récupération des dépenses : " + ex.Message);
            }
        }

        private void btnAjoutD_Click(object sender, EventArgs e)
        {
            FormDepense formDepense = new FormDepense();
            formDepense.Show();
            this.Hide();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
