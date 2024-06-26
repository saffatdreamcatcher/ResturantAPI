﻿using Core.Repository.IRepository;
using DatAccess.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;



namespace DataAccess.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext _db;
        internal DbSet<T> dbSet;
        public Repository(ApplicationDbContext db)
        {
            _db = db;
            this.dbSet = _db.Set<T>();
            //_db.Employees == dbSet

        }
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }
        public void AddRange(IEnumerable<T> entities)
        {
            dbSet.AddRange(entities);
        }

        public T? Find(int Id)
        {
            return dbSet.Find(Id);
        }

        public T? Find(Guid Id)
        {
            return dbSet.Find(Id);
        }


        public List<T> Get(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = dbSet;
            query = query.Where(filter);
            return query.ToList();
        }

        

        public IEnumerable<T> GetAll()
        {
            IQueryable<T> query = dbSet;
            return query.ToList();
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }

       
    }
}
