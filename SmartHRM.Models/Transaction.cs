using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.Globalization;

namespace SmartHRM.Models
{
	public class Transaction : BaseModel
    {
		[Key]
		public int Id { get; set; }
		public int CurrentMonth { get; set; }
		public int CurrentYear { get; set; }

		[DisplayName("Employee")]
		public int EmployeeId { get; set; }
		[ForeignKey("EmployeeId")]
		[ValidateNever]
		public virtual Employee Employee { get; set; }
		[DisplayName("Payroll Code")]
		public int PayrollCodeId { get; set; }
		[ForeignKey("PayrollCodeId")]
		[ValidateNever]
		public virtual PayrollCode PayrollCode { get; set; }
		public int Period { get; set; }
		[DisplayFormat(DataFormatString = "{0:dd/MM/yyy}")]
		public DateTime EffectiveFromPeriod { get; set; }
		[ValidateNever]
		public string StartPeriod
		{
			get
			{
				return EffectiveFromPeriod.Month.ToString();
			}
		}
		[ValidateNever]
		public string DispTransAmount
		{
			get
			{
				return TransAmount.ToString("C", CultureInfo.CurrentCulture);
			}
		}
		public int TransYear { get; set; }
		public int TransFixed { get; set; }
			
		[MaxLength(50)]
		public string? TransRef { get; set; }
		public DateTime TransDate { get; set; }
		[MaxLength(200)]
		public string? TransDescription { get; set; }
		[Column(TypeName = "decimal(18,2)")]
		public decimal TransAmount { get; set; }
		[MaxLength(20)]
		public string? CreatedBy { get; set; }
		[MaxLength(20)]
		public string? ApprovedBy { get; set; }
		public bool Approved { get; set; }
		public DateTime ApprovedOn { get; set; }
		[MaxLength(50)]
		public string? Reference { get; set; }
		public bool Stopped { get; set; }
		public int stage { get; set; }
		public bool rejected { get; set; }
	}
}
