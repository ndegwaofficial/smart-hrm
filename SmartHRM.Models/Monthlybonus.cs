using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class Monthlybonus : BaseModel
    {
        public int Id { get; set; }
        [DisplayName("Employee")]
        public int EmployeeId { get; set; }
        [ValidateNever]
        public virtual Employee Employee { get; set; }
        public int TransPeriod { get; set; }
        public int TransYear { get; set; }
        public int PayrollCodeId { get; set; }
        [ValidateNever]
        public virtual PayrollCode PayrollCode { get; set; }
        public string PaymentName { get; set; }
        public decimal PaymentAmount { get; set; }
        public bool Taxable { get; set; }
        public string Reference { get; set; }
        public decimal BalancePay { get; set; }
        public int Stage { get; set; }
        public DateTime Datefrom { get; set; }= DateTime.Now;
        public DateTime Dateto { get; set; }= DateTime.Now;
        public decimal CalcValue { get; set; }
        public decimal RateValue { get; set; }

    }
}
