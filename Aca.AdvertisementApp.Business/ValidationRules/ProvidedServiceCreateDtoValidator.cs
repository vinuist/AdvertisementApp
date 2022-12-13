using Aca.AdvertisementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aca.AdvertisementApp.Business.ValidationRules
{
    public class ProvidedServiceCreateDtoValidator:AbstractValidator<ProvidedServiceCreateDto>
    {
        public ProvidedServiceCreateDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty();
            RuleFor(x => x.ImagePath).NotEmpty();
            RuleFor(x => x.Description).NotEmpty();
           
           
        }
    }
}
