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
    public class ColorManager:IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public IResult Add(Color color)
        {
            _colorDal.Add(color);
            return new SuccessResult(Messages.ObjectAdded);
        }

        public IDataResult<List<Color>> GetAllColors()
        {
            var result = _colorDal.GetAll();
            return new SuccessDataResult<List<Color>>(result,Messages.ObjectList);
        }
        public IDataResult<Color> GetColorById(int id)
        {
            var result = _colorDal.Get(p => p.ColorId == id);
            return new SuccessDataResult<Color>(result, Messages.ObjectList);

        }
        public IResult Update(int id)
        {
            var result = _colorDal.Get(p => p.ColorId == id);
            if (result != null)
            {
                return new SuccessResult(Messages.ObjectUpdate);
            }
            return new ErrorResult(Messages.ErrorMessage);
        }
    }
}
