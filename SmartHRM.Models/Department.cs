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
	public class Department : BaseModel
    {
		public int Id { get; set; }

		[Required]
		[Display(Name = "Name")]
		public string DepartmentName { get; set; }

        [Display(Name = "Division")]
        public int? DivisionId { get; set; }
		[ForeignKey("DivisionId")]
		[ValidateNever]
		public virtual Division Division { get; set; }
        [Display(Name = "Branch")]
        public int? CompanyBranchId { get; set; }
		[ForeignKey("CompanyBranchId")]
		[ValidateNever]
		public virtual CompanyBranch CompanyBranch { get; set; }
        

    }
}
