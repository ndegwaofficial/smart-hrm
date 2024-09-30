﻿using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models.ViewModels
{
    public class DepartmentVM
    {
        public Department Department { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> DivisionList { get; set; }
		[ValidateNever]
		public IEnumerable<SelectListItem> CompanyBranchList { get; set; }

    }
}
