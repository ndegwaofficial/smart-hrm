using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class EmployeeCategory : BaseModel
    {
		[Key]
		public int Id { get; set; }

		[Required]
        [Display(Name = "Category")]
        public string CategoryName { get; set; }
        
    }
}
