using System;
using StorageApp.Entities;

namespace StorageApp.Repos
{
    public class ListRepository<T>
        where T : class, IEntity, new()
    {
        protected readonly List<T> _items = new();
        public IEnumerable<T> GetAll()
        {
            return _items.ToList();
        }
        public T GetById(int id)
        {
            return _items.Single(item => item.Id == id);
        }
        public void Add(T item)
        {
            item.Id = _items.Count + 1;
            _items.Add(item);
        }
        public void IncreaseAmount(int id, int amount)
        {
            var item = _items.Single(item => item.Id == id);
            item.Amount += amount;
        }
        public void DecreaseAmount(int id, int amount)
        {
            var item = _items.Single(item => item.Id == id);
            item.Amount -= amount;
        }
        public void Remove(T item)
        {
            _items.Remove(item);
        }
    }
}
