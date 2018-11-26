using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Proveedor
    {
        private string codprov;
        private string nomprov;

        public Proveedor(){

        }
        public Proveedor(string Cod, string Nom )
        {
            this.codprov = Cod;
            this.nomprov = Nom;
        }

        public string getCod {
            get { return this.codprov; }
            set { this.codprov = value; } }
        public string getNom {
            get { return this.nomprov; }
            set { this.nomprov = value; } }

   }
}