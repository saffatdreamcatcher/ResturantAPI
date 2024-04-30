﻿using Core.IRepository;
using Core.Models;
using DatAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class FoodPackageRepository : Repository<FoodPackage>, IFoodPackageRepository
    {
        private ApplicationDbContext _db;
        public FoodPackageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(FoodPackage foodPackage)
        {
            _db.Update(foodPackage);
        }

        
    }
}
