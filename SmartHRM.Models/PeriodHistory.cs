﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class PeriodHistory : BaseModel
    {
        public int Id { get; set; }
        public int CurrentPeriod { get; set; }
        public string PeriodWord { get; set; }
        public int Year { get; set; }
    }
}
