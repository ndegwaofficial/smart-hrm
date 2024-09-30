using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SmartHRM.Models
{
    public class PayrollCode : BaseModel
    {
        public int Id { get; set; }
        public string Code { get; set; }
        [Required]
        [DisplayName("Payroll Code")]

		[ValidateNever]
		public char paycodeType
		{
			get
			{
				return Deduction==true?'D':'P';
			}
		}
		public string PayName { get; set; }
        public double Limit { get; set; }
        [DisplayName("Rounding")]
        public double RoundIn { get; set; }
        public bool Taxable { get; set; }
        public bool Loan { get; set; }
        public bool Amount { get; set; }
        [DisplayName("Non-Taxable")]
        public bool NonTaxable { get; set; }
        public bool Variable { get; set; }
        public bool Payment { get; set; }
        public bool Deduction { get; set; }
        public bool Fixed { get; set; }
        public bool Statement { get; set; }
        [DisplayName("Insurance Policy?")]
        public bool Insurance { get; set; }
        [DisplayName("Recurring Monthly?")]
        public bool Recurring { get; set; }
        [DisplayName("Non-Cash Benefits?")]
        public bool NonCashBenefit { get; set; }
        [DisplayName("Don't use in NSSF Calculations?")]
        public bool Nssf_inc { get; set; }
        [DisplayName("Don't use in NHIF Calculations?")]
        public bool Nhif_inc { get; set; }
        public bool Active { get; set; }
    }
}
