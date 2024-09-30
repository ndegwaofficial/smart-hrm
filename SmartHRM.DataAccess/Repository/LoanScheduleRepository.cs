using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class LoanScheduleRepository : Repository<LoanSchedule>, ILoanScheduleRepository
    {
        private ApplicationDbContext _db;
        public LoanScheduleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(LoanSchedule obj)
        {
           _db.LoanSchedules.Update(obj);
        }
    }
}
