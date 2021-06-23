using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class operacionesABM
    {
        private readonly IABM _operacionesABM;

        public operacionesABM(IABM operacionesABM)
        {
            _operacionesABM = operacionesABM;
        }

        public string Insertando()
        {
            return _operacionesABM.Insertar();
        }

        public string Modificando()
        {
            return _operacionesABM.Modificar();
        }

        public string Eliminando()
        {
            return _operacionesABM.Eliminar();
        }
    }
}
