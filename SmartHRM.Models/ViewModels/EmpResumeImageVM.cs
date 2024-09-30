using Microsoft.AspNetCore.Http;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIMS.Models.ViewModels
{
	public class EmpResumeImageVM
	{
		
        public Employee? employee { get; set; }
		[Required]
		public string FileName { get; set; }
		[Required]
		public IFormFileCollection PFormFile { get; set; }
	}
}
