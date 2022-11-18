﻿namespace VehicleClaimsApplication.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        public string? Brand { get; set; }
        public string? Vin { get; set; }
        public string? Color { get; set; }
        public int? Year { get; set; }
        public int? OwnerId { get; set; }
        public  Owner? Owner { get; set; }

        public List<Claim>? Claims { get; set; }


    }
}
