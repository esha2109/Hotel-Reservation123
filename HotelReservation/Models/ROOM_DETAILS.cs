//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HotelReservation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ROOM_DETAILS
    {
        public string ROOM_ID { get; set; }
        public string ROOM_TYPE { get; set; }
        public decimal TOTAL_ROOMS { get; set; }
        public string STATUS { get; set; }
    
        public virtual ROOM_TYPE_INFO ROOM_TYPE_INFO { get; set; }
    }
}