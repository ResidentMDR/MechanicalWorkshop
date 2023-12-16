namespace MechanicalWorkshop.Api.Model
{
    public record Car
    {
        public Car(int id)
        {
            this.Id = id;
        }

        public Car(string brandName, string modelName)
        {
            this.BrandName = brandName;
            this.ModelName = modelName;
        }

        public int Id { get; init; }
        public string? VIN { get; init; }
        public string? BrandName { get; init; }
        public string? ModelName { get; init; }
        public int CustomerId { get; init; }
        public Customer Owner { get; init; }
    }
}
