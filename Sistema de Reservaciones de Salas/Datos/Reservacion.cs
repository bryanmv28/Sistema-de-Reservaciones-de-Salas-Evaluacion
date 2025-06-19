using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservaciones.Datos
{
    public class Reservacion
    {
        public int IdReservacion { get; set; }
        public int IdSala { get; set; }
        public int IdCliente { get; set; }
        public DateTime FechaReservacion { get; set; }
    }
}
