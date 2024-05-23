using MagasinDAOinterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Depenses
{
    public class DepenseDAO
    {
        private SqlConnection connection;

        public DepenseDAO()
        {
            connection = Connexion.GetInstance();
        }

        public List<Depenser> GetList()
        {
            List<Depenser> depenses = new List<Depenser>();
            try
            {
                string query = "SELECT DepenseID, Montant, DateDepense, Description, UtilisateurID, CategorieID FROM Depense";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int depenseId = reader.GetInt32(0);
                            decimal montant = reader.GetDecimal(1);
                            DateTime dateDepense = reader.GetDateTime(2);
                            string description = reader.GetString(3);
                            int utilisateurId = reader.GetInt32(4);
                            int categorieId = reader.GetInt32(5);

                           

                            CategorieDAO categorieDAO = new CategorieDAO();
                            Categorie categorie = categorieDAO.RechercheIdCat(categorieId);

                            Depenser depense = new Depenser(depenseId, montant, dateDepense, description, utilisateurId, categorieId);
                            depenses.Add(depense);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la lecture des dépenses : " + ex.Message);
            }
            return depenses;
        }

        public bool Ajouter(Depenser depense)
        {
            try
            {
                using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO Depense VALUES (@DepenseID,@Montant, @DateDepense, @Description, @UtilisateurID, @CategorieID)", connection))
                {
                    cmdInsert.Parameters.AddWithValue("@DepenseID", depense.Id);
                    cmdInsert.Parameters.AddWithValue("@Montant", depense.Montant);
                    cmdInsert.Parameters.AddWithValue("@DateDepense", depense.DateD);
                    cmdInsert.Parameters.AddWithValue("@Description", depense.Descrption);
                    cmdInsert.Parameters.AddWithValue("@UtilisateurID", depense.UtilisaterID);
                    cmdInsert.Parameters.AddWithValue("@CategorieID", depense.CategorieID);

                    int nbLigne = cmdInsert.ExecuteNonQuery();

                    return nbLigne > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout de la dépense : " + ex.Message);
                return false;
            }
        }


        public bool Supprimer(int depenseId)
        {
            try
            {
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM Depense WHERE DepenseID = @DepenseID", connection))
                {
                    cmdDelete.Parameters.AddWithValue("@DepenseID", depenseId);

                    int nbLigne = cmdDelete.ExecuteNonQuery();

                    return nbLigne > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression de la dépense : " + ex.Message);
                return false;
            }
        }

        

        public Depenser RechercheId(int depenseId)
        {
            try
            {
                using (SqlCommand cmdSelect = new SqlCommand("SELECT Montant, DateDepense, Description, UtilisateurID, CategorieID FROM Depense WHERE DepenseID = @DepenseID", connection))
                {
                    cmdSelect.Parameters.AddWithValue("@DepenseID", depenseId);

                    using (SqlDataReader reader = cmdSelect.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            decimal montant = reader.GetDecimal(0);
                            DateTime dateDepense = reader.GetDateTime(1);
                            string description = reader.GetString(2);
                            int utilisateurId = reader.GetInt32(3);
                            int categorieId = reader.GetInt32(4);

                            UtilisateurDAO utilisateurDAO = new UtilisateurDAO();
                            Utilisateur utilisateur = utilisateurDAO.RechercheId(utilisateurId);

                            CategorieDAO categorieDAO = new CategorieDAO();
                            Categorie categorie = categorieDAO.RechercheIdCat(categorieId);

                            return new Depenser(depenseId, montant, dateDepense, description, utilisateurId, categorieId);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la recherche de la dépense : " + ex.Message);
            }
            return null;
        }
        public List<Depenser> GetListParU(int utilisateurId)
        {
            List<Depenser> depenses = new List<Depenser>();
            try
            {
                string query = "SELECT DepenseID, Montant, DateDepense, Description, UtilisateurID, CategorieID FROM Depense WHERE UtilisateurID = @UtilisateurID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@UtilisateurID", utilisateurId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int depenseId = reader.GetInt32(0);
                            decimal montant = reader.GetDecimal(1);
                            DateTime dateDepense = reader.GetDateTime(2);
                            string description = reader.GetString(3);
                            int categorieId = reader.GetInt32(5);


                            Depenser depense = new Depenser(depenseId, montant, dateDepense, description, utilisateurId, categorieId);
                            depenses.Add(depense);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la lecture des dépenses : " + ex.Message);
            }
            return depenses;
        }

        public List<Depenser> GetListParCat(int categorieId)
        {
            List<Depenser> depenses = new List<Depenser>();
            try
            {
                string query = "SELECT DepenseID, Montant, DateDepense, Description, UtilisateurID, CategorieID FROM Depense WHERE CategorieID = @CategorieID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@CategorieID", categorieId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int depenseId = reader.GetInt32(0);
                            decimal montant = reader.GetDecimal(1);
                            DateTime dateDepense = reader.GetDateTime(2);
                            string description = reader.GetString(3);
                            int utilisateurId = reader.GetInt32(4);

                            UtilisateurDAO utilisateurDAO = new UtilisateurDAO();
                            Utilisateur utilisateur = utilisateurDAO.RechercheId(utilisateurId);

                            CategorieDAO categorieDAO = new CategorieDAO();
                            Categorie categorie = categorieDAO.RechercheIdCat(categorieId);

                            Depenser depense = new Depenser(depenseId, montant, dateDepense, description, utilisateurId, categorieId);
                            depenses.Add(depense);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la lecture des dépenses par catégorie : " + ex.Message);
            }
            return depenses;
        }

        public bool Update(Depenser depense)
        {
            try
            {
                using (SqlCommand cmdUpdate = new SqlCommand("Update Depense set Montant = @Montant, dateDepense = @DateDepense, description = @Description, utilisateurId = @UtilisateurId, CategorieId = @CategorieId Where DepenseId = @DepenseId", connection))
                {
                    cmdUpdate.Parameters.AddWithValue("@Montant", depense.Montant);
                    cmdUpdate.Parameters.AddWithValue("@DateDepense", depense.DateD);
                    cmdUpdate.Parameters.AddWithValue("@Description", depense.Descrption);
                    cmdUpdate.Parameters.AddWithValue("@UtilisateurId", depense.UtilisaterID);
                    cmdUpdate.Parameters.AddWithValue("@CategorieId", depense.CategorieID);
                    cmdUpdate.Parameters.AddWithValue("@DepenseId", depense.Id);

                    int nbLigne = cmdUpdate.ExecuteNonQuery();
                    return nbLigne > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la mise à jour de la dépense : " + ex.Message);
                return false;
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Liste des dépenses :");
            List<Depenser> depenses = GetList();
            foreach (Depenser depense in depenses)
            {
                sb.AppendLine("ID de la dépense : " + depense.Id);
                sb.AppendLine("Montant : " + depense.Montant);
                sb.AppendLine("Date de la dépense : " + depense.DateD.ToString("yyyy-MM-dd"));
                sb.AppendLine("Description : " + depense.Descrption);
                sb.AppendLine("ID de l'utilisateur : " + depense.UtilisaterID);
                sb.AppendLine("ID de la catégorie : " + depense.CategorieID);
                sb.AppendLine("------------------------");
            }
            return sb.ToString();
        }
    }
}
