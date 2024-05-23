using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depenses
{
    public class Depenser
    {
        private int id;
        private decimal montant;
        private DateTime dateD;
        private string descrption;
        private int utilisaterID;
        private int categorieID;

        public Depenser(int id, decimal montant, DateTime dateD, string descrption, int utilisaterID, int categorieID)
        {
            this.id = id;
            this.montant = montant;
            this.dateD = DateTime.Now;
            DateD = dateD;
            this.descrption = descrption;
            this.utilisaterID = utilisaterID;
            this.categorieID = categorieID;
        }

        public int Id { get => id; set => id = value; }
        public decimal Montant { get => montant; set => montant = value; }
        public DateTime DateD { get => dateD; set => dateD = value; }
        public string Descrption { get => descrption; set => descrption = value; }
        public int UtilisaterID { get => utilisaterID; set => utilisaterID = value; }
        public int CategorieID { get => categorieID; set => categorieID = value; }
        
        public override string ToString()
        {
            return $"ID de la dépense : {id}\n" +
                   $"Montant : {montant}\n" +
                   $"Date de la dépense : {dateD}\n" +
                   $"Description : {descrption}\n" +
                   $"ID de l'utilisateur : {utilisaterID}\n" +
                   $"ID de la catégorie : {categorieID}";
        }

    }
}
