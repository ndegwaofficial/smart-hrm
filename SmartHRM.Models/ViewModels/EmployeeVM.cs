using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models.ViewModels
{
    public class EmployeeVM
    {
        public Employee Employee { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> GenderList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CurrencyList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> ContracttypeList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CategoryList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> GradeList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> CompBranchList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> DivisionList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> DepartmentList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> SectionList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> BankList { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> BankBranchList { get; set; }
        [ValidateNever]
        public IFormFile PFormFile { get; set; }
		[ValidateNever]

		public IEnumerable<EmpIdImage>? ListIdFiles { get; set; }
		public IEnumerable<EmpNssfImage>? ListNssfFiles { get; set; }
		public IEnumerable<EmpNhifImage>? ListNhifFiles { get; set; }
		public IEnumerable<EmpPinImage>? ListPinFiles { get; set; }
		public IEnumerable<EmpResume>? ListResumeFiles { get; set; }



	}
}
