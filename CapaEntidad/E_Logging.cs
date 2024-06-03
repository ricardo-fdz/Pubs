using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Logging
    {

        public bool EsAdmin { get; set; }

        private string _NombreUsuario = string.Empty;

        public string NombreUsuario
        {
            get { return _NombreUsuario; }
            set { _NombreUsuario = value; }
        }

        public string Error { get; set; }
    }
}
