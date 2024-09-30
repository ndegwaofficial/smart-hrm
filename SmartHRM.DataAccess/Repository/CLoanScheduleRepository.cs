using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class CLoanScheduleRepository : Repository<CLoanSchedule>, ICLoanScheduleRepository
    {
        private ApplicationDbContext _db;
        public CLoanScheduleRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CLoanSchedule obj)
        {
           _db.CLoanSchedules.Update(obj);
        }
    }
}
