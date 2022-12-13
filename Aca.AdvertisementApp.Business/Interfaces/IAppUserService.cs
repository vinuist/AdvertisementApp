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
    public interface IAppUserService : IService<AppUserCreateDto, AppUserUpdateDto, AppUserListDto, AppUser>
    {
        Task<IResponse<AppUserCreateDto>> CreateWithRoleAsync(AppUserCreateDto dto, int roleId);
        Task<IResponse<AppUserListDto>> CheckUserAsync(AppUserLoginDto dto);
        Task<IResponse<List<AppRoleListDto>>> GetRolesByUserIdAsync(int userId);
       
    }
}
