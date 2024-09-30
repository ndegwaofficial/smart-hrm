using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository.IRepository
{
    public interface IPayrollprocessStageRepository : IRepository<PayrollprocessStage>
    {
        void Update(PayrollprocessStage obj);

    }
}
