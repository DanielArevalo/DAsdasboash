using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milton.Models
{
    public class General
    {
        public List<Activations> Activations { get; set; }
        public List<Intervalo> Interval { get; set; }
        public List<Subcribe> subcribe { get; set; }
        public List<Cancelation> cancellation { get; set; }
        public int ActiveUsers { get; set; }
        public List<Tables> ReportGeneral { get; set; }
    }
}
