using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milton.Models
{
    public class Tables
    {
        public DateTime Fecha { get; set; }
        public int Subcripciones { get; set; }
        public int Regitrados { get; set; }
        public int Registrados_Con_Pago_Activo { get; set; }
        public int Daily_Charged { get; set; }
        public int repeat_Charged { get; set; }

    }
}