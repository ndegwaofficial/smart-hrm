using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class Bonus : BaseModel
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        [ValidateNever]
        public virtual Employee? Employee { get; set; }
        public int CurrentYear { get; set; }
        public int CurrentMonth { get; set; }
        public decimal Amount { get; set; }
        public DateTime BonusDate { get; set; }
        public int Secondb { get; set; }
        public decimal Tonnage { get; set; }
    }
}
