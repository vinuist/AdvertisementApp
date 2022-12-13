using Aca.AdvertisementApp.DataAccess.Interfaces;
using Aca.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aca.AdvertisementApp.DataAccess.UnitOfWork
{
    public interface IUow
    {
        IRepository<T> GetRepository<T>() where T : BaseEntity;
        Task SaveChangesAsync();
    }
}
