using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class NightshiftHoursPosting
    {
        public int Id { get; set; }
        [DisplayName("Employee")]
        public int EmployeeId { get; set; }
        public string EmpCode { get; set; }

        [ValidateNever]
        public virtual Employee Employee { get; set; }
        public decimal HoursWorked { get; set; }
        public DateTime DatePosted { get; set; }
        public bool Picked { get; set; }
    }
}
