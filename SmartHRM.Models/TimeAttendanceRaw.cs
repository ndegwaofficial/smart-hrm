using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class TimeAttendanceRaw 
    {
        public int Id { get; set; }
        public int Period { get; set; }
        public int Cyear { get; set; }
        public int EmployeeId { get; set; }
        [ValidateNever]
        public virtual Employee Employee { get; set; }
        public decimal PresentDays { get; set; }
        public decimal AbsentDays { get; set; }       
        [DefaultValue(false)]
        public bool Posted { get; set; }

       
    }
}
