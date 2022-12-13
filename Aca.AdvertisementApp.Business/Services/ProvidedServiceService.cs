using Aca.AdvertisementApp.Business.Interfaces;
using Aca.AdvertisementApp.DataAccess.UnitOfWork;
using Aca.AdvertisementApp.Dtos;
using Aca.AdvertisementApp.Entities;
using AutoMapper;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aca.AdvertisementApp.Business.Services
{
    public class ProvidedServiceService : Service<ProvidedServiceCreateDto, ProvidedServiceUpdateDto, ProvidedServiceListDto, ProvidedService>, IProvidedServiceService
    {
        public ProvidedServiceService(IMapper mapper, IValidator<ProvidedServiceCreateDto> createDtoValidator, IValidator<ProvidedServiceUpdateDto> updateDtoValidator, IUow uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {
        }

    }
}
