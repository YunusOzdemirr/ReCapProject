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
            Console.WriteLine("Bir Araba eklemek için 1");
            Console.WriteLine("Bir Marka eklemek için 2");
            Console.WriteLine("Bir Color eklemek için 3");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Bir Araba ekleyeceksiniz devam etmek için enter tuşuna basın");
                    Car car1 = new Car();
                    Console.WriteLine("Marka Id ekleyiniz olmayan bir marka eklemeye çalışmayın");
                    car1.BrandId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Renk Id ekleyiniz olmayan bir renk eklemeye çalışmayın");
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
                    Console.WriteLine("Bir Marka ekleyiniz");
                    Brand brand1 = new Brand();
                    brand1.Name = Console.ReadLine();
                    brand.Add(brand1);
                    Console.WriteLine($"{brand1.Name} başarıyla eklenmiştir");
                    break;
                case "3":
                    Console.WriteLine("Bir Renk ekleyiniz");
                    Color color1= new Color();
                    color1.Name = Console.ReadLine();
                    color.Add(color1);
                    Console.WriteLine($"{color1.Name} başarıyla eklenmiştir");
                    break;
            }
        }
    }
}
