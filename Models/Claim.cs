namespace VehicleClaimsApplication.Models
{
    public class Claim
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public bool? Status { get; set; }
        public DateTime? Date { get; set; }
        public int? VehicleId { get; set; }
        public Vehicle? Vehicle { get; set; }

    }
}
