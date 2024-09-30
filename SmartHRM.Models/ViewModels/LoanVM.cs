using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models.ViewModels
{
    public class LoanVM
    {
        public Loan Loan { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> EmployeesList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> PayrollCodeList { get; set; }
		[ValidateNever]
		public IEnumerable<LoanSchedule> LoanSchedules { get; set; }
		[Required]
        public decimal LoanPayable { get; set; }
       
       

    }
}
