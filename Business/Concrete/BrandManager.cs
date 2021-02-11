using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        ICarDal _carDal;

        public BrandManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetCarsByBrandId(int brandId)
        {
            var GetCarId = _carDal.GetAll(p => p.BrandId == brandId).ToList();
            return GetCarId;
        }
    }
}
