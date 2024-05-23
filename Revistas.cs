using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2_Derick
{
    public class Revistas : Libros
    {
        public int Volumen { get; set; }
        public int NumEjemplar { get; set; }

        public Revistas()
        {
            Volumen = 0;
            NumEjemplar = 0;
        }
    }
}
