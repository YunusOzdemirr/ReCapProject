using Business.Abstract;
using Business.Constants;
using Core.Utilites.DataResults;
using Core.Utilites.DataResults.MethodDataResult;
using Core.Utilites.Results;
using Core.Utilites.Results.MethodResult;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImagesService
    {
        ICarImagesDal _carImagesDal;
        public CarImageManager(ICarImagesDal carImagesDal)
        {
            _carImagesDal = carImagesDal;
        }

        public IDataResult<CarImages> Add(CarImages carImage)
        {

             _carImagesDal.Add(carImage);
            return new SuccessDataResult<CarImages>(carImage,Messages.ObjectAdded);
        }

        public IResult Delete(int carImageId)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImages>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IResult Update(int carImageId)
        {
            throw new NotImplementedException();
        }
    }
}
