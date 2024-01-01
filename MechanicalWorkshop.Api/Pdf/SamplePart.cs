namespace MechanicalWorkshop.Api.Pdf
{
    public class SamplePart
    {
        public int ItemNumber { get; set; }
        public string PartName { get; set; }
        public double PricePerUnit { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }   

        public static List<SamplePart> CreateSamplePartsList()
        {
            var sampleParts = new List<SamplePart>()
            {
                new SamplePart { ItemNumber = 1, PartName = "Olej silnikowy", PricePerUnit = 25.99, Quantity = 5 },
                new SamplePart { ItemNumber = 2, PartName = "Filtr powietrza", PricePerUnit = 32.99, Quantity = 1 },
                new SamplePart { ItemNumber = 3, PartName = "Świece zapłonowe", PricePerUnit = 30.99, Quantity = 8 },
                new SamplePart { ItemNumber = 4, PartName = "Klocki hamulcowe", PricePerUnit = 59.99, Quantity = 2 },
                new SamplePart { ItemNumber = 5, PartName = "Płyn do skrzyni biegów", PricePerUnit = 59.99, Quantity = 1 },
                new SamplePart { ItemNumber = 6, PartName = "Akumulator", PricePerUnit = 519.99, Quantity = 1 },
                new SamplePart { ItemNumber = 7, PartName = "Pióra wycieraczek", PricePerUnit = 24.99, Quantity = 2 }
            };

            foreach (var part in sampleParts)
            {
                part.TotalPrice = part.PricePerUnit * part.Quantity;
            }

            return sampleParts;
        }
    }
}
