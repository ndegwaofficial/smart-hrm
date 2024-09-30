using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class BankBranchRepository : Repository<BankBranch>, IBankBranchRepository
	{
        private ApplicationDbContext _db;
        public BankBranchRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(BankBranch obj)
        {
            _db.BankBranches.Update(obj);
        }
    }
}
