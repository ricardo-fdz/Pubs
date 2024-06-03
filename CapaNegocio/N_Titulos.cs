using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using CapaDatos;

namespace CapaNegocio
{
    public class N_Titulos
    {
        public List<E_Titulos> ObtenerTitluos()
        {
            D_Titulos pubsTitulo = new D_Titulos();
            return pubsTitulo.ObtenerTitulos();
        }

        public string AltaTitulo(string IdTitulo, string Titulo, string Tipo, string IdPub, decimal Precio,
                    decimal Anticipo, int Regalias, int YtdVentas, string Notas, DateTime FechaPublicacion)
        {
            D_Titulos d_Titulos = new D_Titulos();
            return d_Titulos.AltaTitulo(IdTitulo, Titulo, Tipo, IdPub, Precio, Anticipo,Regalias, YtdVentas, Notas, FechaPublicacion);
        }
    }
}
