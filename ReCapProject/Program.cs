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
            //CarManager car;
            //ColorManager color;
            //BrandManager brand;
            //BasicMethod(out car, out color, out brand);
            //CarBrandColorAddMethod(car, color, brand);
            CarDetailDto();
        }
        private static void CarDetailDto() 
        {
            CarManager car = new CarManager(new EfCarDal());
            foreach (var item in car.GetCarDetails())
            {
                Console.WriteLine(item.Description + " " + item.ColorName + " " + item.BrandName);
            }
        }

        private static void CarBrandColorAddMethod(CarManager car, ColorManager color, BrandManager brand)
        {
            Console.WriteLine("Bir Araba eklemek için 1");
            Console.WriteLine("Bir Marka eklemek için 2");
            Console.WriteLine("Bir Color eklemek için 3");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Bir Araba ekleyeceksiniz devam etmek için enter tuşuna basın");
                    Car car1 = new Car();
                    Console.WriteLine("Marka Id ekleyiniz olmayan bir marka eklemeye çalışmayın");
                    foreach (var item in brand.GetAllBrands())
                    {
                        Console.Write(item.BrandId + " ");
                        Console.Write(item.Name + " ");
                    }
                    car1.BrandId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Renk Id ekleyiniz olmayan bir renk eklemeye çalışmayın");
                    foreach (var item in color.GetAllColors())
                    {
                        Console.Write(item.ColorId + " ");
                        Console.Write(item.Name + " ");
                    }
                    car1.ColorId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Günlük kiralama ücretini ekleyiniz");
                    car1.DailyPrice = Convert.ToDecimal(Console.ReadLine());
                    Console.WriteLine("Açıklama ekleyiniz");
                    car1.Description = Console.ReadLine();
                    Console.WriteLine("Arabanın Model Yılını ekleyiniz");
                    car1.ModelYear = Convert.ToInt32(Console.ReadLine());
                    car.Add(car1);
                    Console.WriteLine($"{car1.CarId} Id'sine sahip araba eklenmiştir");
                    break;
                case "2":
                    Console.WriteLine("Bir Marka adı ekleyiniz");
                    Brand brand1 = new Brand();
                    brand1.Name = Console.ReadLine();
                    brand.Add(brand1);
                    Console.WriteLine($"{brand1.Name} başarıyla eklenmiştir");
                    break;
                case "3":
                    Console.WriteLine("Bir Renk adı ekleyiniz");
                    Color color1 = new Color();
                    color1.Name = Console.ReadLine();
                    color.Add(color1);
                    Console.WriteLine($"{color1.Name} başarıyla eklenmiştir");
                    break;
            }
        }

        private static void BasicMethod(out CarManager car, out ColorManager color, out BrandManager brand)
        {
            car = new CarManager(new EfCarDal());
            foreach (var item in car.GetAll())
            {
                Console.WriteLine(item.Description + " " + item.DailyPrice);
            }
            color = new ColorManager(new EfColorDal());
            foreach (var item in color.GetAllColors())
            {
                Console.WriteLine(item.ColorId + " " + item.Name);
            }
            brand = new BrandManager(new EfBrandDal());
            foreach (var item in brand.GetAllBrands())
            {
                Console.WriteLine(item.BrandId + " " + item.Name);
            }
            Console.WriteLine(brand.GetBrandById(1).Name);
            Console.WriteLine(brand.GetBrandById(2).Name);
        }
    }
}
