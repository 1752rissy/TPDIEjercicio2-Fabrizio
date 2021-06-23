using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Operador:IABM,IABM2
    {
        public string nombre { get; set; }

        public string apellido { get; set; }

        public string dni { get; set; }

        public string Buscar()
        {
            return "buscando operador...";
        }

        public string Eliminar()
        {
            return "Eliminando operador...";
        }

        public string Insertar()
        {
            return "Insertando operador...";
        }

        public string Modificar()
        {
            return "Modificando operador...";
        }

        public string Obtener()
        {
            return "Obteniendo operador...";
        }

        public string obtenerUltimo()
        {
            return "Obteniendo el ultimo operador...";
        }
    }
}
