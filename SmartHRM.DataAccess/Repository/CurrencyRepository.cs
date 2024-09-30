using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class CurrencyRepository : Repository<Currency>, ICurrencyRepository
	{
        private ApplicationDbContext _db;
        public CurrencyRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Currency obj)
        {
            _db.Currencies.Update(obj);
        }
    }
}
