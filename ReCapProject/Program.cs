using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager car = new CarManager(new EfCarDal());
            foreach (var item in car.GetAll())
            {
                Console.WriteLine(item.Description + " " + item.DailyPrice);
            }
            ColorManager color = new ColorManager(new EfColorDal());
            foreach (var item in color.GetAllColors())
            {
                Console.WriteLine(item.ColorId + " " + item.Name);
            }
            BrandManager brand = new BrandManager(new EfBrandDal());
            foreach (var item in brand.GetAllBrands())
            {
                Console.WriteLine(item.BrandId + " " + item.Name);
            }
            Console.WriteLine(brand.GetBrandById(1).Name);
            Console.WriteLine(brand.GetBrandById(2).Name);
            Console.WriteLine("Bir marka ekleyiniz");
            Brand brand1 = new Brand();
            brand1.Name = Console.ReadLine();
            brand.Add(brand1);
            Console.Read();

        }
    }
}
