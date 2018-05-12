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
        public int SubcribedUsers { get; set; }
        public int Registered { get; set; }
        public int Charged { get; set; }
        public int ChargedAndRegistered { get; set; }
        public int Cancellation { get; set; }
        public int ActiveUsers { get; set; }
        public List<Tables> ReportGeneral { get; set; }
        public List<ValMonth> ValuesPerMonth { get; set; }
        public List<CpMetrics> CompaniesMetrics { get; set; }
    }
}
