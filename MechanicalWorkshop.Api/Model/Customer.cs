namespace MechanicalWorkshop.Api.Model
{
    public record Customer
    {
        public Customer(int id)
        {
            this.Id = id;
        }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;

            FullName = $"{FirstName} {LastName}";
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public ICollection<Car>? Cars { get; set; }
    }
}
