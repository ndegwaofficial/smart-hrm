using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class EmployeeGradeRepository : Repository<EmployeeGrade>, IEmployeeGradeRepository
	{
        private ApplicationDbContext _db;
        public EmployeeGradeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(EmployeeGrade obj)
        {
            _db.EmployeeGrades.Update(obj);
        }
    }
}
