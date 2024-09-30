using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class OrphanedNightshiftData
    {
        public int Id { get; set; }
        public int Cmonth { get; set; }
        public int Cyear { get; set; }
        public string EmpCode { get; set; }

        [DisplayName("Employee")]
        public int EmployeeId { get; set; }

        [ValidateNever]
        public virtual Employee Employee { get; set; }
        public decimal HoursWorked { get; set; }
        public DateTime DatePosted { get; set; }
        public bool Picked { get; set; }
    }
}
