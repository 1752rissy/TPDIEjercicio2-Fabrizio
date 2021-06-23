using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Llave : IABM, IABM2
    {
        public string codigoLlave { get; set; }

        public string Buscar()
        {
            return "buscando llave...";
        }

        public string Eliminar()
        {
            return "Eliminando llave...";
        }

        public string Insertar()
        {
            return "Insertando llave...";
        }

        public string Modificar()
        {
            return "Modificando llave...";
        }

        public string Obtener()
        {
            return "Obteniendo llave...";
        }

        public string obtenerUltimo()
        {
            return "Obteniendo el ultimo llave...";
        }
    }
}
