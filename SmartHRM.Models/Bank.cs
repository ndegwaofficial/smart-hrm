using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class Bank : BaseModel
    {
		public int Id { get; set; }
		[Required]
		[Display(Name = "Bank")]
		public string BankName { get; set; }
       
    }
}
