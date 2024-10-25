﻿using Microsoft.EntityFrameworkCore;
using StorageApp.Entities;

namespace StorageApp.Repos
{
    public class SqlRepository<T> : IRepository<T> where T : class, IEntity, new()
    {
        private readonly DbSet<T> _dbSet;
        private readonly DbContext _dbContext;

        public SqlRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }
        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }
        public T GetById(int id)
        {
            return _dbSet.Find(id);
        }
        public void Update (T entity)
        {
            _dbSet.Update(entity);
        }
        //public void IncreaseAmount(int id, int amount)
        //{
        //    var item = _dbSet.Find(id);
        //    item.Amount += amount;
        //}
        //public void DecreaseAmount(int id, int amount)
        //{
        //    var item = _dbSet.Find(id);
        //    item.Amount -= amount;
        //}
        public void Add(T item)
        {
            _dbSet.Add(item);
        }
        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }
        public void Save()
        {
            _dbContext.SaveChanges();
        }
    }
}
