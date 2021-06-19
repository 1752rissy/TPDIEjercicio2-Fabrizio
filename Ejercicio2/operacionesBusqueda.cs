using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class operacionesBusqueda
    {
        private readonly IABM2 _operacionesBusqueda;
        public operacionesBusqueda(IABM2 operacionesBusqueda)
        {
            _operacionesBusqueda = operacionesBusqueda;

        }

        public string Buscando()
        {
            return _operacionesBusqueda.Buscar();
        }

        public string Obteniendo()
        {
            return _operacionesBusqueda.Obtener();
        }

        public string obteniendoUltimo()
        {
            return _operacionesBusqueda.obtenerUltimo();
        }
    }
}
