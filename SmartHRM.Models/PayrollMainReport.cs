using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class PayrollMainReport : BaseModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        [ValidateNever]
        public virtual Employee Employee { get; set; }
        public string PayrollCodeName { get; set;}
        public decimal AmountTotal { get; set; }
        public int TransPeriod { get; set; }
        public int TransYear { get; set; }
    }
}
