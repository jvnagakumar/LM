//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMEntities
{
    using System;
    using System.Collections.Generic;
    
    public partial class EventAddress
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public Nullable<int> OrganizationId { get; set; }
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCd { get; set; }
        public string LandMark { get; set; }
    
        public virtual Event Event { get; set; }
        public virtual Organization Organization { get; set; }
    }
}
