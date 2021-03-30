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
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        ICarDal _carDal;

        public ColorManager(IColorDal colorDal, ICarDal carDal)
        {
            _colorDal = colorDal;
            _carDal = carDal;
        }

        public IResult Add(Color color)
        {
            var result = _colorDal.Get(b => b.Name == color.Name);
            if (result != null)
            {
                return new ErrorResult(Messages.Exist);
            }
            _colorDal.Add(color);
            return new SuccessResult(Messages.ObjectAdded);
        }

        public IDataResult<List<Color>> GetAllColors()
        {
            var result = _colorDal.GetAll();
            return new SuccessDataResult<List<Color>>(result, Messages.ObjectList);
        }
        public IDataResult<Color> GetById(int colorId)
        {
            var result = _colorDal.Get(b=>b.ColorId==colorId);
            return new SuccessDataResult<Color>(result, Messages.ObjectList);
        }
        public IDataResult<Color> GetColorById(int colorId)
        {
            var result = _colorDal.Get(p => p.ColorId == colorId);
            return new SuccessDataResult<Color>(result, Messages.ObjectList);

        }
        public IResult Update(int colorId)
        {
            var result = _colorDal.Get(p => p.ColorId == colorId);
            if (result != null)
            {
                return new SuccessResult(Messages.ObjectUpdate);
            }
            return new ErrorResult(Messages.ErrorMessage);
        }
        public IResult Delete(int colorId)
        {
            var result = _colorDal.Get(p => p.ColorId == colorId);
            _colorDal.Delete(result);
            return new SuccessResult(Messages.ObjectDeleted);
        }

        public IDataResult<List<Car>> GetCarsByColorId(int colorId)
        {
            var result=_carDal.GetAll(b => b.ColorId == colorId).ToList();
            return new SuccessDataResult<List<Car>>(result, Messages.ObjectList);
        }
    }
}
