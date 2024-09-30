using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace SmartHRM.Models
{
    public class EmployeesHoursDay : BaseModel
    {
        public int Id { get; set; }
        [Required]
        public int  Cmonth { get; set; }
        [Required]
        public int Cyear { get; set; }
        [DisplayName("Employee")]
        public int EmployeeId { get; set; }
        
        [ValidateNever]
        public virtual Employee Employee { get; set; }

        [DisplayName("Days Worked")]
        public decimal Hoursdays { get; set; }
        public string? Description { get; set; }
        public DateTime Transdate { get; set; }

        [DisplayName("Amount")]
        public decimal? Amount { get; set; }
        public int Stage { get; set; }
        public int? Ref_id { get; set; }
        public DateTime? Ref_date { get; set; }
        public int Tonnage { get; set; }
        public int Days { get; set; }

    }
}
