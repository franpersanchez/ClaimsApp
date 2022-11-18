﻿namespace VehicleClaimsApplication.Models
{
    public class Owner
    {
        private List<Vehicle>? vehicles;

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? DriverLicense { get; set; }
        public List<Vehicle>? Vehicles { get; set; }

        public Owner()
        {
            Vehicles = new List<Vehicle>();
        }
    }
}
