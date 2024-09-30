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
    public class CLoanRepository : Repository<CLoan>, ICLoanRepository
    {
        private ApplicationDbContext _db;
        public CLoanRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CLoan obj)
        {
            var objFromDb = _db.CLoans.FirstOrDefault(u => u.Id == obj.Id);
           // _db.Entry(obj).State = EntityState.Modified;
            _db.CLoans.Update(obj);
        }
    }
}
