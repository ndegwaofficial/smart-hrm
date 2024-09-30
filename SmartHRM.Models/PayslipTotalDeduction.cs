using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class PayslipTotalDeduction : BaseModel
    {
        public int Id { get; set; }
		public int EmployeeId { get; set; }
		[ForeignKey("EmployeeId")]
		[ValidateNever]
		public virtual Employee Employee { get; set; }
		public int PayPeriod { get; set; }
        public int PayYear { get; set; }
        public decimal TotalDeductions { get; set; }
		public int Stage { get; set; }
		public DateTime DateFrom { get; set; }
		public DateTime DateTo { get; set; }
	}
}
