using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class PayeRepository : Repository<Paye>, IPayeRepository
	{
        private ApplicationDbContext _db;
        public PayeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Paye obj)
        {
            _db.Payes.Update(obj);
        }
    }
}
