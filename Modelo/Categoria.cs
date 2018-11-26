using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Categoria
    {
        private string codcat;
        private string nomcat;
        private string descat;

        public Categoria()
        {

        }
        public Categoria(string cod, string nom, string des)
        {
            this.codcat = cod;
            this.nomcat = nom;
            this.descat = des;
        }

        public string getCod
        {
            get { return this.codcat; }
            set { this.codcat = value; }
        }
        public string getNom
        {
            get { return this.nomcat; }
            set { this.nomcat = value; }
        }
        public string getDes
        {
            get { return this.descat; }
            set { this.descat = value; }
        }
    }
}
