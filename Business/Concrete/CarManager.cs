using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilites.DataResults;
using Core.Utilites.DataResults.MethodDataResult;
using Core.Utilites.Results;
using Core.Utilites.Results.MethodResult;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
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

        public IDataResult<List<Car>> GetAll()
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll(), Messages.ObjectList);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            var GetCarId = _carDal.GetAll(p => p.CarId == brandId).ToList();
            return new SuccessDataResult<List<Car>>(GetCarId, Messages.ObjectList);

        }
        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            var GetCar = _carDal.GetAll(c => c.ColorId == colorId).ToList();
            return new SuccessDataResult<List<Car>>(GetCar, Messages.ObjectList);
        }
        [ValidationAspect(typeof(CarValidator))]
        public IResult Add(Car car)
        {
            // car.Description.Length > 2 && car.DailyPrice > 0 ? _carDal.Add(car) : Console.WriteLine("Hata");

             _carDal.Add(car);
            return new SuccessResult(Messages.ObjectAdded);

        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            var result = _carDal.GetCarDetails();
            return new SuccessDataResult<List<CarDetailDto>>(result, Messages.ObjectList);
        }

        public IResult Update(int carId)
        {
            var result = _carDal.Get(p => p.CarId == carId);
            _carDal.Update(result);
            return new SuccessResult(Messages.ObjectUpdate);
        }

        public IResult Delete(int carId)
        {
            var result = _carDal.Get(p => p.CarId == carId);
            _carDal.Delete(result);
            return new SuccessResult(Messages.ObjectDeleted);
        }
    }
}
