using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
    }
}
