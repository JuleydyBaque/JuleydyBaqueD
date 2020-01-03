using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PatronAdapter.Interfaz;
using PatronAdapter.Clases;

namespace PatronAdapter
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget Itarget = new EmpleadoAdapter();
            SistemaFacturacion cliente = new SistemaFacturacion(Itarget);
            cliente.MostarListaEmpleados();
            Console.ReadKey();
        }
    }
}
