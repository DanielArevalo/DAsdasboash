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
    
    public partial class glosas
    {
        public glosas()
        {
            this.glosastatusclaims = new HashSet<glosastatusclaims>();
            this.glosaXtreatments = new HashSet<glosaXtreatments>();
        }
    
        public int glosa_id { get; set; }
        public string glosa_description { get; set; }
    
        public virtual ICollection<glosastatusclaims> glosastatusclaims { get; set; }
        public virtual ICollection<glosaXtreatments> glosaXtreatments { get; set; }
    }
}
