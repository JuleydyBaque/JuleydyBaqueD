using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronAdapter.Clases
{

    //Adaptado: esta es la funcionalidad que desea el cliente pero su 
    //interfaz no es compatible con el cliente.

    public class EmpresaZurita
    {
        public string [][] ObtenerEmpleados()
        {
            string[][] empleado = new string[4][];

 
            empleado[0] = new string[] { "100", "Juan Delgado", "Equipo Leader" }; 
            empleado[1] = new string[] { "101", "Manuel Medrando", "Desarrollador" };
            empleado[2] = new string[] { "102", "Pablo Dazán", "Desarrollador" };
            empleado[3] = new string[] { "103", "Alex Arevalos", "Técnico" };

            return empleado;
        }
    }
}
