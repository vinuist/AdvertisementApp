using Aca.AdvertisementApp.Common.Enums;
using Aca.AdvertisementApp.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aca.AdvertisementApp.Business.ValidationRules
{
    public class AdvertisementAppUserCreateDtoValidator : AbstractValidator<AdvertisementAppUserCreateDto>
    {
        public AdvertisementAppUserCreateDtoValidator()
        {
            RuleFor(x => x.AdvertisementAppUserStatusId).NotEmpty();
            RuleFor(x => x.AdvertisementId).NotEmpty();
            RuleFor(x => x.AppUserId).NotEmpty();
            RuleFor(x => x.CvPath).NotEmpty().WithMessage("Bir cv dosyası seçiniz.");
            RuleFor(x => x.EndDate).NotEmpty().When(x => x.MilitaryStatusId == (int)MilitaryStatusType.Tecilli).WithMessage("Tecil tarihi boş bırakılamaz");
           
        }
    }
}
