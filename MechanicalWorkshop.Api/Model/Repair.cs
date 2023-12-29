namespace MechanicalWorkshop.Api.Model
{
    public record Repair
    {
        public int Id { get; init; }
        public Customer? Customer { get; init; }
        public Car? Car { get; init; }
        public string? Description { get; init; }
        public double? Price { get; init; }
        public DateTime? RegistrationDate { get; init; } = DateTime.Now;
        public Mechanic? Mechanic { get; init; }
    }
}
