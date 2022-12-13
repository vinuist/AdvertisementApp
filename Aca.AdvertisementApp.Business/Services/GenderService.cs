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
    public class GenderService : Service<GenderCreateDto, GenderUpdateDto, GenderListDto, Gender>, IGenderService
    {
        public GenderService(IMapper mapper, IValidator<GenderCreateDto> createDtoValidator, IValidator<GenderUpdateDto> updateDtoValidator, IUow uow) : base(mapper, createDtoValidator, updateDtoValidator, uow)
        {

        }
    }
}
