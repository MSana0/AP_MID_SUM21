//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class showorder
    {
        public int Id { get; set; }
        public int Product_id { get; set; }
        public int Order_id { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    
        public virtual order order { get; set; }
        public virtual product product { get; set; }
    }
}
