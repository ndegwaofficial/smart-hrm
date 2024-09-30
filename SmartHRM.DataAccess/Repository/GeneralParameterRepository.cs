using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class GeneralParameterRepository : Repository<GeneralParameter>, IGeneralParameterRepository
    {
        private ApplicationDbContext _db;
        public GeneralParameterRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(GeneralParameter obj)
        {
            _db.GeneralParameters.Update(obj);
        }
    }
}
