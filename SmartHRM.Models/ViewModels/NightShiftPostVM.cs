using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models.ViewModels
{
    public class NightShiftPostVM
    {
        public int Id { get; set; }
        public int EmpId { get; set; }
        public DateTime DatePosted { get; set; }
        public decimal HoursWorked { get; set; }
        public bool Picked { get; set; }



    }
}
