//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Airlines_WebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class FlightSchedule
    {
        public System.DateTime DateFlight { get; set; }
        public string FlightId { get; set; }
        public int AvailableSeats { get; set; }
    
        public virtual Flight Flight { get; set; }
    }
}
