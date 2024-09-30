using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class OvertimeAbsentTransactionRepository : Repository<OvertimeAbsentTransaction>, IOvertimeAbsentTransactionRepository
    {
        private ApplicationDbContext _db;
        public OvertimeAbsentTransactionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(OvertimeAbsentTransaction obj)
        {           
            _db.OvertimeAbsentTransactions.Update(obj);
        }
    }
}
