using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parcial2_Derick
{
    public class LibrosElectronicos : Libros
    {
        public string Formato { get; set; }
        public string TamanioArchivo { get; set; }

        public LibrosElectronicos()
        {
            Formato = string.Empty;
            TamanioArchivo = string.Empty;
        }
    }
}
