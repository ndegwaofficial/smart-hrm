using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class PaySlipPension : BaseModel
    {
        public int Id { get; set; }
       	public int EmployeeId { get; set; }
		[ForeignKey("EmployeeId")]
		[ValidateNever]
		public virtual Employee Employee { get; set; }
        public int PayYear { get; set; }
        public int PayPeriod { get; set; }
        public decimal EmployeePension { get; set; }
        public decimal EmployerPension { get; set; }
        public decimal TaxablePortion { get; set; }
        public decimal PortionExempted { get; set; }
        public float EmployeePensionPercent { get; set; }
        public float EmployerPensionPercent { get; set; }


    }
}
