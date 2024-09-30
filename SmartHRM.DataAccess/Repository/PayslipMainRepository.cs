using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class PayslipMainRepository : Repository<PayslipMain>, IPayslipMainRepository
    {
        private ApplicationDbContext _db;
        public PayslipMainRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(PayslipMain obj)
        {
            _db.PayslipMains.Update(obj);
        }
    }
}
