using Aca.AdvertisementApp.Common;
using Aca.AdvertisementApp.Dtos;
using Aca.AdvertisementApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aca.AdvertisementApp.Business.Interfaces
{
    public interface IAdvertisementService:IService<AdvertisementCreateDto,AdvertisementUpdateDto,AdvertisementListDto,Advertisement>
    {
        Task<IResponse<List<AdvertisementListDto>>> GetActivesAsync();
    }
}
