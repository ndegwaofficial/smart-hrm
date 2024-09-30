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
	public class AbsentTransaction : BaseModel
	{
		[Key]
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        [ValidateNever]
        public virtual Employee? Employee { get; set; }
        public int Period { get; set; }
        public int Pyear { get; set; }
        public decimal DaysValue { get; set; }
        public decimal Amount { get; set;}
        public DateTime TransDate { get; set; }
    }
}
