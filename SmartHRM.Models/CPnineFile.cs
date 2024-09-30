using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class CPnineFile : BaseModel
    {
        public int Id { get; set; }
      
        public int EmployeeId { get; set; }
        [ForeignKey("EmployeeId")]
        [ValidateNever]
        public virtual Employee Employee { get; set; }
        public int Yearoftax { get; set; }
        public string Monthx { get; set; }
        public int MonthInt { get; set; }
        public decimal BasicSalary { get; set; }
        public decimal BenefitsNonCash { get; set; }
        public decimal ValueOfQuarters { get; set; }
        public decimal TotalGrossPay { get; set; }
        public decimal DefinedContribE1 { get; set; }
        public decimal DefinedContribE2 { get; set; }
        public decimal DefinedContribE3 { get; set; }
        public decimal OwnerOccupiedInterest { get; set; }
        public decimal TheLowerOf_E_Added_To_F { get; set; }
        public decimal ChargeablePay { get; set; }
        public decimal TaxCharged { get; set; }
        public decimal PersonalRelief { get; set; }
        public decimal InsuranceRelief { get; set; }
        public decimal TotalRelief { get; set; }
        public decimal PAYE { get; set; }

    }
}
