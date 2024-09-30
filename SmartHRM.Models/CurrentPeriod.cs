using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class CurrentPeriod : BaseModel
    {
        public int Id { get; set; }
        public int CurrentMonth { get; set; }
        public string PeriodWord { get; set; }
        public int Year { get; set; }
        public int Stage { get; set; }
    }
}
