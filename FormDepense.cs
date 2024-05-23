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
    public partial class FormDepense : Form
    {
        public FormDepense()
        {
            InitializeComponent();
            txtIdDe.TextChanged += txtIdDe_TextChanged;
            comboIdDe.SelectedIndexChanged += comboIdDe_SelectedIndexChanged;
            comboCatD.SelectedIndexChanged += comboCatD_SelectedIndexChanged;
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

        private void FormDepense_Load(object sender, EventArgs e)
        {
            btnAjoutD.Enabled = false;
            btnSuppD.Enabled = false;
            btnMajD.Enabled = false;

            CategorieDAO categorieDAO= new CategorieDAO();
            // Remplissage de comboBox de catDepense 
            List<Categorie> lesCats = categorieDAO.GetList();
            comboCatD.Items.Clear();
            foreach (Categorie cat in lesCats)
            {
                comboCatD.Items.Add(cat.GetIdCat());

            }
            UtilisateurDAO utilisateurDAO = new UtilisateurDAO();
            List<Utilisateur> utilisateurs = utilisateurDAO.GetList();
            comboIdDe.Items.Clear();
            foreach (Utilisateur util in utilisateurs)
            {
                comboIdDe.Items.Add(util.GetId());

            }
        }
        private void btnAjoutD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtMontant.Text) && comboCatD.SelectedIndex != -1 && comboIdDe.SelectedIndex != -1)
            {
                List<Depenser> depenses = depenseDAO.GetList();
                int depenseId = depenses.Count + 1;

                decimal montant;
                if (!decimal.TryParse(txtMontant.Text, out montant))
                {
                    MessageBox.Show("Veuillez saisir un montant valide.");
                    return;
                }
                //int id = Convert.ToInt16(txtIdDe.Text);
                string commentaire = txtCommentaire.Text + ".";
                int utilisateurId = Convert.ToInt32(comboIdDe.SelectedItem);
                int categorieId = Convert.ToInt32(comboCatD.SelectedItem);
                DateTime dateC = dateTimeCat.Value.Date;

                Depenser dep = new Depenser(depenseId, montant, dateC, commentaire, utilisateurId, categorieId);

                depenseDAO.Ajouter(dep);
                MessageBox.Show(dep.ToString() + " a été ajouté ");
            }
        }

        private void btnSuppD_Click(object sender, EventArgs e)
        {
  
            try
            {
                if (txtIdDe.Text != null)
                {
                    int id; 
                    if(int.TryParse(txtIdDe.Text, out id))
                    {
                        Depenser depSupp = depenseDAO.RechercheId(id);
                        if(depSupp != null) {
                            {
                                if (MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette depense ?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                                {
                                    if (depenseDAO.Supprimer(id))
                                    {
                                        MessageBox.Show("La catégorie n°" + depSupp.Id + " a été supprimée ", "Mise à jour réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
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

        private void txtIdDe_TextChanged(object sender, EventArgs e)
        {
            UpdateButtonsState();
            if (!string.IsNullOrEmpty(txtIdDe.Text) && int.TryParse(txtIdDe.Text, out int id))
            {
                Depenser depense = depenseDAO.RechercheId(id);

                if (depense != null)
                {
                    txtMontant.Text = depense.Montant.ToString();
                    txtCommentaire.Text = depense.Descrption.ToString();
                    comboIdDe.Text = depense.UtilisaterID.ToString();
                    comboCatD.Text = depense.CategorieID.ToString();
                }
            }
            else
            {
                txtMontant.Text = string.Empty;
                txtCommentaire.Text = string.Empty;
                comboIdDe.Text = string.Empty;
                comboCatD.Text = string.Empty;
            }

        }
        private void txtIdDe_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnMajD_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtIdDe.Text) && !string.IsNullOrEmpty(txtMontant.Text))
            {
                int id = Convert.ToInt32(txtIdDe.Text);
                Depenser depense = depenseDAO.RechercheId(id);

                if (depense != null)
                {
                    depense.Id = id;
                    depense.Montant = decimal.Parse(txtMontant.Text);
                    depense.DateD = dateTimeCat.Value.Date;
                    depense.UtilisaterID = comboIdDe.SelectedIndex + 1;
                    depense.CategorieID= comboCatD.SelectedIndex + 1;
                    depense.Descrption = txtCommentaire.Text;

                    depenseDAO.Update(depense);
                    MessageBox.Show(depense.ToString() + " La mise à jour a été réussie");
                }
                else
                {
                    MessageBox.Show("L'ID de dépense spécifié n'existe pas.");
                }
            }
        }

        private void comboIdDe_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonsState();
        }
        private void UpdateButtonsState()
        {
            bool isFieldsNotEmpty = !string.IsNullOrEmpty(txtIdDe.Text) && comboIdDe.SelectedIndex != -1 && comboCatD.SelectedIndex != -1;
            if (isFieldsNotEmpty){
            btnAjoutD.Enabled = isFieldsNotEmpty;
            btnMajD.Enabled = isFieldsNotEmpty;
            }

            bool isFailSupp = !string.IsNullOrEmpty(txtIdDe.Text);
            if (isFailSupp)
            {
            btnSuppD.Enabled = isFieldsNotEmpty;
            }


        }

        private void comboCatD_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateButtonsState();
        }

        private void lstD_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
        private void principalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormIndex form= new FormIndex();    
            form.Show();
            this.Hide();
        }

        private void txtIdDe_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMontant_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;

            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {

                e.Handled = false;
            }
        }

        private void categorieToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            categoei categoei = new categoei();
            categoei.Show();    
            this.Hide();
        }

        private void depenseToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }

        private void menu1_Click(object sender, EventArgs e)
        {
            Form1 form1= new Form1();
            form1.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
