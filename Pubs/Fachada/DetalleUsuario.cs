using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pubs.Fachada
{
    class DetalleUsuario
    {

        private string _NombreUsuario = string.Empty;

        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }
        
        public bool EsAdmin { get; set;}

        
    }
}
