using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class PayrollprocessStageRepository : Repository<PayrollprocessStage>, IPayrollprocessStageRepository
    {
        private ApplicationDbContext _db;
        public PayrollprocessStageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(PayrollprocessStage obj)
        {
            _db.PayrollprocessStages.Update(obj);
        }
    }
}
