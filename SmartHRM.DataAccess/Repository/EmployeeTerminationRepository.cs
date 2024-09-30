using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class EmployeeTerminationRepository : Repository<EmployeeTermination>, IEmployeeTerminationRepository
    {
        private ApplicationDbContext _db;
        public EmployeeTerminationRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(EmployeeTermination obj)
        {
            _db.EmployeeTerminations.Update(obj);
        }
    }
}
