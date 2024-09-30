using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class PaymentModeRepository : Repository<PaymentMode>, IPaymentModeRepository
    {
        private ApplicationDbContext _db;
        public PaymentModeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(PaymentMode obj)
        {
            _db.PaymentModes.Update(obj);
        }
    }
}
