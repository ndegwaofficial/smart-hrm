using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class EmpResume:BaseModel
	{
		public int Id { get; set; }
		public int EmployeeId { get; set; }
		[ValidateNever]
		public Employee? Employee { get; set; }
		public string? FileName { get; set; }
		public byte[]? Content { get; set; }
	}
}
