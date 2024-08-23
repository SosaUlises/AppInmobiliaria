using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Casa:Terreno
    {
        private double valorM2Construido;
        private double cantidadM2Construido;
        private double valorCasa;

        public double ValorM2Construido
        {
            get { return valorM2Construido; }
            set { valorM2Construido = value;}
        }

        public double CantidadM2Construido
        {
            get { return cantidadM2Construido; }
            set { cantidadM2Construido = value; }
        }

        public double ValorCasa
        {
            get { return valorCasa; }
            set { valorCasa = value; }
        }
    }
}
