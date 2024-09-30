using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class EmpPinImageRepository : Repository<EmpPinImage>, IEmpPinImageRepository
	{
        private ApplicationDbContext _db;
        public EmpPinImageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(EmpPinImage obj)
        {
            _db.EmpPinImages.Update(obj);
        }
    }
}
