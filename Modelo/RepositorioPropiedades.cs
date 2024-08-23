using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class RepositorioPropiedades
    {
        private static RepositorioPropiedades instancia;
        private List<Terreno> listaPropiedades;
        private double totalGastadoTerreno;
        private double totalGastadoCasas;
        private double totalGastadoDptos;
      
        public double TotalGastadoTerreno
        {
            get { return totalGastadoTerreno; }
            set { totalGastadoTerreno = value; }
        }

        public double TotalGastadoCasas
        {
            get { return totalGastadoCasas;}
            set { totalGastadoCasas = value;}
        }
        public double TotalGastadoDptos
        {
            get { return totalGastadoDptos; }
            set { totalGastadoDptos = value; }
        }

        // Singleton
        private RepositorioPropiedades()
        {
            listaPropiedades = new List<Terreno>();
        }

        public static RepositorioPropiedades Instancia
        {
            get
            {
                if( instancia == null)
                {
                    instancia = new RepositorioPropiedades();
                }
                return instancia;
            }
        }

        // Metodo para guardar las propiedades en el repositorio
        public void AgregarPropiedad(Terreno propiedad)
        {
            listaPropiedades.Add(propiedad);
        }

        // Lista con todas las propiedades
        public ReadOnlyCollection<Terreno> ListaPropiedades
        {
            get { return listaPropiedades.AsReadOnly(); }
        }

        // Filtramos la lista de propiedades para obtener solo los terrenos
        public List<Terreno> ListaTerrenos
        {
            get
            {
                return listaPropiedades.Except(listaPropiedades.OfType<Casa>().ToList()).Except(listaPropiedades.OfType<Departamento>().ToList()).ToList();
            }
        }

        // Lista de casas filtrando la lista de propiedades
        public List<Casa> ListaCasa
        {
            get
            {
                return listaPropiedades.OfType<Casa>().ToList();
            }
        }

        // Lista de departamentos filtrando la lista de propiedades
        public List<Departamento> ListaDepartamento
        {
            get
            {
                return listaPropiedades.OfType<Departamento>().ToList();
            }
        }

}
}
