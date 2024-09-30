﻿using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository.IRepository
{
    public interface ICompSectionRepository : IRepository<CompSection>
    {
        void Update(CompSection obj);


    }
}