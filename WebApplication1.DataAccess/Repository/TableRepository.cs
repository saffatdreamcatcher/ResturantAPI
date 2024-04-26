using Core.DataAccess.Repository.IRepository;
using Core.Models;
using Core.ViewModels;
using DatAccess.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Repository
{
    public class TableRepository : Repository<Table>, ITableRepository
    {
        private ApplicationDbContext _db;
        public TableRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Table table)
        {
            _db.Tables.Update(table);
        }
    }
}
