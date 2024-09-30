using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class EmpNssfImageRepository : Repository<EmpNssfImage>, IEmpNssfImageRepository
	{
        private ApplicationDbContext _db;
        public EmpNssfImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(EmpNssfImage obj)
        {
            _db.EmpNssfImages.Update(obj);
        }
    }
}
