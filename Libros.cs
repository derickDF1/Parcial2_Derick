using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2_Derick
{
    public class Libros
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Genero { get; set; }
        public DateTime AnioPublicacion { get; set; }

        public Libros()
        {
            Titulo = string.Empty;
            Autor = string.Empty;
            Genero = string.Empty;
            AnioPublicacion = DateTime.MinValue;
        }
    }
}
