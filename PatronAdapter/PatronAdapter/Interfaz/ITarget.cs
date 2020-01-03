using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using PatronAdapter.Clases;

namespace PatronAdapter.Interfaz
{

    //Interfaz: esta es la interfaz que utliza el cliente para lograr la funcionalidad
    interface ITarget
    {

        //realizamos una lista para obtener lo empleados a contratar 
        List<string> ObtenerListaEmpleados();

    }
}
