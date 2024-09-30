using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class TimeAttendanceRawRepository : Repository<TimeAttendanceRaw>, ITimeAttendanceRawRepository
    {
        private ApplicationDbContext _db;
        public TimeAttendanceRawRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(TimeAttendanceRaw obj)
        {           
            _db.TimeAttendanceRaws.Update(obj);
        }
    }
}
