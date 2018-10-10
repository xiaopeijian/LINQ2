using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOverCustomObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Car> myCars = new List<Car>()
            {
                new Car { PetName = "Car1", Color = "Color1", Speed = 100, Make ="Make1" },
                new Car { PetName = "Car2", Color = "Color2", Speed = 90, Make ="Make2" },
                new Car { PetName = "Car3", Color = "Color3", Speed = 55, Make ="Make3" },
                new Car { PetName = "Car4", Color = "Color4", Speed = 5, Make ="Make4" },
                new Car { PetName = "Car5", Color = "Color5", Speed = 43, Make ="Make5" },
            };
            GetFastCars(myCars);
            Console.WriteLine();

            Console.WriteLine("------------------------------------分界线-------------------------------------");
            ProductInfo[] itemInStock = new[] {
                new ProductInfo { Name = "Mac's Coffee1", Description = "Coffee with teeth1", NumberInstock = 24},
                new ProductInfo { Name = "Mac's Coffee2", Description = "Coffee with teeth2", NumberInstock = 100},
                new ProductInfo { Name = "Mac's Coffee3", Description = "Coffee with teeth3", NumberInstock = 120},
                new ProductInfo { Name = "Mac's Coffee4", Description = "Coffee with teeth4", NumberInstock = 2},
                new ProductInfo { Name = "Mac's Coffee5", Description = "Coffee with teeth5", NumberInstock = 100},
                new ProductInfo { Name = "Mac's Coffee6", Description = "Coffee with teeth6", NumberInstock = 73},
            };
            SelectEverything(itemInStock);
            Console.WriteLine();

            Console.WriteLine("------------------分界线:选出 NumberInstock > 25 的子集合----------------------");
            GetOverstock(itemInStock);

            Console.ReadLine();
        }

        static void GetFastCars(List<Car> myCars)
        {
            var fastCars = from c in myCars where c.Speed > 55 select c;//1、隐式类型本地变量是强类型的，编译时由编译器确定类型，简化代码。2、它只能在方法的内部使用，不能作为类的属性。3、可以用来查看返回值类型。

            foreach (var car in fastCars)
            {
                Console.WriteLine(car.PetName);
            }
        }

        static void SelectEverything(ProductInfo[] products)
        {
            var allProducts = from p in products select p;
            foreach (var prod in allProducts)
            {
                Console.WriteLine(prod.ToString());
            }
        }

        static void GetOverstock(ProductInfo[] products)
        {
            var overstock = from p in products where p.NumberInstock > 25 select p;
            foreach (var c in overstock)
            {
                Console.WriteLine(c.ToString());
            }
        }
    }
}
