using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Vehiculo:IABM,IABM2
    {
        public string patente { get; set; }

        public string marca { get; set; }

        public string Buscar()
        {
            return "buscando vehiculo...";
        }

        public string Eliminar()
        {
            return "Eliminando vehiculo...";
        }

        public string Insertar()
        {
            return "Insertando vehiculo...";
        }

        public string Modificar()
        {
            return "Modificando vehiculo...";
        }

        public string Obtener()
        {
            return "Obteniendo vehiculo...";
        }

        public string obtenerUltimo()
        {
            return "Obteniendo el ultimo vehiculo...";
        }
    }
}
