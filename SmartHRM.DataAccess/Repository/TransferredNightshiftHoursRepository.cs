using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class TransferredNightshiftHoursRepository : Repository<TransferredNightshiftHours>, ITransferredNightshiftHoursRepository
    {
        private ApplicationDbContext _db;
        public TransferredNightshiftHoursRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(TransferredNightshiftHours obj)
        {           
            _db.TransferredNightshiftHours.Update(obj);
        }
    }
}
