using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Detalle_Entrada
    {
        private string coddetalle;
        private DateTime fechent;
        private Entrada codent;
        private Producto codpro;
        private Proveedor codprov;
        private int stock;
        private float precio;


        public Detalle_Entrada()
        {
            this.codpro = new Producto();
            this.codent = new Entrada();
            this.codprov = new Proveedor();
        }
        public Detalle_Entrada(string cod, DateTime fecha,string coentra, string copro, string coprov, int sto,float costo)
        {
            this.coddetalle = cod;
            this.fechent = fecha;
            this.codent = new Entrada();
            this.codpro = new Producto();
            this.codprov = new Proveedor();
            this.stock = sto;
            this.precio = costo;
        }

        public string getCod
        {
            get { return this.coddetalle; }
            set { this.coddetalle = value; }
        }
        public DateTime getFech
        {
            get { return this.fechent; }
            set { this.fechent = value; }
        }
        public Entrada getCodEntra
        {
            get { return this.codent; }
            set { this.codent = value; }
        }
        public Producto getCodProd
        {
            get { return this.codpro; }
            set { this.codpro = value; }
        }
        
        public Proveedor getCodProv
        {
            get { return this.codprov; }
            set { this.codprov = value; }
        }
        public int getCodStock
        {
            get { return this.stock; }
            set { this.stock = value; }
        }

        public float getCodPre
        {
            get { return this.precio; }
            set { this.precio = value; }
        }
    }
}
