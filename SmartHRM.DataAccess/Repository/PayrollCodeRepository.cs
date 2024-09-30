using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class PayrollCodeRepository : Repository<PayrollCode>, IPayrollCodeRepository
    {
        private ApplicationDbContext _db;
        public PayrollCodeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(PayrollCode obj)
        {
            _db.PayrollCodes.Update(obj);
        }
    }
}
