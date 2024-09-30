using Microsoft.EntityFrameworkCore;
using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class LoanRepository : Repository<Loan>, ILoanRepository
    {
        private ApplicationDbContext _db;
        public LoanRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Loan obj)
        {
            var objFromDb = _db.Loans.FirstOrDefault(u => u.Id == obj.Id);
           // _db.Entry(obj).State = EntityState.Modified;
            _db.Loans.Update(obj);
        }
    }
}
