using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class Nhif : BaseModel
    {
		public int Id { get; set; }
		[Required]
        [Display(Name = "From")]
        public double fromamnt { get; set; }
        [Required]
        [Display(Name = "To")]
        public double uptoamnt { get; set; }
        [Required]
		[Display(Name = "Amount")]
		public double Nhifamount { get; set; }
    }
}
