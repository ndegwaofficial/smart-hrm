using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
	public class PeriodicalPartProcess : BaseModel
    {
        public int Id { get; set; }
		public int EmployeeId { get; set; }
		[ForeignKey("EmployeeId")]
		[ValidateNever]
		public virtual Employee Employee { get; set; }
		public int ProcessYear { get; set; }
        public int ProcessMonth { get; set; }
        public string ItemName { get; set; }
        public decimal AmountCalc { get; set; }
        public int stage { get; set; }
    }
}
