using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Usuarios
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario { get; set; }
        public string ContraseñaUsuario { get; set; }
        public bool EsAdministrador { get; set; }

        public string MensajeError { get; set; }

    }
}
