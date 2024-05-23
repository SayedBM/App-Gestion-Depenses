using MagasinDAOinterface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depenses
{
    public class Categorie
    {
        private int id;
        private string libelle;
        private SqlConnection connexion;
        public Categorie()
        {
            connexion = Connexion.GetInstance();
        }
        public Categorie(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;

        }

        

        public int GetIdCat()
        {
            return id;
        }

        public string GetLibelleCat()
        {
            return libelle;
        }
        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public override string ToString()
        {
            return $"id :{Id}  Libelle : {libelle}" ;
        }
    }
}
