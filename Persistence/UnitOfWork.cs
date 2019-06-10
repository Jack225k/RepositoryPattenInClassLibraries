using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarShopRepositoryImplementation.Core;
using Core.Repositories;
using Persistence;
using Persistence.Repositories;


namespace Persistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CarShopContext _context;

        public void Dispose()
        {
            _context.Dispose();
        }

        public UnitOfWork(CarShopContext context)
        {
            _context = context;
            Cars = new CarRepository(_context);
            Shops = new ShopRespository(_context);
        }

        public ICarRepository Cars { get; }
        public IShopRepository Shops { get; }
        public int Complete()
        {
            return _context.SaveChanges();
        }
    }
}