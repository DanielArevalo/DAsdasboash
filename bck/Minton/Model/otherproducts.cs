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
    
    public partial class otherproducts
    {
        public otherproducts()
        {
            this.productsXotherproducts = new HashSet<productsXotherproducts>();
        }
    
        public int oprod_id { get; set; }
        public string oprod_description { get; set; }
    
        public virtual ICollection<productsXotherproducts> productsXotherproducts { get; set; }
    }
}
