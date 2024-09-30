using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class ContractTypeRepository : Repository<ContractType>, IContractTypeRepository
	{
        private ApplicationDbContext _db;
        public ContractTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(ContractType obj)
        {
            _db.ContractTypes.Update(obj);
        }
    }
}
