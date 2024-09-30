using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class PayslipPaye : BaseModel
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
		
		public decimal RawPaye { get; set; }
		public Decimal TotalRelief { get; set; }
		public decimal TaxCharged { get; set; }
		public decimal NetSalary { get; set; }
		public decimal TaxablePay { get; set; }
		public decimal InsuranceRelief { get; set; }
		public decimal EmployeeBalance { get; set; }
        public int Stage { get; set; }
        public DateTime DateFrom { get; set; }
		public DateTime DateTo { get; set; }
	
	}
}
