using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class TerminantionCategoryRepository : Repository<TerminationCategory>, ITerminantionCategoryRepository
    {
        private ApplicationDbContext _db;
        public TerminantionCategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(TerminationCategory obj)
        {
            _db.TerminationCategories.Update(obj);
        }
    }
}
