using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            Llave llave = new Llave();
            Vehiculo vehiculo = new Vehiculo();
            Operador operador = new Operador();
            operacionesABM operacionesabm = new operacionesABM(llave);
            operacionesABM operacionesabm1 = new operacionesABM(vehiculo);
            operacionesABM operacionesabm2 = new operacionesABM(operador);
            operacionesBusqueda operacionesbusqueda = new operacionesBusqueda(llave);
            operacionesBusqueda operacionesbusqueda1 = new operacionesBusqueda(vehiculo);
            operacionesBusqueda operacionesbusqueda2 = new operacionesBusqueda(operador);
            Console.WriteLine(operacionesabm.Insertando());
            Console.WriteLine(operacionesabm1.Modificando());
            Console.WriteLine(operacionesabm2.Eliminando());
            Console.WriteLine(operacionesbusqueda.Buscando());
            Console.WriteLine(operacionesbusqueda.Obteniendo());
            Console.WriteLine(operacionesbusqueda2.obteniendoUltimo());


            Console.ReadLine();

        }
    }
}
