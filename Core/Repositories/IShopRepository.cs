
using Core.Domain;

namespace Core.Repositories
{
    public interface IShopRepository : IRepository<Shop>
    {
        Shop GetShopWithCars(int id);
    }
}
