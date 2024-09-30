using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class EmployeeAnnualLeave : BaseModel
    {
        public int Id { get; set; }
        public int PayrollCodeId { get; set; }
        [ForeignKey("PayrollCodeId")]
        [ValidateNever]
        public virtual PayrollCode PayrollCode { get; set; }
        public int EmployeeId { get; set; }
        [ValidateNever]
        public virtual Employee Employee { get; set; }
        public int CurrentMonth { get; set; }
        public int CurrentYear { get; set; }
        public decimal LeaveAmount { get; set; }

        

    }
}
