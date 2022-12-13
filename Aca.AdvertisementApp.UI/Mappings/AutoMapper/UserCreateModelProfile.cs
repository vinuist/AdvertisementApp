using Aca.AdvertisementApp.Dtos;
using Aca.AdvertisementApp.UI.Models;
using AutoMapper;

namespace Aca.AdvertisementApp.UI.Mappings.AutoMapper
{
    public class UserCreateModelProfile : Profile
    {
        public UserCreateModelProfile()
        {
            CreateMap<UserCreateModel, AppUserCreateDto>();
        }
    }
}
