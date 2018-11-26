using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Producto
    {
        private string codpro;
        private string nompro;
        private double pre;
        private int stock;
        private DateTime fechpro;
        private Categoria codcat;

        public Producto()
        {
            this.codcat = new Categoria();
        }
        public Producto(string cod,string nom, double pre,int sto, DateTime Fechp,string codcat)
        {
            this.codpro = cod;
            this.nompro = nom;
            this.pre = pre;
            this.stock = sto;
            this.fechpro = Fechp;
            this.codcat = new Categoria();
            this.codcat.getCod = codcat;
        }

        public string getCod
        {
            get { return this.codpro; }
            set { this.codpro = value; }
        }
        public string getNom
        {
            get { return this.nompro; }
            set { this.nompro = value; }
        }
        public double getPre
        {
            get { return this.pre; }
            set { this.pre = value; }
        }
        public int getSto
        {
            get { return this.stock; }
            set { this.stock = value; }
        }

        public DateTime getFech
        {
            get { return this.fechpro; }
            set { this.fechpro = value; }
        }
       
        public Categoria getCodcat
        {
            get { return this.codcat; }
            set { this.codcat = value; }
        }
    }
}
