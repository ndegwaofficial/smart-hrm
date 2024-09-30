using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models.ViewModels
{
    public class EmployeeTerminationVM
    {
        public EmployeeTermination EmployeeTermination { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> Employeelist { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> TerminationCategoryList { get; set; }
       


    }
}
