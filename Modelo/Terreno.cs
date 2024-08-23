using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Terreno
    {
        protected string direccion;
        protected string titular;
        protected int nCatastro;
        protected double valorM2;
        protected double cantidadM2;
        protected double valorTerreno;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        public int NCatastro
        {
            get { return nCatastro; }
            set { nCatastro = value; }
        }
        public double ValorM2
        {
            get { return valorM2; }
            set { valorM2 = value; }
        }
        public double CantidadM2
        {
            get { return cantidadM2; }
            set { cantidadM2 = value; }
        }
        public double ValorTerreno
        {
            get { return valorTerreno; }
            set { valorTerreno = value; }
        }

    }
}
