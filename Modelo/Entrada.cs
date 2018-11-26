using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class Entrada
    {
        private string codent;
        private DateTime fechent;
        private Producto codpro;
        private string cant;
        private Usuario codusu;
        private Proveedor codprov;


        public Entrada()
        {
            this.codpro = new Producto();
            this.codusu = new Usuario();
            this.codprov = new Proveedor();
        }
        public Entrada(string cod, DateTime fecha, string copro,string cantidad ,int cousu, string coprov)
        {
            this.codent = cod;
            this.fechent = fecha;
            this.codpro = new Producto();
            this.codpro.getCod = copro;
            this.cant = cantidad;
            this.codusu = new Usuario();
            this.codusu.getCod = cousu;
            this.codprov = new Proveedor();
            this.codprov.getCod = coprov;
        }

        public string getCod
        {
            get { return this.codent; }
            set { this.codent = value; }
        }
        public DateTime getFech
        {
            get { return this.fechent; }
            set { this.fechent = value; }
        }
        public Producto getCodProd
        {
            get { return this.codpro; }
            set { this.codpro = value; }
        }
        public string getCant
        {
            get { return this.cant; }
            set { this.cant = value; }
        }
        public Usuario getCodUsu
        {
            get { return this.codusu; }
            set { this.codusu = value; }
        }
        public Proveedor getCodProv
        {
            get { return this.codprov; }
            set { this.codprov = value; }
        }
    }
}
