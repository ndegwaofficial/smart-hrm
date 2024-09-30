using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class EmployeesHoursDayRepository : Repository<EmployeesHoursDay>, IEmployeesHoursDayRepository
    {
        private ApplicationDbContext _db;
        public EmployeesHoursDayRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(EmployeesHoursDay obj)
        {
            _db.EmployeesHoursDays.Update(obj);
        }
    }
}
