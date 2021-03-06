//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DdacAssignment
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shipment
    {
        public int Id { get; set; }
        public string type { get; set; }
        public int insured_value { get; set; }
        public int weight { get; set; }
        public string destination { get; set; }
        public string status { get; set; }
        public int CustomerId { get; set; }
        public int YardId { get; set; }
        public int ShipId { get; set; }
        public string payment_status { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Yard Yard { get; set; }
        public virtual Ship Ship { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
