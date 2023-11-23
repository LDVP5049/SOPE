using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOPE
{
    class Nodo
    {
        public Perro DatosPerro { get; set; }
        public Nodo Siguiente { get; set; }

        public Nodo(Perro datosPerro)
        {
            DatosPerro = datosPerro;
            Siguiente = null;
        }
    }
}
