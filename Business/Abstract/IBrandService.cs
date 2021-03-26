using Core.Utilites.DataResults;
using Core.Utilites.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAllBrands();
        IDataResult<Brand> GetBrandById(int brandId);
        IResult Add(Brand brand);
        IResult Update(int brandId);
        IResult Delete(int brandId);
        IDataResult<List<Car>> GetCarsByBrandId(int brandId);
    }
}
