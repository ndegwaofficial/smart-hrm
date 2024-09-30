using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models.ViewModels
{
    public class SectionVM
    {
        public CompSection CompSection { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> DivisionList { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> DepartmentList { get; set; }

    }
}
