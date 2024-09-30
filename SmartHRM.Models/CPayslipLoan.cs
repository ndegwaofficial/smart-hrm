using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SmartHRM.Models
{
	public class CPayslipLoan : BaseModel
    {
		[Key]
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		[ForeignKey("EmployeeId")]
		[ValidateNever]
		public virtual Employee Employee { get; set; }
		public int TransPeriod { get; set; }
		public int TransYear { get; set; }
		public int PayrollCodeId { get; set; }
		[ForeignKey("PayrollCodeId")]
		[ValidateNever]
		public virtual PayrollCode PayrollCode { get; set; }
		[MaxLength(200)]
		public string? LoanName { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal LoantMonthlyPrincipal { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal LoanInterest { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal LoanBalance { get; set; }
		[MaxLength(10)]
		public string Periodx { get; set; }
		public int LoanNo { get; set; }
        public int Stage { get; set; }
    }
}
