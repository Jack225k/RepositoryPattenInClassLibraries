using System.Collections.Generic;
using Core.Domain;


namespace Core.Repositories
{
    public interface ICarRepository : IRepository<Car>
    {
        IEnumerable<Car> GetTopSellingCars(int pageIndex, int pageSize);
        IEnumerable<Car> GetTopSellingModels(int pageIndex, int pageSize);
        IEnumerable<Car> GetTopSellingMake(int pageIndex, int pageSize);
    }
}
