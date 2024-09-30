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
    public class CLoanVM
    {
        public CLoan CLoan { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> EmployeesList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> PayrollCodeList { get; set; }
		[ValidateNever]
		public IEnumerable<CLoanSchedule> CLoanSchedules { get; set; }
		[Required]
        public decimal LoanPayable { get; set; }
       
       

    }
}
