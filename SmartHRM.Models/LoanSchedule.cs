using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class LoanSchedule : BaseModel
    {
		[Key]
        public int Id { get; set; }
        public int LoanId { get; set; }
        public virtual Loan Loan { get; set; }
        public int PaymentNumber { get; set; }
		[Column(TypeName="decimal(18,2)")]
        public decimal Icharge { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal Balance { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal BalanceBF { get; set; }
        public DateTime DueDate { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal MonthlyRecov { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal TotalDeduction { get; set; }
		[MaxLength(10)]
        public string Period { get; set; }
      
		[Column(TypeName = "decimal(18,2)")]
		public decimal CummulativeInterest { get; set; }
        public bool Paid { get; set; }
       
	}
}
