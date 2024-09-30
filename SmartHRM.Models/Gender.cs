using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class Gender : BaseModel
    {
		public int Id { get; set; }
		[Required]
		[DisplayName("Gender")]
		public string GenderName { get; set; }
    }
}
