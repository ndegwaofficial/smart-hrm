using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository.IRepository
{
    public interface ITransferredNightshiftHoursRepository : IRepository<TransferredNightshiftHours>
    {
        void Update(TransferredNightshiftHours obj);
    }
}
