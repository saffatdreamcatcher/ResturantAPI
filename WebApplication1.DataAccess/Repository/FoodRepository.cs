using Core.IRepository;
using Core.Models;
using DatAccess.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class FoodRepository : Repository<Food>, IFoodRepository
    {
        private ApplicationDbContext _db;
        public FoodRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Food food)
        {
            _db.Update(food);
        }
    }
}
