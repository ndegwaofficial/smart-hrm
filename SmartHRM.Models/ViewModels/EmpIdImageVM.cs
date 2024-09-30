using Microsoft.AspNetCore.Http;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMS.Models.ViewModels
{
	public class EmpIdImageVM
	{
        public Employee? employee { get; set; }
        public string FileName { get; set; }
        public IFormFileCollection PFormFile { get; set; }
	}
}
