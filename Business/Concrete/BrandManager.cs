﻿using Business.Abstract;
using Business.Constants;
using Core.Utilites.DataResults;
using Core.Utilites.DataResults.MethodDataResult;
using Core.Utilites.Results;
using Core.Utilites.Results.MethodResult;
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
        private readonly IBrandDal _brandDal;
        private readonly ICarDal _carDal;

        public BrandManager(IBrandDal brandDal, ICarDal carDal)
        {
            _brandDal = brandDal;
            _carDal = carDal;
        }

        public IDataResult<Brand> GetBrandById(int brandId)
        {
            var result = _brandDal.Get(p => p.BrandId == brandId);
            return new SuccessDataResult<Brand>(result,Messages.ObjectList) ;
        }

        public IDataResult<List<Brand>> GetAllBrands()
        {
            var result = _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(result, Messages.ObjectList);

        }

        public IResult Add(Brand brand)
        {
            var result = _brandDal.Get(b => b.Name == brand.Name);
            if (result!=null)
            {
                return new ErrorResult(Messages.Exist);
            }
            _brandDal.Add(brand);
            return new SuccessResult(Messages.ObjectAdded);
        }

        public IResult Update(int brandId)
        {
            var result = _brandDal.Get(p => p.BrandId == brandId);
            if (result!=null)
            {
                return new SuccessResult(Messages.ObjectUpdate);
            }
            return new ErrorResult(Messages.ErrorMessage);
        }
        public IResult Delete(int brandId)
        {
            var result = _brandDal.Get(p => p.BrandId == brandId);
            _brandDal.Delete(result);
            return new SuccessResult(Messages.ObjectDeleted);
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int brandId)
        {
            var result =_carDal.GetAll(b => b.BrandId == brandId).ToList();
            return new SuccessDataResult<List<Car>>(result, Messages.ObjectList);
        }
    }
}
