using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;
using System.Linq;

namespace ReCapProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hoşgeldiniz devam etmek için herhangi bir tuşa basınız");
            Console.ReadLine();
            Console.WriteLine("Bu Proje üstünde oldukça uğraşılmıştır ve sürekli olarak geliştirilmeye devam edilecek bir projedir indiren veya inceleyen herkese yol gösterme amacı ile başarılar ve kolay gelsin :))");
            Console.WriteLine("Araba ile işlemler için 1");
            Console.WriteLine("Marka ile işlemler için 2");
            Console.WriteLine("Renk ile işlemler için 3");
            Console.WriteLine("Kullanıcı ile işlemler için 4");
            Console.WriteLine("Müşteri ile işlemler için 5");
            Console.WriteLine("Kiralama ile işlemler için 6");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Araba eklemek için 1");
                    Console.WriteLine("Araba silmek için 2");
                    Console.WriteLine("Araba güncellemek için 3");
                    Console.WriteLine("Arabaları listelemek için 4");
                    Console.WriteLine("Araba getirmek için 5");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            CarAdd();
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Marka eklemek için 1");
                    Console.WriteLine("Marka silmek için 2");
                    Console.WriteLine("Marka güncellemek için 3");
                    Console.WriteLine("Markaları listelemek için 4");
                    Console.WriteLine("Marka getirmek için 5");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            BrandAdd();
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                    }
                    break;
                case "3":
                    Console.WriteLine("Renk eklemek için 1");
                    Console.WriteLine("Renk silmek için 2");
                    Console.WriteLine("Renk güncellemek için 3");
                    Console.WriteLine("Renkleri listelemek için 4");
                    Console.WriteLine("Renk getirmek için 5");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            ColorAdd();
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                    }
                    break;
                case "4":
                    Console.WriteLine("Kullanıcı eklemek için 1");
                    Console.WriteLine("Kullanıcı silmek için 2");
                    Console.WriteLine("Kullanıcı güncellemek için 3");
                    Console.WriteLine("Kullanıcıları listelemek için 4");
                    Console.WriteLine("Kullanıcı getirmek için 5");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            UserAdd();
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                    }
                    break;
                case "5":
                    Console.WriteLine("Müşteri eklemek için 1");
                    Console.WriteLine("Müşteri silmek için 2");
                    Console.WriteLine("Müşteri güncellemek için 3");
                    Console.WriteLine("Müşterileri listelemek için 4");
                    Console.WriteLine("Müşteri getirmek için 5");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            CustomerAdd();
                            break;
                        case "2":
                            break;
                        case "3":
                            break;
                        case "4":
                            break;
                        case "5":
                            break;
                    }
                    break;
                case "6":
                    Console.WriteLine("Kiralama eklemek için 1");
                    Console.WriteLine("Kiralama silmek için 2");
                    Console.WriteLine("Kiralama güncellemek için 3");
                    Console.WriteLine("Kiralama listelemek için 4");
                    Console.WriteLine("Kiralama getirmek için 5");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            RentalsAdd();
                            Console.ReadLine();
                            break;
                        case "2":
                            break;
                        case "3":
                            RentalUpdate();
                            break;
                        case "4":
                            RentalsList();
                            Console.ReadLine();
                            break;
                        case "5":
                            break;
                    }
                    break;

            }

        }
        #region Kiralama işlemleri
        private static void RentalsAdd()
        {
            RentalsManager rentals = new RentalsManager(new EfRentalsDal());
            Rentals rentals1 = new Rentals();

            Console.WriteLine("Bir kullanıcı Id'si giriniz");
            Console.WriteLine("Kullanıcıların listelenmesini istiyorsanız listele yazın");
            switch (Console.ReadLine())
            {
                case "Listele":
                    UsersManager users = new UsersManager(new EfUsersDal());
                    var result = users.GetAll().Data;
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.FirstName + "" + item.Id);
                    }
                    break;
                case "listele":
                    UsersManager userss = new UsersManager(new EfUsersDal());
                    var results = userss.GetAll().Data;
                    foreach (var item in results)
                    {
                        Console.WriteLine(item.FirstName + "" + item.Id);
                    }
                    break;
            }
            Console.WriteLine("Bir kullanıcı Id'si giriniz");
            rentals1.CustomerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Bir araba Id'si giriniz");
            Console.WriteLine("Arabaların listelenmesini istiyorsanız listele yazın");
            switch (Console.ReadLine())
            {
                case "Listele":
                    CarManager cars = new CarManager(new EfCarDal());
                    var result = cars.GetAll().Data;
                    foreach (var item in result)
                    {
                        Console.WriteLine(item.Description + "" + item.CarId);
                    }
                    break;
                case "listele":
                    CarManager carss = new CarManager(new EfCarDal());
                    var results = carss.GetAll().Data;
                    foreach (var item in results)
                    {
                        Console.WriteLine(item.Description + "" + item.CarId);
                    }
                    break;
            }
            Console.WriteLine("Bir araba Id'si giriniz");
            rentals1.CarId = Convert.ToInt32(Console.ReadLine());
            rentals1.RentDate = DateTime.Now;
            rentals1.ReturnDate = DateTime.Today.Add(TimeSpan.FromDays(5));

            rentals.Add(rentals1);
            Console.WriteLine("Kiralama başarı ile kaydedilmiştir");

        }

        private static void RentalsList()
        {
            RentalsManager rentals = new RentalsManager(new EfRentalsDal());
            Rentals rentals1 = new Rentals();
            foreach (var item in rentals.GetAll().Data)
            {
                Console.WriteLine("Arabanın Idsi " + item.CarId + " Alınış tarihi " + item.RentDate + " Verilmesi gereken tarih " + item.ReturnDate);
            }
        }

        private static void RentalUpdate()
        {
            RentalsManager rentals = new RentalsManager(new EfRentalsDal());
            Console.WriteLine("Güncellemek istediğiniz kiralamanın Id'sini giriniz");
            var result = rentals.GetRentalsById(Convert.ToInt32(Console.ReadLine())).Data;

            Console.WriteLine("Aracınızı hemen şimdi vermek için 1");
            Console.WriteLine("Aracın veriliş tarihini güncellemek için 2");
            if (Console.ReadLine() == "1")
            {
                result.ReturnDate = DateTime.Now;
                Console.WriteLine(result.ReturnDate);
                Console.Read();
            }
            else if (Console.ReadLine() == "2")
            {
                Console.WriteLine(result.ReturnDate);
                Console.WriteLine("Arabayı veriliş tarihini manuel girmek için 1");
                Console.WriteLine("Arabayı veriliş üstüne tarih ekleyerek vermek için 2 yazınız");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Arabayı vermek istediğiniz tarihi değiştirmek için tarihi 01/01/2020 Formatında giriniz");
                        result.ReturnDate = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine(result.ReturnDate);
                        Console.Read();
                        break;
                    case "2":
                        do
                        {
                            Console.WriteLine("Veriliş süresine 5 gün eklemek için 1");
                            Console.WriteLine("Veriliş süresine ek gün eklemek için 2");
                            Console.WriteLine("Consoldan çıkmak için 'Bitti' yazınız");
                            switch (Console.ReadLine())
                            {
                                case "1":
                                    result.ReturnDate = DateTime.Today.AddDays(5);
                                    //result.ReturnDate =Convert.ToDateTime(Console.ReadLine());
                                    Console.WriteLine(result.ReturnDate);
                                    Console.Read();
                                    break;
                                case "2":
                                    result.ReturnDate = DateTime.Today.Add(TimeSpan.FromDays(Convert.ToDouble(Console.ReadLine())));
                                    Console.WriteLine(result.ReturnDate);
                                    Console.Read();
                                    break;
                            }
                        } while (Console.ReadLine() == "Bitti");
                        break;
                }
            }
        }

        #endregion


        #region User İşlemleri
        private static void UserAdd()
        {
            UsersManager users = new UsersManager(new EfUsersDal());
            Users users1 = new Users();
            Console.WriteLine("Lütfen kullanıcı eklerken aynı maile sahip başka bir kullanıcı eklemeye çalışmayın");
            Console.WriteLine("Bir kullanıcı adı giriniz");
            users1.FirstName = Console.ReadLine();

            Console.WriteLine("Bir kullanıcı soyadı giriniz");
            users1.LastName = Console.ReadLine();

            Console.WriteLine("Bir kullanıcı maili giriniz");
            users1.Email = Console.ReadLine();

            Console.WriteLine("Bir kullanıcı şifresi giriniz");
            users1.Passwordd = Console.ReadLine();
            users.Add(users1);
            Console.WriteLine(users1.FirstName + " adlı kullanıcı eklenmiştir");


        }
        #endregion


        #region Müşteri işlemleri
        private static void CustomerAdd()
        {
            CustomerManager customer = new CustomerManager(new EfCustomerDal());
            Customer customer1 = new Customer();

            Console.WriteLine("Bir Müşteri Id'si giriniz");
            Console.WriteLine("Lütfen varolan bir Kullanıcı Id'si girmeyiniz");
            Console.WriteLine("Kullanıcıları listelemek için listele yazınız");
            switch (Console.ReadLine())
            {
                case "Listele":
                    UsersManager users = new UsersManager(new EfUsersDal());
                    foreach (var item in users.GetAll().Data)
                        Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Id);
                    break;
                case "listele":
                    UsersManager userss = new UsersManager(new EfUsersDal());
                    foreach (var item in userss.GetAll().Data)
                        Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.Id);
                    break;
            }
            Console.WriteLine("Bir Müşteri Id'si giriniz");
            customer1.UserId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir Şirket Adı giriniz");
            Console.WriteLine("Lütfen varolan bir Şirket Adı girmeyiniz");
            Console.WriteLine("Varolan Şirket adlarını listelemek için listele yazınız");
            foreach (var item in customer.GetAll().Data)
            {
                Console.WriteLine(item.CompanyName);
            }
            Console.WriteLine("Bir Şirket Adı giriniz");
            customer1.CompanyName = Console.ReadLine();
            customer.Add(customer1);
            Console.WriteLine(customer1.CompanyName + " adlı müşteri eklenmiştir");
            customer1.UserId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir Müşteri şirket adı giriniz");
            customer1.CompanyName = Console.ReadLine();
            customer.Add(customer1);
        }
        #endregion


        #region Marka İşlemleri
        private static void BrandAdd()
        {
            BrandManager brand = new BrandManager(new EfBrandDal());
            Console.WriteLine("Bir Marka adı ekleyiniz");
            Console.WriteLine("Lütfen olan Marka adını tekrar girmeyiniz");
            Console.WriteLine("Varolan Marka adlarını listelemek için listele yazınız");
            switch (Console.ReadLine())
            {
                case "Listele":
                    foreach (var item in brand.GetAllBrands().Data)
                    {
                        Console.Write(item.BrandId + " ");
                        Console.Write(item.Name + " ");
                    }
                    break;
                case "listele":
                    foreach (var item in brand.GetAllBrands().Data)
                    {
                        Console.Write(item.BrandId + " ");
                        Console.Write(item.Name + " ");
                    }
                    break;
            }
            Brand brand1 = new Brand();
            brand1.Name = Console.ReadLine();
            brand.Add(brand1);
            Console.WriteLine($"{brand1.Name} başarıyla eklenmiştir");

        }
        #endregion

        #region Renk İşlemleri
        private static void ColorAdd()
        {
            ColorManager color = new ColorManager(new EfColorDal());
            Color color1 = new Color();

            Console.WriteLine("Bir Renk adı ekleyiniz");
            Console.WriteLine("Lütfen varolan Renk adını tekrar girmeyiniz");
            Console.WriteLine("Lütfen varolan Renkleri listelemek için listele yazınız");
            switch (Console.ReadLine())
            {
                case "Listele":
                    foreach (var item in color.GetAllColors().Data)
                    {
                        Console.Write(item.ColorId + " ");
                        Console.Write(item.Name + " ");
                    }
                    break;
                case "listele":
                    foreach (var item in color.GetAllColors().Data)
                    {
                        Console.Write(item.ColorId + " ");
                        Console.Write(item.Name + " ");
                    }
                    break;
            }
            Console.WriteLine("Bir Renk adı ekleyiniz");
            color1.Name = Console.ReadLine();
            color.Add(color1);
            Console.WriteLine($"{color1.Name} başarıyla eklenmiştir");
        }
        #endregion

        #region Araba İşlemleri
        private static void CarAdd()
        {
            BrandManager brand = new BrandManager(new EfBrandDal());
            ColorManager color = new ColorManager(new EfColorDal());
            CarManager car = new CarManager(new EfCarDal());
            Console.WriteLine("Bir Araba ekleyeceksiniz devam etmek için enter tuşuna basın");
            Car car1 = new Car();
            Console.WriteLine("Marka Id ekleyiniz olmayan bir marka eklemeye çalışmayın");
            foreach (var item in brand.GetAllBrands().Data)
            {
                Console.Write(item.BrandId + " ");
                Console.Write(item.Name + " ");
            }
            car1.BrandId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Renk Id ekleyiniz olmayan bir renk eklemeye çalışmayın");
            foreach (var item in color.GetAllColors().Data)
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
            Console.WriteLine($"{car1.Description} Açıklamasına sahip araba eklenmiştir");

        }
        #endregion

        #region Car İşlemleri
        private static void CarDetailDto()
        {
            CarManager car = new CarManager(new EfCarDal());
            var result = car.GetCarDetails();
            if (result.Success)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.Description + " " + item.ColorName + " " + item.BrandName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            Console.Read();

        }
        #endregion


    }
}
