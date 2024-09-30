using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        private ApplicationDbContext _db;
        public EmployeeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Employee obj)
        {
            var objFromDb = _db.Employees.FirstOrDefault(u => u.Id == obj.Id);
            if(objFromDb != null)
            {
                objFromDb.FirstName = obj.FirstName;
                objFromDb.MiddleName = obj.MiddleName;
                objFromDb.LastName = obj.LastName;
                objFromDb.NationalID = obj.NationalID;
                objFromDb.KRAPin = obj.KRAPin;
                objFromDb.Designation = obj.Designation;
                objFromDb.EmployeeCategoryId = obj.EmployeeCategoryId;
                objFromDb.CompanyBranchId = obj.CompanyBranchId;
                objFromDb.DivisionId = obj.DivisionId;
                objFromDb.DepartmentId = obj.DepartmentId;
                objFromDb.SectionId= obj.SectionId;
                objFromDb.DateEmployed = obj.DateEmployed;
                objFromDb.DateLeft = obj.DateLeft;
                objFromDb.DateLeft = obj.DateLeft;
                objFromDb.Telephone = obj.Telephone;
                objFromDb.Address = obj.Address;
                objFromDb.BasicPay = obj.BasicPay;
                objFromDb.Pensionable = obj.Pensionable;
                objFromDb.BankID = obj.BankID;
                objFromDb.BankBranchID= obj.BankBranchID;
                objFromDb.BankAccountNumber = obj.BankAccountNumber;
                objFromDb.ExemptPAYE = obj.ExemptPAYE;
                objFromDb.ExemptNHIF = obj.ExemptNHIF;
                objFromDb.ExemptRelief = obj.ExemptRelief;
                objFromDb.ExemptNSSF = obj.ExemptNSSF;
                objFromDb.DeductPAYE = obj.DeductPAYE;
                objFromDb.DeductNHIF = obj.DeductNHIF;
                objFromDb.DeductNSSF = obj.DeductNSSF;
                objFromDb.OverwritePAYE = obj.OverwritePAYE;
                objFromDb.OverwriteNHIF = obj.OverwriteNHIF;
                objFromDb.OverwriteNSSF = obj.OverwriteNSSF;
                objFromDb.OverwritePension = obj.OverwritePension;
                objFromDb.PAYEAmount = obj.PAYEAmount;
                objFromDb.NHIFAmount = obj.NHIFAmount;
                objFromDb.NSSFAmount = obj.NSSFAmount;
                objFromDb.PensionAmount = obj.PensionAmount;
                objFromDb.HasHouseAllowance = obj.HasHouseAllowance;
                objFromDb.HouseAllowance = obj.HouseAllowance;
                objFromDb.savings = obj.savings;
                objFromDb.CotuMember = obj.CotuMember;
                objFromDb.Content = obj.Content;
                objFromDb.FileName = obj.FileName;                
            }
            //_db.Products.Update(obj);
        }
    }
}
