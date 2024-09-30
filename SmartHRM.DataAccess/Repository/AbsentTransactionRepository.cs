using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class AbsentTransactionRepository : Repository<AbsentTransaction>, IAbsentTransactionRepository
	{
        private ApplicationDbContext _db;
        public AbsentTransactionRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(AbsentTransaction obj)
        {           
            _db.AbsentTransactions.Update(obj);
        }
    }
}
