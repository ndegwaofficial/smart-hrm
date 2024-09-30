using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class CompanyBranchRepository : Repository<CompanyBranch>, ICompanyBranchRepository
    {
        private ApplicationDbContext _db;
        public CompanyBranchRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(CompanyBranch obj)
        {
            _db.CompanyBranches.Update(obj);
        }
    }
}
