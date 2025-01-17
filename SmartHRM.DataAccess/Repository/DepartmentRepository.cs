﻿using SmartHRM.DataAccess.Repository.IRepository;
using SmartHRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHRM.DataAccess.Repository
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
	{
        private ApplicationDbContext _db;
        public DepartmentRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Update(Department obj)
        {
            _db.Departments.Update(obj);
        }
    }
}
