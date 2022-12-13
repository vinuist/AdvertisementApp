using Aca.AdvertisementApp.DataAccess.Contexts;
using Aca.AdvertisementApp.DataAccess.Interfaces;
using Aca.AdvertisementApp.DataAccess.Repositories;
using Aca.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aca.AdvertisementApp.DataAccess.UnitOfWork
{
    public class Uow:IUow
    {
        private readonly AdvertisementContext _context;

        public Uow(AdvertisementContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : BaseEntity
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
