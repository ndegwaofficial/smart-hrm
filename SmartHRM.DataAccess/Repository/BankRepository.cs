using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class BankRepository : Repository<Bank>, IBankRepository
	{
        private ApplicationDbContext _db;
        public BankRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Bank obj)
        {
            _db.Banks.Update(obj);
        }
    }
}
