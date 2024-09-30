using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models.ViewModels
{
	public class TransactionsROVM
	{
		public int EmpolyeeId { get; set; }
        public int SelectedId { get; set; }
        [ValidateNever]
		public IEnumerable<SelectListItem> EmployeeList { get; set; }
	}
}
