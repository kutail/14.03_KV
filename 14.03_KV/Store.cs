using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03_KV
{
    public class Store<T> : IStore<T> where T : IProduct
    {
        private readonly List<T> _products = new List<T>();

        public void Add(T product)
        {
            if (_products.Any(p => p.Id == product.Id))
            {
                throw new InvalidOperationException($"Товар с ID {product.Id} уже существует");
            }
            _products.Add(product);
        }
        public void Remove(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new InvalidOperationException($"Товар с ID {id} не найден");
            }
            _products.Remove(product);
        }
        public T GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
        public void UpdatePrice(int id, decimal newPrice)
        {
            var product = GetProductById(id);
            if (product == null)
            {
                throw new ArgumentException($"Товар с ID {id} не найден");
            }
            product.Price = newPrice;
        }
        public void UpdateQuantity(int id, int newQuantity)
        {
            var product = GetProductById(id);
            if (product == null)
            {
                throw new ArgumentException($"Товар с ID {id} не найден");
            }
            product.Quantity = newQuantity;
        }
        public List<T> GetProductsByCategory(string category)
        {
            return _products.Where(p => p.Category.Equals(category, StringComparison.OrdinalIgnoreCase)).ToList();
        }
        public Dictionary<string, List<T>> GroupByCategory()
        {
            return _products.GroupBy(p => p.Category)
                           .ToDictionary(g => g.Key, g => g.ToList());
        }
        public void PrintAllProducts()
        {
            foreach (var product in _products)
            {
                Console.WriteLine(product);
            }
        }
    }
}
