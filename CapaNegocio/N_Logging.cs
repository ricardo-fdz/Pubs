using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Logging
    {
        D_Logging objLogning = new D_Logging();

        public List<E_Logging> ObtenerUsuario(string Usuario, string Contrasena)
        {
            return objLogning.ValidaUsuario(Usuario, Contrasena);
        }
    }
}
