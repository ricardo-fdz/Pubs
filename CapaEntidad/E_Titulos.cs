using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class E_Titulos
    {
        public string IdTitulo { get; set; }
        public string Titulo { get; set; }
        public string TipoLibro { get; set; }
        public string IdEditorial { get; set; }
        public double Precio { get; set; }
        public double Anticipo { get; set; }
        public int Regalias { get; set; }
        public int VentasAnio { get; set; }
        public string Nota { get; set; }
        public DateTime FechaPublicacion { get; set; }

        public string Error { get; set; }
    }
}
