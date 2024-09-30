using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class PaySlipHousingLevy : BaseModel
    {
        public int Id { get; set; }
		public int EmployeeId { get; set; }
		[ForeignKey("EmployeeId")]
		[ValidateNever]
		public virtual Employee Employee { get; set; }
		[Required]
		public int PayPeriod { get; set; }

		[Required]
		public int Stage { get; set; }
		[Required]
		public int PayYear { get; set; }
        public decimal EmployeeHousingLevy { get; set; }
		public decimal EmployerHousingLevy { get; set; }
        public decimal TaxablePortion { get; set; }
        public decimal PortionExempted { get; set; }
        public decimal EmployeeHLevyPercent { get; set; }
        public decimal EmployerHLevyPercent { get; set; }
        public decimal EmployeeBalance { get; set; }

    }
}
