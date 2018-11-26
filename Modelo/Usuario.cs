using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
   public class Usuario
    {
        private int codusu;
        private string nomusu;
        private string passusu;
        private string tipousu;

        public Usuario()
        {

        }

        public Usuario(int cod, string nom, string pass, string tipo)
        {
            this.codusu = cod;
            this.nomusu = nom;
            this.passusu = pass;
            this.tipousu = tipo;
        }
        public int getCod
        {
            get { return this.codusu; }
            set { this.codusu = value; }
        }
        public string getnom
        {
            get { return this.nomusu; }
            set { this.nomusu = value; }
        }

        public string getpass
        {
            get { return this.passusu; }
            set { this.passusu = value; }
        }
        public string gettipo
        {
            get { return this.tipousu; }
            set { this.tipousu = value; }
        }


    }
}
