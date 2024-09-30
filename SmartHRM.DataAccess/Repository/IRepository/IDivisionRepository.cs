using Microsoft.AspNetCore.Mvc.Rendering;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository.IRepository
{
    public interface IDivisionRepository : IRepository<Division>
    {
        void Update(Division obj);
		


	}
}
