using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class TonnagePosting
    {
        public int Id { get; set; }
        public string CcfleetNo { get; set; }
        public string Empcode { get; set; }
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        [ValidateNever]
        public virtual Employee Employee { get; set; }
        public decimal Tonnage { get; set; }
        public DateTime PostDate { get; set; }
        public bool Picked { get; set; }
    }
}
