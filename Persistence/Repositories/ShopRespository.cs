using System;
using Core.Domain;
using Core.Repositories;

namespace Persistence.Repositories
{
    public class ShopRespository : Repository<Shop>, IShopRepository
    {
        public ShopRespository(CarShopContext context) : base(context)
        {
        }

        public CarShopContext CarShopContext
        {
            get { return Context as CarShopContext;}
        }
        public Shop GetShopWithCars(int id)
        {
            throw new NotImplementedException();
        }
    }
}