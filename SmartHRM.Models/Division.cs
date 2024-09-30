using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class Division : BaseModel
    {
		public int Id { get; set; }
		[Required]
		public string DivisionName { get; set; }
		[Required]
		[Display(Name = "Company Banch")]
		public int? CompanyBranchId { get; set; }
		[ForeignKey("CompanyBranchId")]
		[ValidateNever]
		public virtual CompanyBranch CompanyBranch { get; set; }
		public string Prefix { get; set; }
		[Required]
		[DefaultValue(0)]
		public double Bonus { get; set; }
		[Required]
		[DefaultValue(0)]
		public double Savings { get; set; }
		[Required]
		[DefaultValue(0)]
		[Display(Name = "Bonus Trips")]
		public int BonusNoOfTrips { get; set; }
		[Required]
		[DefaultValue(0)]
		[Display(Name = "Bonus Tonnage")]
		public int BonusTonnageMin { get; set; }

        

    }
}
