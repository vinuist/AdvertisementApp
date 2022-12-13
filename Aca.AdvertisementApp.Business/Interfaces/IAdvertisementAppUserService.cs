using Aca.AdvertisementApp.Common.Enums;
using Aca.AdvertisementApp.Common;
using Aca.AdvertisementApp.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aca.AdvertisementApp.Business.Interfaces
{
    public interface IAdvertisementAppUserService
    {
        Task<IResponse<AdvertisementAppUserCreateDto>> CreateAsync(AdvertisementAppUserCreateDto dto);

        Task<List<AdvertisementAppUserListDto>> GetList(AdvertisementAppUserStatusType type);
        Task SetStatusAsync(int advertisementAppUserId, AdvertisementAppUserStatusType type);
    }
}
