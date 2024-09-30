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
	public class Payslipnoncash : BaseModel
    {
		[Key]
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		[ForeignKey("EmployeeId")]
		[ValidateNever]
		public virtual Employee Employee { get; set; }
		[MaxLength(2)]
		public int TransPeriod { get; set; }
		[MaxLength(4)]
		public int TransYear { get; set; }
		public int PayrollCodeId { get; set; }
		[ForeignKey("PayrollCodeId")]
		[ValidateNever]
		public virtual PayrollCode PayrollCode { get; set; }
		[MaxLength(200)]
		public string PaymentName { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal PaymentAmount { get; set; }
		public bool Taxable { get; set; }
		[MaxLength(50)]
		public string Reference { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal BalancePay { get; set; }
		public int stage { get; set; }
		public DateTime datefrom { get; set; }
		public DateTime dateto { get; set; }
	}
}
