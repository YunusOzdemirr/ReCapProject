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
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public Brand GetBrandById(int id)
        {
            var result = _brandDal.Get(p => p.BrandId == id);
            return result;
        }
        public List<Brand> GetAllBrands()
        {
            var result = _brandDal.GetAll();
            return result;
        }

        public void Add(Brand brand)
        {
            _brandDal.Add(brand);
        }
    }
}
