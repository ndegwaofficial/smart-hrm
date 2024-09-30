using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class EmpNhifImageRepository : Repository<EmpNhifImage>, IEmpNhifImageRepository
	{
        private ApplicationDbContext _db;
        public EmpNhifImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(EmpNhifImage obj)
        {
            _db.EmpNhifImages.Update(obj);
        }
    }
}
