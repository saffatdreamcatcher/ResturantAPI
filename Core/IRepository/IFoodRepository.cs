using Core.Models;
using Core.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.IRepository
{
    public interface IFoodRepository : IRepository<Food>
    {
        void Update(Food food);
    }
}
