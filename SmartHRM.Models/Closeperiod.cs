using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class Closeperiod : BaseModel
    {
        public string? currentMonthInWordOutPut { get; set; }
        public string? currentYearOutput { get; set; }
        public string? CurrentPeriodOutPut { get; set; }
        public string? fullcurrent_PeriodOutPut { get; set; }
        public string? currentPeriodStartDate { get; set; }
        public string? currentPeriodEndDate { get; set; }

        //Next
        public string? NextMonthInWordOutPut { get; set; }
        public string? NextYearOutput { get; set; }
        public string? NextPeriodOutPut { get; set; }
        public string? fullnext_PeriodOutPut { get; set; }
        public string? NextPeriodStartdate { get; set; }
        public string? NextPeriodEnddate { get; set; }
    }
}
