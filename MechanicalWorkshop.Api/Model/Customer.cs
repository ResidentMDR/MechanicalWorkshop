namespace MechanicalWorkshop.Api.Model
{
    public record Customer
    {
        public Customer()
        {
            FullName = $"{FirstName} {LastName}";
        }

        public int Id { get; init; }
        public string? FirstName { get; init; }
        public string? LastName { get; init; }
        public string? FullName { get; init; }
        public ICollection<Car> Cars { get; }
    }
}
