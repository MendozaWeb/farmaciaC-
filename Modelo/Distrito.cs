using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Distrito
    {
        private int coddist;
        private string nomdist;

        public Distrito()
        {

        }

        public Distrito(int Cod,string Nom)
        {
            this.coddist = Cod;
            this.nomdist = Nom;
        }

        public int getCod
        {
            get { return this.coddist; }
            set { this.coddist = value; }
        }

        public string getNom
        {
            get { return this.nomdist; }
            set { this.nomdist = value; }
        }

    }
}
