using System;
using System.Collections.Generic;
using System.Text;
// Все виды товаров
namespace Storage
{
    class Product
    {
        protected string name { get; set; }
        protected string manufacturer { get; set; }
        protected float price { get; set; }
        protected float count { get; set; }

        protected Product(string name, string manufacturer, float price, float count)
        {
            this.name = name;
            this.manufacturer = manufacturer;
            this.price = price;
            this.count = count;
        }

        public virtual void Info() { }

        public virtual void GetName()
        {
            Console.WriteLine(name + ".");
        }

        public virtual float SpentMoney()
        {
            if (count == 0) return 1000000 * price;
            return price;
        }
    }

    class Condom : Product
    {
        protected int size { get; set; }

        public Condom(string name, string manufacturer, float price, float count, int size) : base(name, manufacturer, price, count)
        {
            this.size = size;
        }

        public override void Info()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Производитель: " + manufacturer);
            Console.WriteLine("Цена: " + price);
            Console.WriteLine("Наличие на складе: " + count);
            Console.WriteLine("Размер: " + size);
        }
    }

    class Lubricant : Product
    {
        protected string material { get; set; }
        protected float capacity { get; set; }

        public Lubricant(string name, string manufacturer, float price, float count, string material, float capacity) : base(name, manufacturer, price, count)
        {
            this.material = material;
            this.capacity = capacity;
        }

        public override void Info()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Производитель: " + manufacturer);
            Console.WriteLine("Цена: " + price);
            Console.WriteLine("Наличие на складе: " + count);
            Console.WriteLine("Материал: " + material);
            Console.WriteLine("Объем: " + capacity);
        }
    }

    class Сlothing : Product
    {
        protected int size { get; set; }

        public Сlothing(string name, string manufacturer, float price, float count, int size) : base(name, manufacturer, price, count)
        {
            this.size = size;
        }

        public override void Info()
        {
            Console.WriteLine("Название: " + name);
            Console.WriteLine("Производитель: " + manufacturer);
            Console.WriteLine("Цена: " + price);
            Console.WriteLine("Наличие на складе: " + count);
            Console.WriteLine("Размер: " + size);
        }
    }
}
