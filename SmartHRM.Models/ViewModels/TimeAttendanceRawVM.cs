using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models.ViewModels
{
    public class TimeAttendanceRawVM
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public int ContractTypeId { get; set; }
        public double PresentDays { get; set; }
        public double AbsentDays { get; set; }
        public int Period { get; set; }
        public int Cyear { get; set; }
        public bool Posted { get; set; }


    }
}
