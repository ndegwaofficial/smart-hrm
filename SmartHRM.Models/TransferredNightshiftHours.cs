using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public  class TransferredNightshiftHours
    {
        public int Id { get; set; }
        public int Cmonth { get; set; }
        public int Cyear { get; set; }
        [DisplayName("Employee")]
        public int EmployeeId { get; set; }        

        [ValidateNever]
        public virtual Employee Employee { get; set; }
        public decimal HoursWorked { get; set; }
        public string Description { get; set; }
        public DateTime TransDate { get; set; }
        public Decimal Amount { get; set; }
    }
}
