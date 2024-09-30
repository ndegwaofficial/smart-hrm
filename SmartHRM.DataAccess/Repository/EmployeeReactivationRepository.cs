using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class EmployeeReactivationRepository : Repository<EmployeeReactivation>, IEmployeeReactivationRepository
    {
        private ApplicationDbContext _db;
        public EmployeeReactivationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(EmployeeReactivation obj)
        {
            _db.EmployeeReactivations.Update(obj);
        }
    }
}
