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
	public class PayslipDeduction : BaseModel
    {
        public int Id { get; set; }
		public int EmployeeId { get; set; }
		[ForeignKey("EmployeeId")]
		[ValidateNever]
		public virtual Employee Employee { get; set; }
		[Required]
		public int TransPeriod { get; set; }
		[Required]
		public int TransYear { get; set; }
		[Required]
		public int PayrollCodeId { get; set; }
		[ForeignKey("PayrollCodeId")]
		[ValidateNever]
		public virtual PayrollCode PayrollCode { get; set; }
        public string DeductionName { get; set; }
        public decimal DeductionAmnt { get; set; }
        public bool Insurance { get; set; }
		public string Reference { get;}
		public decimal BalanceDed { get; set; }
		public decimal Employer { get; set; }
        public bool Nodelete { get; set; }
        public decimal standardamnt { get; set; }
        public decimal maximumamnt { get; set; }
        public int Stage { get; set; }
		public DateTime DateFrom { get; set; }
		public DateTime DateTo { get; set; }
		public decimal CalcValue { get; set; }
		public decimal RateValue { get; set; }




	}
}
