using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models.ViewModels
{
	public  class EmployeeDashboardVM
	{
		public IEnumerable<Employee> Employees { get; set; }
		public double TotalEmp { get { return Employees.Count(); } }		
		public int TotalAvailable { get { return Employees.Count(emp => emp.Available); } }
		public int TotalUnavailable { get { return Employees.Count(emp => emp.Unavilable); } }
		public int TotalFemale { get { return Employees.Count(emp => emp.GenderId == 2); } }
		public int TotalMale { get { return Employees.Count(emp => emp.GenderId == 1); } }
		public int TotalAway { get { return Employees.Count(emp => emp.Away); } }
		public int TotalOnLeave { get { return Employees.Count(emp => emp.OnLeave); } }
		public double TotalCasuals { get { return Employees.Count(emp => emp.ContractTypeId == 2); } }
        public double TotalPermanent { get { return Employees.Count(emp => emp.ContractTypeId == 1); } }
        public double TotalPermanentPercent { get { return System.Math.Round(((TotalPermanent/TotalEmp) * 100),2); } }
        public double TotalCasualsPercent { get { return System.Math.Round(((TotalCasuals / TotalEmp) * 100), 2); } }


    }
}
