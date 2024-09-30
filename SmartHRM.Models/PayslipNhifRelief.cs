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
	public class PayslipNhifRelief : BaseModel
    {
        public int Id { get; set; }
       	public int EmployeeId { get; set; }
		[ForeignKey("EmployeeId")]
		[ValidateNever]
		public virtual Employee Employee { get; set; }
		[Required]
		public int PayPeriod { get; set; }
		[Required]
		public int PayYear { get; set; }
        public decimal ReliefAmount { get; set; }
        public decimal PortionToTax { get; set; }
        public decimal PortionToExempt { get; set; }
        public string? NhifReliefName { get; set; }


    }
}
