using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class EmpIdImageRepository : Repository<EmpIdImage>, IEmpIdImageRepository
	{
        private ApplicationDbContext _db;
        public EmpIdImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(EmpIdImage obj)
        {
            _db.EmpIdImages.Update(obj);
        }
    }
}
