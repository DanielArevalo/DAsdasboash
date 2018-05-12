using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milton.Models
{
    public class Tables
    {
        public DateTime Fecha { get; set; }
        public int Suscripciones { get; set; }
        public int Registrados { get; set; }
        public int registrados_con_pago_activo { get; set; }
        public int daily_charged { get; set; }
        public int repeat_charged { get; set; }
    }
}