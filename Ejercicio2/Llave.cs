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
            return "buscando...";
        }

        public string Eliminar()
        {
            return "Eliminar...";
        }

        public string Insertar()
        {
            return "Insertando...";
        }

        public string Modificar()
        {
            return "Modificando...";
        }

        public string Obtener()
        {
            return "Obteniendo...";
        }

        public string obtenerUltimo()
        {
            return "Obteniendo el ultimo...";
        }
    }
}
