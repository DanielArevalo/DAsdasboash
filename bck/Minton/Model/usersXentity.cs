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
    
    public partial class usersXentity
    {
        public int uenti_id { get; set; }
        public int enti_id { get; set; }
        public string user_id { get; set; }
    
        public virtual entity entity { get; set; }
        public virtual users users { get; set; }
    }
}
