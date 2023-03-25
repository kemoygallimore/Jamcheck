//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Jamcheck
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vehicle
    {
        public int id { get; set; }
        public int year { get; set; }
        public int makeid { get; set; }
        public string Model { get; set; }
        public int fuelid { get; set; }
        public string ChassisNo { get; set; }
        public string VinNum { get; set; }
        public int Mileage { get; set; }
        public int Seating { get; set; }
        public int steeringid { get; set; }
        public int bodytypeid { get; set; }
        public int transmissionid { get; set; }
        public int ImportfromID { get; set; }
        public string Importer { get; set; }
        public System.DateTime ImportDate { get; set; }
        public byte[] Picture { get; set; }
    
        public virtual Fuel Fuel { get; set; }
        public virtual ImportFrom ImportFrom { get; set; }
        public virtual Make Make { get; set; }
        public virtual SteeringPosition SteeringPosition { get; set; }
        public virtual TransmissionType TransmissionType { get; set; }
        public virtual VehicleType VehicleType { get; set; }
    }
}
