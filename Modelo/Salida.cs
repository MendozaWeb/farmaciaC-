using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class Salida
    {
        private string codsal;
        private DateTime fechsal;
        private Producto codpro;
        private int cant;
        private Usuario codusu;
        private Proveedor codprov;


        public Salida()
        {
            this.codpro = new Producto();
            this.codusu = new Usuario();
            this.codprov = new Proveedor();
        }
        public Salida(string cod, DateTime fecha, string copro, int cantidad, int cousu, string coprov)
        {
            this.codsal = cod;
            this.fechsal = fecha;
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
            get { return this.codsal; }
            set { this.codsal = value; }
        }
        public DateTime getFech
        {
            get { return this.fechsal; }
            set { this.fechsal = value; }
        }
        public Producto getCodProd
        {
            get { return this.codpro; }
            set { this.codpro = value; }
        }
        public int getCant
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
