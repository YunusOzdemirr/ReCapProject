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
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }
      
        public List<Color> GetAllColors()
        {
            var result = _colorDal.GetAll();
            return result;
        }
        public Color GetColorById(int id)
        {
            var result = _colorDal.Get(p => p.ColorId == id);
            return result;
        }
    }
}
