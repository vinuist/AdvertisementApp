﻿using Aca.AdvertisementApp.Dtos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aca.AdvertisementApp.Dtos
{
    public class GenderUpdateDto:IUpdateDto
    {
        public int Id { get; set; }
        public string Definition { get; set; }
    }
}
