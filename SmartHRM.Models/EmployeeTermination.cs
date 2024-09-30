using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class EmployeeTermination : BaseModel
    {
        public int Id { get; set; }
        [DisplayName("Employee")]
        public int EmployeeId { get; set; }

        [ValidateNever]
        public virtual Employee Employee { get; set; }

        [DisplayName("Termination Type")]
        public int TerminationCategoryId { get; set; }

        [ValidateNever]
        public virtual TerminationCategory TerminationCategory { get; set; }
        
        public DateTime TermDate { get; set; }
        public string Reason { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        public string InitiatedById { get; set; }
        [ForeignKey("InitiatedById")]
        [ValidateNever]
        public virtual ApplicationUser Initiator { get; set; }

        [Column(TypeName = "nvarchar(450)")]
        public string? ApprovedById { get; set; }
        [ForeignKey("ApprovedById")]
        [ValidateNever]
        public virtual ApplicationUser Approver { get; set; }
        public DateTime? ApprovalDate { get; set; }
        public string ApprovalStatus { get; set; }
        public bool Approved { get; set; }

    }
}
