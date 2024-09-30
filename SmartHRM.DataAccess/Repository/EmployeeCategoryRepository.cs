using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class EmployeeCategoryRepository : Repository<EmployeeCategory>, IEmployeeCategoryRepository
    {
        private ApplicationDbContext _db;
        public EmployeeCategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(EmployeeCategory obj)
        {
            _db.EmployeeCategories.Update(obj);
        }
    }
}
