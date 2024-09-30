using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class CompSectionRepository : Repository<CompSection>, ICompSectionRepository
	{
        private ApplicationDbContext _db;
        public CompSectionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CompSection obj)
        {
            _db.CompSections.Update(obj);
        }
    }
}
