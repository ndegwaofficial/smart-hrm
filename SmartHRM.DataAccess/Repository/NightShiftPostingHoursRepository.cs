using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class NightShiftPostingHoursRepository : Repository<NightshiftHoursPosting>, INightShiftHoursPostingRepository
    {
        private ApplicationDbContext _db;
        public NightShiftPostingHoursRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(NightshiftHoursPosting obj)
        {           
            _db.NightshiftHoursPostings.Update(obj);
        }
    }
}
