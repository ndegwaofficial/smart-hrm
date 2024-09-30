using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class NhifRepository : Repository<Nhif>, INhifRepository
	{
        private ApplicationDbContext _db;
        public NhifRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Nhif obj)
        {
            _db.Nhifs.Update(obj);
        }
    }
}
