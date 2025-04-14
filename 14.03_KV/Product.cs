using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._03_KV
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Название: {Name}, Цена: {Price:C}, Категория: {Category}, Количество: {Quantity}";
        }
    }
}
