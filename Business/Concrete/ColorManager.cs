using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager:IColorService
    {
        ICarDal _carDal;

        public ColorManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public List<Car> GetCarsByColorId(int colorId)
        {
            var GetCar = _carDal.GetAll(c => c.ColorId == colorId).ToList();
            return GetCar;
        }
    }
}
