using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.Utilites.Business;
using Core.Utilites.DataResults;
using Core.Utilites.DataResults.MethodDataResult;
using Core.Utilites.Helpers;
using Core.Utilites.Results;
using Core.Utilites.Results.MethodResult;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;
        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        //[ValidationAspect(typeof(CarImageValidator))]
        public IResult Add(IFormFile file, CarImage carImage)
        {
            //IResult result = BusinessRules.Run(CheckImageLimitExceeded(carImage.CarId));
            //if (result != null)
            //{
            //    return result;
            //}
            carImage.ImagePath = FileHelper.Add(file);
            _carImageDal.Add(carImage);
            return new SuccessResult();
        }
        //[ValidationAspect(typeof(CarImageValidator))]
        public IResult Delete(CarImage carImage)
        {
            FileHelper.Delete(carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }
        //[ValidationAspect(typeof(CarImageValidator))]
        public IResult Update(IFormFile file, CarImage carImage)
        {
            carImage.ImagePath = FileHelper.Update(_carImageDal.Get(p => p.Id == carImage.Id).ImagePath, file);
            carImage.Datee = DateTime.Now;
            _carImageDal.Update(carImage);
            return new SuccessResult();
        }
        //[ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<CarImage> Get(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(p => p.Id == id),Messages.ObjectList);
        }
        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.ObjectList);
        }
        //[ValidationAspect(typeof(CarImageValidator))]
        public IDataResult<List<CarImage>> GetImagesByCarId(int id)
        {
            return new SuccessDataResult<List<CarImage>>(CheckIfCarImageNull(id), Messages.ObjectList);
        }

        //business rules
        private IResult CheckImageLimitExceeded(int carid)
        {
            var carImagecount = _carImageDal.GetAll(p => p.CarId == carid).Count;
            if (carImagecount >= 5)
            {
                return new ErrorResult(Messages.CarImageLimitExceeded);
            }

            return new SuccessResult();
        }
        private List<CarImage> CheckIfCarImageNull(int id)
        {
            string path = @"\Images\logo.jpg";
            var result = _carImageDal.GetAll(c => c.CarId == id).Any();
            if (!result)
            {
                return new List<CarImage> { new CarImage { CarId = id, ImagePath = path, Datee = DateTime.Now } };
            }
            return _carImageDal.GetAll(p => p.CarId == id);
        }
    }
}
