using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{

    public class N_Usuarios
    {

        D_Usuarios DatosUsuarios = new D_Usuarios();  
        public List<E_Usuarios> VistaUsuarios()
        {
            return DatosUsuarios.VistaUsuarios();
        }

    }
}
