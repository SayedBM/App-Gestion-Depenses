using System;
using System.Data.SqlClient;

namespace MagasinDAOinterface
{
    class Connexion
    {
        private static SqlConnection instance;
        private static string chaineDeConnexion = "Server=localhost\\SQLEXPRESS;Database=GestionDepenses;Trusted_Connection=True;";

        // Constructeur privé et vide...
        private Connexion() { }

        public static SqlConnection GetInstance()
        {
            if (instance == null)
            {
                try
                {
                    instance = new SqlConnection(chaineDeConnexion);
                    instance.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur de connexion : " + ex.Message);
                }
            }
            return instance;
        }
    }
}