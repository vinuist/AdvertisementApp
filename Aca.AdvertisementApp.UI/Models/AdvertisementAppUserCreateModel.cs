﻿using Aca.AdvertisementApp.Common.Enums;
using Microsoft.AspNetCore.Http;
using System;

namespace Aca.AdvertisementApp.UI.Models
{
    public class AdvertisementAppUserCreateModel
    {
        public int AdvertisementId { get; set; }
        public int AppUserId { get; set; }

        public int AdvertisementAppUserStatusId { get; set; } = (int)AdvertisementAppUserStatusType.Basvurdu;

        public int MilitaryStatusId { get; set; }

        public DateTime? EndDate { get; set; }

        public int WorkExperience { get; set; }

        public IFormFile CvFile { get; set; }
    }
}
