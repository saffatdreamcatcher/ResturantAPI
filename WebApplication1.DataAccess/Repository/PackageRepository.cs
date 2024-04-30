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
    public class PackageRepository : Repository<Package>, IPackageRepository
    {
        private ApplicationDbContext _db;
        public PackageRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(Package package)
        {
            _db.Update(package);
        }

        
    }
}
