using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Depenses
{
    internal class categorieDepense
    {
        private int id;
        private string libelle;

        public int Id { get => id; set => id = value; }
        public string Libelle { get => libelle; set => libelle = value; }

        public categorieDepense(int id, string libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
        
    }
}
