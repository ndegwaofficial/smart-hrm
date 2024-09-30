using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class OvertimeHoursImport
    {
        public int Id { get; set; }
       
        [DisplayName("Employee")]
        public int EmployeeId { get; set; }
        [ValidateNever]
        public virtual Employee Employee { get; set; }       
        public decimal Hoursworked { get; set; }
        public int OvertimeTypeId { get; set; }
        public DateTime TransDate { get; set; }
        public bool Picked { get; set; }


    }
}
