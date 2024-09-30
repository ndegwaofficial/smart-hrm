using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class GenderRepository : Repository<Gender>,IGenderRepository
    {
        private ApplicationDbContext _db;
        public GenderRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Gender obj)
        {
            _db.Genders.Update(obj);
        }
    }
}
