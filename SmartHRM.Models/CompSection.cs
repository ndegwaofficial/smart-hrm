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
	public class CompSection : BaseModel
    {
		public int Id { get; set; }
		[Required]
		public string SectionName { get; set; }
		public int? DivisionId { get; set; }
		[ForeignKey("DivisionId")]
		[ValidateNever]
		public virtual Division Division { get; set; }

		public int? DepartmentId { get; set; }
		[ForeignKey("DepartmentId")]
		[ValidateNever]
		public virtual Department Department { get; set; }
       

    }
}
