using MagasinDAOinterface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depenses
{
    public class UtilisateurDAO
    {
        private SqlConnection connexions;
        public UtilisateurDAO()
        {
            connexions = Connexion.GetInstance();
        }
        public bool creer(Utilisateur util)
        {
            try
            {
                using (SqlCommand cmdInsert = new SqlCommand("Insert into Utilisateur VALUES (@UtilisateurID, @Nom, @Email,'null')", connexions))
                {
                    cmdInsert.Parameters.AddWithValue("@UtilisateurID", util.Id);
                    cmdInsert.Parameters.AddWithValue("@Nom", util.Nom);
                    cmdInsert.Parameters.AddWithValue("@Email", util.Email);

                    
                    int nbLigne = cmdInsert.ExecuteNonQuery();
                    connexions.Close();

                    return nbLigne>0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Errore lors de la creation "+ ex.Message);
                return false;
            }
        }
        public List<Utilisateur> GetList()
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();
            try
            {
                string comd = "select UtilisateurID, nom, email from Utilisateur";
                using (SqlCommand cmdList = new SqlCommand(comd, connexions))
                {
                    using (SqlDataReader reader = cmdList.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Utilisateur util = new Utilisateur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                            utilisateurs.Add(util);
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la lecture des utilisateurs : " + ex.Message);
            }
            return utilisateurs;
        }
        public bool Supprimer(int utilisateurId)
        {
            try
            {
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM Utilisateur WHERE UtilisateurID = @UtilisateurID", connexions))
                {
                    cmdDelete.Parameters.AddWithValue("@UtilisateurID", utilisateurId);

                    int nbLigne = cmdDelete.ExecuteNonQuery();

                    return nbLigne > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression de l'utilisateur : " + ex.Message);
                return false;
            }
        }
        public bool Update(Utilisateur utilisateur)
        {
            try
            {
                using (SqlCommand cmdUpdate = new SqlCommand("UPDATE Utilisateur SET Nom = @Nom, Email = @Email WHERE UtilisateurID = @UtilisateurID", connexions))
                {
                    cmdUpdate.Parameters.AddWithValue("@Nom", utilisateur.Nom);
                    cmdUpdate.Parameters.AddWithValue("@Email", utilisateur.Email);
                    cmdUpdate.Parameters.AddWithValue("@UtilisateurID", utilisateur.Id);

                    int nbLigne = cmdUpdate.ExecuteNonQuery();

                    return nbLigne > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la mise à jour de l'utilisateur : " + ex.Message);
                return false;
            }
        }
        public Utilisateur RechercheId(int utilisateurId)
        {
            try
            {
                using (SqlCommand cmdRech = new SqlCommand("select UtilisateurID, Nom, Email FROM Utilisateur WHERE UtilisateurID = " + utilisateurId, connexions))
                {
                    cmdRech.Parameters.AddWithValue("@UtilisateurID", utilisateurId);

                    using (SqlDataReader reader = cmdRech.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Utilisateur util = new Utilisateur(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                            return util;
                        }
                    }
                    
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la recherche de l'utilisateur : " + ex.Message);
                return null;
            }
            return null;
        }

    }
}
