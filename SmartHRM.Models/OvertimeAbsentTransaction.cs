using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class OvertimeAbsentTransaction : BaseModel
    {
        public int Id { get; set; }

        [DisplayName("Employee")]
        public int EmployeeId { get; set; }
        [ValidateNever]
        public virtual Employee Employee { get; set; }
        public int Period { get; set; }
        public int Pyear { get; set; }
        public int HoursValue { get; set; }
        public double Amount { get; set; }
        public bool opt15 { get; set; }
        public bool opt2 { get; set; }
        public int stage { get; set; }
        public DateTime Transdate { get; set; }

    }
}
