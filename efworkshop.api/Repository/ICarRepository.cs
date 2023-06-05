using efworkshop.api.Model;

namespace efworkshop.api.Repository
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetCars();
    }
}
