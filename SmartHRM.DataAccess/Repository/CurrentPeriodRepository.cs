using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class CurrentPeriodRepository : Repository<CurrentPeriod>, ICurrentPeriodRepository
    {
        private ApplicationDbContext _db;
        public CurrentPeriodRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CurrentPeriod obj)
        {
            _db.CurrentPeriods.Update(obj);
        }
    }
}
