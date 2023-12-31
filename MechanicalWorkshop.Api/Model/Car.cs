namespace MechanicalWorkshop.Api.Model
{
    public record Car
    {
        public Car()
        {

        }

        public Car(string brandName, string modelName)
        {
            this.BrandName = brandName;
            this.ModelName = modelName;
        }

        public int Id { get; set; }
        public string VIN { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public int CustomerId { get; set; }
        public Customer Owner { get; set; }
    }
}
