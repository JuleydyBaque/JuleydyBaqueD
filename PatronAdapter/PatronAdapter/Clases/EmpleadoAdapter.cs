using PatronAdapter.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter.Clases
{

    //Adaptador: esta es la clase que implementaría ITarget y llamaría al código Adaptado (empresaZurita) que el cliente quiere llamar.
    public class EmpleadoAdapter : EmpresaZurita, ITarget 
    {
        public List<string> ObtenerListaEmpleados()
        {
            List<string> ListaEmpleado = new List<string>();
            string[][] empleado = ObtenerEmpleados();
            foreach (string[] empleados in empleado)
            {
                ListaEmpleado.Add(empleados[0]);
                ListaEmpleado.Add(" , ");
                ListaEmpleado.Add(empleados[1]);
                ListaEmpleado.Add(" , ");
                ListaEmpleado.Add(empleados[2]);
                ListaEmpleado.Add("\n");

            }

            return ListaEmpleado;
        }
    }
}
