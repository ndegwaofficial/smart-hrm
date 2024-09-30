using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class Nssf : BaseModel
    {
		public int Id { get; set; }
		[Required]
        [Display(Name = "National Avg Earning")]
        public double national_avg_earning { get; set; }
        [Required]
        [Display(Name = "% Upper Earning Limit")]
        public double upper_earning_limit_per { get; set; }
        [Required]
		[Display(Name = "Upper Earning Limit Amnt")]
		public double upper_earning_limit_amnt { get; set; }

        [Required]
        [Display(Name = "Lower Earning Limit Amnt")]
        public double lower_earning_limit_amnt { get; set; }

        [Required]
        [Display(Name = "Employee %")]
        public double employee_percent { get; set; }

        [Required]
        [Display(Name = "Employer %")]
        public double employer_percent { get; set; }
    }
}
