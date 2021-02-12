using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }
     
        #region Car
        public List<Car> GetAll()
        {
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            var GetCarId = _carDal.GetAll(p => p.BrandId == brandId).ToList();
            return GetCarId;

        }
        public List<Car> GetCarsByColorId(int colorId)
        {
            var GetCar = _carDal.GetAll(c => c.ColorId == colorId).ToList();
            return GetCar;
        }
        public void Add(Car car)
        {
           // car.Description.Length > 2 && car.DailyPrice > 0 ? _carDal.Add(car) : Console.WriteLine("Hata");
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
            }
            else
            {
                Console.WriteLine("hata");
            }
        }
        #endregion

      





    }
}
