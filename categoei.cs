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
    public partial class categoei : Form
    {
        public categoei()
        {
            InitializeComponent();
        }

        CategorieDAO categorieDAO= new CategorieDAO();
        private void btnListCat_Click(object sender, EventArgs e)
        {
            List<Categorie> lesCats = categorieDAO.GetList();

            string listeCat = "Liste des Catégorie";
            listeCat += "\n-------------------\n";

            foreach (Categorie cat in lesCats)
            {
                listeCat += cat.ToString() + "\n";
            }
            MessageBox.Show(listeCat, "Liste des Catégories ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAjoutCat_Click(object sender, EventArgs e)
        {
            if(txtIdCat.Text !=null && txtlibCat.Text !=null)
            {
                int categorieId = int.Parse(txtIdCat.Text);
                string nom = txtlibCat.Text;

                Categorie cat = new Categorie(categorieId, nom);
                categorieDAO.Creer(cat);
                MessageBox.Show(categorieDAO.ToString() + " a été ajouté ");

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
        }
       
        private void categoei_Load(object sender, EventArgs e)
        {

            // Remplissage de comboBox de catDepense 
            List<Categorie> lesCats = categorieDAO.GetList();
            comboCat.Items.Clear();
            foreach (Categorie cat in lesCats)
            {
                comboCat.Items.Add(cat.GetIdCat());

            }
        }

        private void txtIdCat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMajCat_Click(object sender, EventArgs e)
        {
            if (txtIdCat.Text != null && txtlibCat.Text != null)
            {
                int categorieId = int.Parse(txtIdCat.Text);
                string nom = txtlibCat.Text;

                Categorie cat = new Categorie(categorieId, nom);
                categorieDAO.Update(cat);
                MessageBox.Show(categorieDAO.ToString() + " la mise à jour a été réussie !");

            }
        }

        private void comboCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(comboCat.Text, out id))
            {
                Categorie catTrouve = categorieDAO.RechercheIdCat(id);
                if (catTrouve != null)
                {
                    txtlibCat.Text = catTrouve.Libelle;
                    txtIdCat.Text = catTrouve.Id.ToString();

                }
                else
                {
                    MessageBox.Show("Rien");
                }
            }
        }

        private void btnSuppCat_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIdCat.Text != null && txtlibCat.Text != null)
                {
                    int id;
                    if (int.TryParse(txtIdCat.Text, out id))
                    {
                        Categorie catSupp = categorieDAO.RechercheIdCat(id);
                        if (catSupp != null)
                        {
                            if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette catégorie ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                if (categorieDAO.Supprimer(id))
                                {
                                    MessageBox.Show("La catégorie n°" + catSupp.Id + " a été supprimée ", "Mise à jour réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici
            }
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormIndex formIndex = new FormIndex();
            formIndex.Show();
            this.Hide();
        }

        private void txtIdCat_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIndex form1= new FormIndex();
            form1.Show();
            this.Hide();
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            Form1 formU = new Form1();
            formU.Show();
            this.Hide();
        }

        private void categorieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            //categoei formC= new categoei();
            //formC.Show(); this.Hide();
        }

        private void depenseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDepense formD= new FormDepense();
            formD.Show();
            this.Hide();
        }
    }
}
