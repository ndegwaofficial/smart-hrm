using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class EmpResumeImageRepository : Repository<EmpResume>, IEmpResumeImageRepository
	{
        private ApplicationDbContext _db;
        public EmpResumeImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(EmpResume obj)
        {
            _db.EmpResumes.Update(obj);
        }
    }
}
