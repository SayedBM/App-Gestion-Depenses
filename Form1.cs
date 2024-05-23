using MagasinDAOinterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depenses
{
    public partial class Form1 : Form
    {
        UtilisateurDAO utilisateurDAO = new UtilisateurDAO();
        CategorieDAO categorieDAO= new CategorieDAO();
        public Form1()
        {
            InitializeComponent();
        }
       
        private void comboId_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            if(int.TryParse(comboId.Text,out id))
            {
                Utilisateur utilisateurTrove = utilisateurDAO.RechercheId(id);
                if(utilisateurTrove != null)
                {
                    txtEmail.Text= utilisateurTrove.Email;
                    txtId.Text = utilisateurTrove.Id.ToString();
                    txtNom.Text = utilisateurTrove.Nom;

                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
 
            //UtilisateurDAO utilisateurDAO = new UtilisateurDAO();

            List<Utilisateur> utilisateurs = utilisateurDAO.GetList();
            comboId.Items.Clear();
            foreach (Utilisateur util in utilisateurs)
            {
                comboId.Items.Add(util.GetId());

            }
        }

        private void btnUtilisateur_Click(object sender, EventArgs e)
        {
           

            List<Utilisateur> utilisateurs = utilisateurDAO.GetList();
            MessageBox.Show(utilisateurs.Count.ToString());

            string liste = "Liste des Utilisateurs ! \n";
            liste += "--------------";

            foreach (Utilisateur util in utilisateurs)
            {
                liste += util.ToString() + "\n";

            }MessageBox.Show(liste, "Liste des Utilisateurs", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void btnAjout_Click(object sender, EventArgs e)
        {
            if (txtId.Text!=null && txtNom.Text !=null && txtEmail.Text!=null)
            {
                int utilisateurId = int.Parse(txtId.Text);
                string nom = txtNom.Text;
                string email = txtEmail.Text;
                Utilisateur util = new Utilisateur(utilisateurId, nom, email);

                UtilisateurDAO utilisateurDAO = new UtilisateurDAO();
                utilisateurDAO.creer(util);
                MessageBox.Show(utilisateurDAO.ToString()+ " a été ajouté"); 
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void btnMAJ_Click(object sender, EventArgs e)
        {
            if (txtId.Text != null && txtNom.Text != null && txtEmail.Text != null)
            {
                int id;
                if (int.TryParse(txtId.Text, out id))
                {
                    Utilisateur utilMAJ = utilisateurDAO.RechercheId(id);
                    if (utilisateurDAO != null)
                    {
                        utilMAJ.Email = txtEmail.Text;
                        MessageBox.Show("Vous pouvez modifier l'adresse e-mail", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                        if (MessageBox.Show("Êtes-vous sûr de vouloir modifier l'adresse e-mail ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {
                            if (utilisateurDAO.Update(utilMAJ))
                            {
                                MessageBox.Show("L'adresse e-mail de l'utilisateur n°" + utilMAJ.Id + " a été modifiée", "Mise à jour réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }

                    }
                }
            }

        }
        private void btnSupp_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != null && txtNom.Text != null && txtEmail.Text != null)
                {
                    int id;
                    if(int.TryParse(txtId.Text, out id))
                    {
                        Utilisateur utilSupp = utilisateurDAO.RechercheId(id);
                        if (utilisateurDAO != null)
                        {
                            if(MessageBox.Show("Êtes-vous sûr de vouloir supprimer cet utilisateur ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                            {
                                if (utilisateurDAO.Supprimer(id))
                                {
                                    MessageBox.Show("L'utilisateur n°" + utilSupp.Id + " a été supprimé ", "Mise à jour réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
            }catch(Exception ex)
            {
                
            }
        }

        private void btnListCat_Click(object sender, EventArgs e)
        {
            List<Categorie> lesCats = categorieDAO.GetList();

            string listeCat = "Liste des Catégorie";
            listeCat += "\n-------------------\n";

            foreach(Categorie cat in lesCats) 
            {
                listeCat += cat.ToString() + "\n";
            }MessageBox.Show(listeCat,"Liste des Catégories ",MessageBoxButtons.OK, MessageBoxIcon.Information);    
        }

        private void btnAjt_Click(object sender, EventArgs e)
        {
            categoei formCategori = new categoei();
            formCategori.Show();
            this.Hide();
        }

        private void btnAllerDe_Click(object sender, EventArgs e)
        {
            FormDepense formDepense= new FormDepense();
            formDepense.Show(); 
            this.Hide();
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            FormIndex formIndex = new FormIndex();
            formIndex.Show();
            this.Hide();
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

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

        private void txtId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
        }

        private void categorieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            categoei formC = new categoei();
            formC.Show();
            this.Hide();

        }

        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIndex formIndex= new FormIndex();
            formIndex.Show();
            this.Hide();
        }

        private void menu1_Click(object sender, EventArgs e)
        {

        }

        private void depenseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDepense formD = new FormDepense();
            formD.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}