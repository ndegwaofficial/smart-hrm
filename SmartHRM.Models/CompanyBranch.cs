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
	public class CompanyBranch : BaseModel
    {
		public int Id { get; set; }
		[Required]
		[Display(Name = "Branch Name")]
		public string CompanyBranchName { get; set; }
		[Display(Name = "Address")]
		public string BranchAddress { get; set; }
		public string Street { get; set; }
		public string Town { get; set; }
		[Required]
		[Display(Name = "P.I.N")]
		public string PIN { get; set; }
		public string NHIF { get; set; }
		public string NSSF { get; set; }
		public string Telephone { get; set; }
		public string Email { get; set; }
		[DisplayName("Main Company")]
		public int? CompanyId { get; set; }
		[ForeignKey("CompanyId")]
		[ValidateNever]
		public virtual Company Company { get; set; }
       

    }
}
