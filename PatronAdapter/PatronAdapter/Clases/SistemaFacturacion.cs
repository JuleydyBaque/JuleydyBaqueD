using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronAdapter.Interfaz;

namespace PatronAdapter.Clases
{

    //Cliente: es la clase que desea lograr alguna funcionalidad 
    //mediante el uso del codigo del adaptado (lista de empleados).
    public class SistemaFacturacion
    {
      
        private ITarget FuenteEmpleado;

        //crear el sistema de facturacion para pago de nuevso empleados a contratar
        public SistemaFacturacion (ITarget FuenteEmpleado)
        {
            this.FuenteEmpleado = FuenteEmpleado;

        }

        public void MostarListaEmpleados()
        {
            //llame a la lista de cliente en la interfaz.
            List<string> empleado = FuenteEmpleado.ObtenerListaEmpleados();

            Console.WriteLine("*******LISTA DE EMPLEADOS*******");
            foreach (var item in empleado)
            {
                Console.WriteLine(item);
            }
        }
    }
}

