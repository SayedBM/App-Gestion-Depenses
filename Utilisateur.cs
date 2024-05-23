using MagasinDAOinterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depenses
{
    public class Utilisateur
    {
        private int id;
        private string nom;
        private string email;
        private SqlConnection connexion;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Email { get => email; set => email = value; }

        public Utilisateur(int id, string nom, string email)
        {
            this.id = id;
            this.nom = nom;
            this.email = email;
        }
        public Utilisateur() { 
            connexion = Connexion.GetInstance();
        }

        public int GetId()
        {
            return id;
        }

        public string GetNom()
        {
            return nom;
        }

        public string GetEmail()
        {
            return email;
        }

        

        public override string ToString()
        {
            return "Identifiant : " + id + "\nEmail : " + email + "\nNom : " + nom;
        }

    }
}