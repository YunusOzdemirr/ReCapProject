using Business.Abstract;
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
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IDataResult<Brand> GetBrandById(int id)
        {
            var result = _brandDal.Get(p => p.BrandId == id);
            return new SuccessDataResult<Brand>(result,Messages.ObjectList) ;
        }
        public IDataResult<List<Brand>> GetAllBrands()
        {
            var result = _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(result, Messages.ObjectList);

        }
        public IResult Add(Brand brand)
        {
            _brandDal.Add(brand);
            return new SuccessResult(Messages.ObjectAdded);
        }

        public IResult Update(int id)
        {
            var result = _brandDal.Get(p => p.BrandId == id);
            if (result!=null)
            {
                return new SuccessResult(Messages.ObjectUpdate);
            }
            return new ErrorResult(Messages.ErrorMessage);
        }
    }
}
