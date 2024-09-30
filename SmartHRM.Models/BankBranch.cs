using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartHRM.Models
{
	public class BankBranch : BaseModel
    {
		public int Id { get; set; }
		[Required]
		[Display(Name = "Branch Name")]
		public string BankBranchName { get; set; }

        [Display(Name = "Brank")]
        [Required]
		public int BankId { get; set; }
		[ForeignKey("BankId")]
		[ValidateNever]
		public virtual Bank Bank { get; set; }
       

    }
}
