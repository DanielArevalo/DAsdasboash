//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Milton.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class appoiment
    {
        public appoiment()
        {
            this.gto = new HashSet<gto>();
        }
    
        public int appo_id { get; set; }
        public System.DateTime appo_date { get; set; }
        public int appo_usercreation { get; set; }
        public int sales_id { get; set; }
        public int uprov_id { get; set; }
    
        public virtual sales sales { get; set; }
        public virtual usersXprovider usersXprovider { get; set; }
        public virtual ICollection<gto> gto { get; set; }
    }
}
