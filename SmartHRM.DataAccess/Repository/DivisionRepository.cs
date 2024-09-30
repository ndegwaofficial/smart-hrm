using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class DivisionRepository : Repository<Division>, IDivisionRepository
	{
        private ApplicationDbContext _db;
        public DivisionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Division obj)
        {
            _db.Divisions.Update(obj);
        }
    }
}
