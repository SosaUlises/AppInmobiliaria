using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladora
{
    public class GestorPropiedades
    {
        // Singleton
        private static GestorPropiedades instancia;

        private GestorPropiedades() { }

        public static GestorPropiedades Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new GestorPropiedades();
                }
                return instancia;
            }
        }
        // Funcion para crear propiedad (Terreno, Casa, Departamento)
        public string CrearPropiedad(Terreno nuevaPropiedad, RepositorioPropiedades repo)
        {
            var existeCatastro = repo.ListaPropiedades.FirstOrDefault(a => a.NCatastro == nuevaPropiedad.NCatastro);
            
            // Departamento
            if (nuevaPropiedad is Departamento) 
            {
                Departamento nuevoDpto = (Departamento)nuevaPropiedad;
                // Valido que no exista ese departamento
                if (ValidarDepto(repo,nuevoDpto) == true && existeCatastro == null) 
                {   
                    double valorTerreno = (nuevoDpto.CantidadM2 * nuevoDpto.ValorM2);
                    nuevoDpto.ValorTerreno = valorTerreno;
                    nuevoDpto.ValorDepartamento = valorTerreno + nuevoDpto.CostoConstruccion + (nuevoDpto.CostoConstruccion * 0.023);
                    repo.AgregarPropiedad(nuevoDpto); // Agregamos al repositorio
                    repo.TotalGastadoDptos += nuevoDpto.ValorDepartamento; // Calculo del total gastado
                    return "Departamento creado";
                }
                else
                {
                    return "Este departamento o catastro ya existe!";
                }
            } 
            // Casa
            else if (nuevaPropiedad is Casa)
            {
                // Valido que no exista el catastro
                if (existeCatastro == null)
                {
                    Casa nuevaCasa = (Casa)nuevaPropiedad;
                    double valorTerreno = (nuevaCasa.CantidadM2 * nuevaCasa.ValorM2);
                    nuevaCasa.ValorTerreno = valorTerreno;
                    nuevaCasa.ValorCasa = valorTerreno + (nuevaCasa.CantidadM2Construido * nuevaCasa.ValorM2Construido);
                    repo.AgregarPropiedad(nuevaCasa); // Agregamos al repositorio
                    repo.TotalGastadoCasas += nuevaCasa.ValorCasa; // Calculo del total gastado
                    return "Casa creada!";
                }
                else
                {
                    return "Numero de catastro ya usado!";
                }
            }
            else
            { // Terreno
                // Valido que no exista el catastro
                if(existeCatastro == null)
                {
                    nuevaPropiedad.ValorTerreno = (nuevaPropiedad.ValorM2 * nuevaPropiedad.CantidadM2);
                    repo.AgregarPropiedad(nuevaPropiedad); // Agregamos al repositorio
                    repo.TotalGastadoTerreno += nuevaPropiedad.ValorTerreno; // Calculo del total gastado
                    return "Terreno creado!";
                }
                else
                {
                    return "Numero de catastro ya usado!";
                }
            }
        }

        // Funcion para validar que no exista un departamento con ese piso y numero de dpto.
        public bool ValidarDepto(RepositorioPropiedades repo, Departamento propiedad)
        {
            List<Departamento> deptosMismoPiso = new List<Departamento>();

            foreach (var item in repo.ListaDepartamento)
            {
                if (item.Piso == propiedad.Piso)
                {
                    deptosMismoPiso.Add(item); // Vamos almacenando en una lista los deptos del mismo piso
                }
            }
            var sonMismoDpto = deptosMismoPiso.FirstOrDefault(a => a.NumeroDepartamento == propiedad.NumeroDepartamento);
            // Validamos que en esa lista, ya no exista un departamento con el nuevo numero de dpto.
            if(sonMismoDpto != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
