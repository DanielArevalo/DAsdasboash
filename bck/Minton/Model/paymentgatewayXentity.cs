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
    
    public partial class paymentgatewayXentity
    {
        public int paygatent_id { get; set; }
        public string paygatent_decription { get; set; }
        public Nullable<int> enti_id { get; set; }
        public Nullable<int> curren_id { get; set; }
    
        public virtual currency currency { get; set; }
        public virtual entity entity { get; set; }
    }
}
