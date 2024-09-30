using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class Employee : BaseModel
    {
		[Key]
		public int Id { get; set; }
		[DisplayName("Code")]
		public string EmpCode { get; set; }
		[DisplayName("First Name")]
		public string FirstName { get; set; }
		[DisplayName("Middle Name")]
		public string? MiddleName { get; set; }
		[DisplayName("Last Name")]
		public string LastName { get; set; }
		[ValidateNever]
		public string FullName
		{
			get
			{
				return  FirstName + " " + MiddleName + " " + LastName;
			}
		}
		[ValidateNever]
		public string FullNameWithCode
		{
			get
			{
				return EmpCode + " " + FirstName + " " + MiddleName + " " + LastName;
			}
		}
        [ValidateNever]
        public string ContractTypeName
        {
            get
            {
                return ContractTypeId==1? "Permanent": "Casual";
            }
        }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
		public DateTime BirthDate { get; set; }
		public string? Designation { get; set; }
		[DisplayName("Gender")]
		public int GenderId { get; set; }
		[ValidateNever] 
		public  Gender? Gender { get; set;}

		[ValidateNever]
        public string? FileName { get; set; }
        public byte[]? Content { get; set; }

        [DisplayName("ID No")]
		public string NationalID { get; set; }
		[DisplayName("P.I.N")]
		public string KRAPin { get; set; }
		[DisplayName("NHIF No")]
		public string NHIFNo { get; set; }
		[DisplayName("NSSF No")]
		public string NSSFNo { get; set; }

		[Required]
		[DisplayName("Currency")]
		public int CurrencyId { get; set; }
		[ValidateNever]
		public virtual Currency Currency { get; set; }

		[Required]
		[DisplayName("Contract")]
		public int ContractTypeId { get; set; }
		[ValidateNever]
		//Same as EmployeeType in the old System
		public ContractType ContractType { get; set; }
		[Required]
		[DisplayName("Category")]
		public int EmployeeCategoryId { get; set; }
		[ValidateNever]
		public virtual EmployeeCategory EmployeeCategory { get; set; }
		
		[Required]
		[DisplayName("Grade")]
		public int EmployeeGradeId { get; set; }
		[ValidateNever]
		public virtual EmployeeGrade EmployeeGrade { get; set; }
		[Required]
		[DisplayName("Branch")]
		public int CompanyBranchId { get; set; }
		[ValidateNever]
		public virtual CompanyBranch CompanyBranch { get; set; }
		
		[Required]
		[DisplayName("Division")]
		public int DivisionId { get; set; }
		[ValidateNever]
		public virtual Division Division { get; set; }
		[Required]
		[DisplayName("Department")]
		public int DepartmentId { get; set; }
		[ValidateNever]
		public virtual Department Department { get; set; }

		[Required]
		[DisplayName("Section")]
		public int SectionId { get; set; }
		[ValidateNever]
		public virtual CompSection Section { get; set; }
		[DisplayName("Employed on")]
		public DateTime DateEmployed { get; set; }
		[DisplayName("Date Left")]
		public DateTime? DateLeft { get; set; }
		[DisplayName("Telephone")]
		public string? Telephone { get; set; }
		[DisplayName("Address")]
		public string? Address { get; set; }
		[Required]
		[DisplayName("Basic Pay")]
		[DisplayFormat(DataFormatString = "{0:C}", ApplyFormatInEditMode = false)]
		public double BasicPay { get; set; }
		[Required]
		[DefaultValue(0)]
		[DisplayName("Is Pensionable?")]
		public bool Pensionable { get; set; }
		[Required]
		[DisplayName("Bank")]
		public int BankID { get; set; }
		[ValidateNever]
		public virtual Bank Bank { get; set; }
		[Required]
		[DisplayName("Bank Branch")]
		public int BankBranchID { get; set;}
		[ValidateNever]
		public virtual BankBranch BankBranch { get; set; }
		[Required]
		[DisplayName("Account")]
		public string BankAccountNumber { get; set; }
		[DisplayName("Exempt PAYE?")]
		public bool ExemptPAYE { get; set; }
		[DisplayName("Exempt NHIF?")]
		public bool ExemptNHIF { get; set; }
		[DisplayName("Exempt Relief?")]
		public bool ExemptRelief { get; set; }
		[DisplayName("Exempt NSSF?")]
		public bool ExemptNSSF { get; set; }
		[DisplayName("Deduct PAYE?")]
		public bool DeductPAYE { get; set; }
		[DisplayName("Deduct NHIF?")]
		public bool DeductNHIF { get; set; }
		[DisplayName("Deduct NSSF?")]
		public bool DeductNSSF { get; set; }
		public bool OverwritePAYE { get; set; }
		public bool OverwriteNHIF { get; set; }
		public bool OverwriteNSSF { get; set; }
		public bool OverwritePension { get; set; }

		public double PAYEAmount { get; set; }
		public double NHIFAmount { get; set;}
		public double NSSFAmount { get; set; }
		public double PensionAmount { get; set;}
		[Required]
		[DefaultValue(false)]
		public bool HasHouseAllowance { get; set; }
		[DefaultValue(0)]

		public double HouseAllowance { get; set; }
		[Required]
		[DefaultValue(false)]
		public bool savings { get; set; }
		[Required]
		[DefaultValue(false)]
		public bool CotuMember { get; set; }

		//Statistics
		
		[DefaultValue (true)]
		public bool Available { get; set; }

		[DefaultValue(false)]
		public bool Unavilable { get; set; }
		[DefaultValue(false)]
		public bool Away { get; set; }
		[DefaultValue(false)]
		public bool OnLeave { get; set; }
		[DefaultValue(false)]
		public bool Terminated { get; set; }
        public int PaymentModeId { get; set; }
        [ValidateNever]
        public virtual PaymentMode PaymentMode { get; set; }
		[DefaultValue(0)]
        public bool KUSPAW { get; set; }

        


    }
}
