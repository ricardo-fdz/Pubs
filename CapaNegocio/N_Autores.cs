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
    public class N_Autores
    {
        
            D_Autores d_Autores;
        public List<E_Autores> vistaAutores()
        {
            d_Autores = new D_Autores();
            return d_Autores.VistaAutores();
        }

        public string AltaAutor(string IdAutor, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodPostal, bool Contrato)
        {
            d_Autores = new D_Autores();
            return d_Autores.InsertarAutor(IdAutor, Nombre, Apellido, Telefono, Direccion, Ciudad, Estado, CodPostal, Contrato);
        }

        public string ActualizaAutor(string IdAutor, string Nombre, string Apellido, string Telefono, string Direccion, string Ciudad, string Estado, string CodPostal, bool Contrato)
        {
            d_Autores = new D_Autores();
            return d_Autores.AuctualizarAutor(IdAutor, Nombre, Apellido, Telefono, Direccion, Ciudad, Estado, CodPostal, Contrato);
        }
    }
}
