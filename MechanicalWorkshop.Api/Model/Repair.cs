namespace MechanicalWorkshop.Api.Model
{
    public record Repair
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public int CustomerId { get; set; }
        public Car Car { get; set; }
        public int CarId { get; set; }
        public string Description { get; set; }
        public double? Price { get; set; }
        public DateTime RegistrationDate { get; set; } = DateTime.Now;
        public Mechanic? Mechanic { get; set; }
        public int? MechanicId { get; set; }
    }
}
