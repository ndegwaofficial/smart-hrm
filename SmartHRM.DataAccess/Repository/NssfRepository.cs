using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class NssfRepository : Repository<Nssf>, INssfRepository
	{
        private ApplicationDbContext _db;
        public NssfRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Nssf obj)
        {
            _db.Nssfs.Update(obj);
        }
    }
}
