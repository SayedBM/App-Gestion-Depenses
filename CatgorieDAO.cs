using Depenses;
using MagasinDAOinterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depenses
{
    public class CategorieDAO
    {
        private SqlConnection connection;

        public CategorieDAO()
        {
            connection = Connexion.GetInstance();
        }

        public bool Creer(Categorie categorie)
        {
            try
            {
                using (SqlCommand cmdInsert = new SqlCommand("INSERT INTO CategorieDepenses VALUES (@CategorieId, @nom)", connection))
                {
                    cmdInsert.Parameters.AddWithValue("@CategorieId", categorie.Id);
                    cmdInsert.Parameters.AddWithValue("@nom", categorie.Libelle);

                    int nbLigne = cmdInsert.ExecuteNonQuery();
                    connection.Close();

                    return nbLigne > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la création de la catégorie : " + ex.Message);
                return false;
            }
        }

        public List<Categorie> GetList()
        {
            List<Categorie> categories = new List<Categorie>();

            try
            {
                using (SqlCommand cmdList = new SqlCommand("SELECT CategorieID, nom FROM CategorieDepenses", connection))
                {
                    using (SqlDataReader reader = cmdList.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Categorie categorie = new Categorie(reader.GetInt32(0), reader.GetString(1));
                            categories.Add(categorie);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la lecture des catégories : " + ex.Message);
            }

            return categories;
        }

        public bool Supprimer(int categorieId)
        {
            try
            {
                using (SqlCommand cmdDelete = new SqlCommand("DELETE FROM CategorieDepenses WHERE CategorieId = @Id", connection))
                {
                    cmdDelete.Parameters.AddWithValue("@Id", categorieId);

                    int nbLigne = cmdDelete.ExecuteNonQuery();

                    return nbLigne > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la suppression de la catégorie : " + ex.Message);
                return false;
            }
        }

        public bool Update(Categorie categorie)
        {
            try
            {
                using (SqlCommand cmdUpdate = new SqlCommand("UPDATE CategorieDepenses SET nom = @nom WHERE CategorieID = @CategorieID", connection))
                {
                    cmdUpdate.Parameters.AddWithValue("@nom", categorie.Libelle);
                    cmdUpdate.Parameters.AddWithValue("@CategorieID", categorie.Id);

                    int nbLigne = cmdUpdate.ExecuteNonQuery();

                    return nbLigne > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la mise à jour de la catégorie : " + ex.Message);
                return false;
            }
        }

        public Categorie RechercheIdCat(int categorieId)
        {
            try
            {
                using (SqlCommand cmdRech = new SqlCommand("SELECT CategorieID, nom FROM CategorieDepenses WHERE CategorieID = @CategorieID", connection))
                {
                    cmdRech.Parameters.AddWithValue("@CategorieID", categorieId);

                    using (SqlDataReader reader = cmdRech.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            Categorie categorie = new Categorie(reader.GetInt32(0), reader.GetString(1));
                            return categorie;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de la recherche de la catégorie : " + ex.Message);
                return null;
            }

            return null;
        }
    }
}