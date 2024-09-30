using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models.ViewModels
{
    public class ProcessCasualVM
	{
        public int CompanyBranchId { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CompanyBranchList { get; set; }
       
        public int DivisionId { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> DivisionList { get; set; }
        
        public int DepartmentId { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> DepartmentList { get; set; }

		public int SectionId { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> SectionList { get; set; }

		public int EmployeeId { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> EmployeeList { get; set; }

        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
    }
}
