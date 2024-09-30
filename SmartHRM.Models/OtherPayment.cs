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
	public class OtherPayment
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
        public string? PaymentName { get; set; }
        public Decimal PaymentAmount { get; set; }
        public bool Taxable { get; set; }
        public string? Reference { get; set; }
		public decimal BalancePay { get; set; }
		public int Stage { get; set; }
		public DateTime DateFrom { get; set; }
		public DateTime DateTo { get; set; }
      




    }
}
