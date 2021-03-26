using Core.Utilites.DataResults;
using Core.Utilites.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAllColors();
        IDataResult<Color> GetColorById(int colorId);
        IResult Add(Color color);
        IResult Update(int colorId);
        IResult Delete(int colorId);
        IDataResult<List<Car>> GetCarsByColorId(int colorId);
    }
}
