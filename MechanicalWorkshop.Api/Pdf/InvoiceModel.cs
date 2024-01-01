using MechanicalWorkshop.Api.Model;

namespace MechanicalWorkshop.Api.Pdf
{
    public class InvoiceModel
    { 
        private List<SamplePart> parts;
        public List<SamplePart> Parts
        { 
            get => parts ??= new List<SamplePart>(SamplePart.CreateSamplePartsList()); 
        }

        private double grandTotal;

        public double GrandTotal
        {
            get
            {
                CalculateGrandTotal();
                return grandTotal;
            }
        }

        private string hint = "Zalecamy zmieniać olej co ok. 10-15 tys. km w celu przedłużenia żywotności części mechanicznych";
        public string Hint
        {
            get => hint;
        }

        private void CalculateGrandTotal()
        {
            foreach (var part in parts)
            {
                this.grandTotal += part.TotalPrice; 
            }
        }
}
}
