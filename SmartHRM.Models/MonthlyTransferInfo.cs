using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.Models
{
    public class MonthlyTransferInfo : BaseModel
    {
        public int Id { get; set; }
        public int PayYear { get; set; }
        public int PayPeriod { get; set; }
        public decimal NetSalary { get; set; }
        public string NetInwords { get; set; }
        public string CompanyAccountNumber { get; set;}
        public string BoxNumber { get; set;}
        public string BankName { get; set;}
        public string BranchName { get; set;}
        public string PAYEAmnt { get; set;}
        public string PAYEAmntWords { get; set;}
        public int NumberOfEmplloyees { get; set;}
        public string NumberOfEmployeesInWords { get;}

    }
}
