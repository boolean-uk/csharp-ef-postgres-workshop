using efworkshop.api.Data;
using efworkshop.api.Model;

namespace efworkshop.api.Repository
{
    public class CarRepository : ICarRepository
    {
        public IEnumerable<Car> GetCars()
        {
            using(var db = new CarContext())
            {
                return db.Cars.ToList();
            }
        }
    }
}
