using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class Departamento:Terreno
    {
        private int piso;
        private int numeroDepartamento;
        private double costoConstruccion;
        private double valorDepartamento;

        public int Piso
        {
            get { return piso; }
            set { piso = value; }
        }

        public int NumeroDepartamento
        {
            get { return numeroDepartamento; }
            set { numeroDepartamento = value; }
        }
        public double CostoConstruccion
        {
            get { return costoConstruccion; }
            set { costoConstruccion = value; }
        }

        public double ValorDepartamento
        {
            get { return valorDepartamento; }
            set { valorDepartamento = value; }
        }
    }
}
