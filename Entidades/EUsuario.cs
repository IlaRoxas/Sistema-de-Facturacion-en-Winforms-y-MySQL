using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class EUsuario
    {
        public int IdUsuario { get; }
        public DateTime FechaAlta { get; set; }
        public string NombreUsuario { get; set; }
        public string Password { get; set; }
        public int IdPersona { get; set; }
        public DateTime FechaCaducidadPassword { get; set; }
        public DateTime? FechaBaja { get; set; }
        public bool FlagBloqueado { get; set; }
        public int QIntentosFallidosLogin { get; set; }
        public bool FlagBajaLogica { get; set; }
    }
}
