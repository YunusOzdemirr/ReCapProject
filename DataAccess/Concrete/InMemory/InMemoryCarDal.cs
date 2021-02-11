using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>()
            {
                new Car{CarId=1,BrandId=1,ColorId=1,DailyPrice=250,Description="Ucuz Araç",ModelYear=2016},
                new Car{CarId=2,BrandId=1,ColorId=1,DailyPrice=350,Description="Konforlu Araç",ModelYear=2020},
                new Car{CarId=3,BrandId=2,ColorId=2,DailyPrice=450,Description="Hızlı Araç",ModelYear=2019},
                new Car{CarId=4,BrandId=2,ColorId=2,DailyPrice=550,Description="Uygun ve Hızlı Araç",ModelYear=2018},
                new Car{CarId=5,BrandId=3,ColorId=3,DailyPrice=650,Description="Pahalı Araç",ModelYear=2020},
                new Car{CarId=6,BrandId=3,ColorId=3,DailyPrice=350,Description="Yavaş Araç",ModelYear=2013}
            };
        }
        public void Add(Car car)
        {
            _car.Add(car);
        }

        public void Delete(Car car)
        {
            var carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            _car.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public Car GetById(int id)
        {
            var carToDelete = _car.SingleOrDefault(c => c.CarId == id);
            return carToDelete;
        }

        public void Update(Car car)
        {
            var carToDelete = _car.SingleOrDefault(c => c.CarId == car.CarId);
            carToDelete.CarId = car.CarId;
            carToDelete.BrandId = car.BrandId;
            carToDelete.ColorId = car.ColorId;
            carToDelete.DailyPrice = car.DailyPrice;
            carToDelete.ModelYear = car.ModelYear;
            carToDelete.Description = car.Description;
        }
    }
}
