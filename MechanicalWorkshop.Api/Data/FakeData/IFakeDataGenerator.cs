namespace MechanicalWorkshop.Api.Data.FakeData
{
    public interface IFakeDataGenerator<T>
    {
        List<T> SeedWithData();
    }
}
