using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartHRM.Models
{
	public class CPayslipMain : BaseModel
    {
       

		[Key]
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		[ForeignKey("EmployeeId")]
		[ValidateNever]
		public virtual Employee Employee { get; set; }
		[DisplayName("Code")]
		public string EmpCode { get; set; }

        public int PayPeriod { get; set; }
        public int PayYear { get; set; }

        public string? EmployeeName { get; set; }
		[DisplayName("ID No")]
		public string NationalID { get; set; }
        public string Currency { get; set; }
        public string Grade { get; set; }
        public string Department { get; set; }
        public DateTime BirthDate { get; set; }
		public string Designation { get; set;}
		public string PIN { get; set;}
		public string PayeNo { get; set;}
        public string NhifNo { get; set; }
        public string NssfNo { get; set; }
        public string Gender { get; set; }
		public decimal BasicPay { get; set;}
        public decimal PersonalRelief { get; set; }
		public int PaymentModeId { get; set;}
        [ForeignKey("PaymentModeId")]
        [ValidateNever]
        public virtual PaymentMode PaymentMode { get; set; }
        public int BankID { get; set;}
		public string BankName { get; set;}
		public int BankBranchID { get; set; }
		public string BankBranchName { get;set;}
		public string BankAccountNumber { get; set; }
		public string DispPeriod { get; set; }
		public int CompBranch { get; set; }
        public decimal BasicBalanceToDate { get; set; }
		public int DepartmentId { get; set; }
        public decimal HoursDays { get; set; }
		public string section { get; set; }
		public string ContractType { get; set; }
		public string EmployeeCategory { get; set; }
		public int SectionId { get; set; }
		public int DivisionId { get; set; }
        public Decimal HouseAllowance { get; set; }
        public int Stage { get; set; }
        public DateTime DateEmployed { get; set; }
		public bool Savings { get; set; }
        public decimal Tonnage { get; set; }


    }
}
