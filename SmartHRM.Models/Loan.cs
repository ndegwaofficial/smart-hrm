using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class Loan : BaseModel
    {
		[Key]
        public int Id { get; set; }
        [DisplayName("Employee")]
        public int EmployeeId { get; set; }
        [ValidateNever]
        public virtual Employee Employee { get; set; }
        [DisplayName("Loan Issuerer")]
        public int PayrollCodeId { get; set; }
        [ValidateNever]
        public virtual PayrollCode PayrollCode { get; set; }

        [DisplayName("Loan Purpose")]
        [MaxLength(150)]
        public string LoanDesc { get; set; }
        [DisplayName("Trans Date")]
        public DateTime LoanTransDate { get; set; } = DateTime.Today;
        [DisplayName("Start Period")]
        [MaxLength(10)]
		public string LoanStartPeriod { get; set; }
		[MaxLength(10)]
        [DisplayName("End Period")]
        public string LoanEndPeriod { get; set; }
        [DisplayName("None")]
        public bool NoInterest { get; set; }
        [DisplayName("Reducing")]
        public bool Reducing { get; set; }
        [DisplayName("Fixed")]
        public bool Fixed { get; set; }
		[Column(TypeName="decimal(18,2)")]
        [DisplayName("Int.Rate % ")]
        public decimal InterestRate { get; set; }
		[Column(TypeName = "decimal(18,2)")]
        [DisplayName("Loan Amount")]
        public decimal LoanAmount { get; set; }
		[Column(TypeName = "decimal(18,2)")]
        [DisplayName("Monthly Recovery")]
        public decimal MonthlyRecoveryAmnt { get; set; }
        public int RND { get; set; }
        [DisplayName("Number of Instalments")]
        public int NumberOfPeriods { get; set; }
        [MaxLength(100)]
        [DisplayName("Currency"), DefaultValue("KES")]
        [ValidateNever]
        public string CurrencyName { get; set; }
        [ValidateNever]
        [DefaultValue(false)]
        [DisplayName("Use Monthly Recovery to calculate Duration")]
        public bool UseMonthlyRecov { get; set; }
        public bool Cleared { get; set; }

    }
}
