using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class Paye : BaseModel
    {
		public int Id { get; set; }
		[Required]
        [Display(Name = "Lower Limit")]
        public decimal LowerLimit { get; set; }

		[Required]
		[Display(Name = "Upper Limit")]
		public decimal UpperLimit { get; set; }
		[Required]
		[Display(Name ="Rate(%)")]
		public double Rate { get; set; }
	}
}
