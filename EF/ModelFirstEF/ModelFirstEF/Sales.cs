//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelFirstEF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sales
    {
        public int SalesId { get; set; }
        public int PrdId { get; set; }
        public int QtySold { get; set; }
        public int ProductProductId { get; set; }
    
        public virtual Product Product { get; set; }
    }
}
