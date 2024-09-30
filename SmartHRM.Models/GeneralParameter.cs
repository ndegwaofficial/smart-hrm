using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace SmartHRM.Models
{
    public class GeneralParameter:BaseModel
    {
        [Key]
        public int Id { get; set; }
        [DisplayName("Relief Percentage(%)")]
        public int InsReliefPercent { get; set; }
		[DisplayName("Maximum")]
		public decimal InsMaximumMonthly { get; set; }
        [DisplayName("Employee %")]
        public int PensionEmployeePercent { get; set; }
		[DisplayName("Employer %")]
		public int PensionEmployerPercent { get; set; }
		[DisplayName("On Taxable Pay %")]
		public bool BasePensionOnTaxablePay { get; set; }
        public bool BaseonTaxablePay { get; set; }
		[DisplayName("Maximum")]
		public decimal MaximumPension { get; set; }
		[DisplayName("Minimum Policy Date")]
		public DateTime InsurancePolicyDate { get; set; }
		[DisplayName("Personal Relief")]
		public decimal PersonalRelief { get; set; }
		[DisplayName("Employer")]
		public decimal NSSFEmployer { get; set; }
		[DisplayName("Maximum")]
		public decimal NSSF_maximum { get; set; }
		[DisplayName("Employee")]
		public decimal NSSFEmployee { get; set; }
		[DisplayName("Section 1 Length")]
		public int EmpCodeSecOneLength { get; set; }
		[DisplayName("Section 2 Length")]
		public int EmpCodeSecTwoLength { get; set; }
		[DisplayName("Prefix")]
		public string EmpCodeSecOneString { get; set; }
		[DisplayName("Seperator")]
		public string EmpCodeSeparator { get; set; }
        [DisplayName("Main String")]
        public string empcodeMainString { get; set; }
		[DisplayName("Decimal Places")]
		public int DecimalRounding { get; set; }                
		[DisplayName("House Allowance %")]
		public int HousingPer { get; set; }
		[DisplayName("Calculate House Allowance For All Employees")]
		public bool CalculateHousing { get; set; }
		[DisplayName("Monthly working Days")]
		public double workingdays { get; set; }
        [DisplayName("Union Percentage %")]
        public decimal KUSPAW { get; set; }
		[DisplayName("Driver Savings(Shillings Per Tonne)")]
		public decimal driverSavings { get; set; }
		[DisplayName("Night Shift Rate")]
		public decimal nightShiftRate { get; set;}
		[DisplayName("Loader Savings(Shillings Per Tonne)")]
		public decimal loaderSaving { get; set; }
		[DisplayName("C.O.T.U Amount")]
		public decimal cotuPayment { get;set; }
        [DisplayName("Apply New Rule")]
        public bool newrules { get; set; }
		[DisplayName("Holiday Tonnage")]
		public int holidayTonnage { get; set; }
		[DisplayName("Housing Levy %")]
		public double HousingLevy { get; set; }
		public double HousingLevyReliefPer { get; set; }
        public double HousingLevyReliefMax { get; set; }



    }
}
