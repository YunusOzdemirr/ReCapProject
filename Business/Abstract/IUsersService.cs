using Core.Utilites.DataResults;
using Core.Utilites.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUsersService
    {
        IDataResult<List<Users>> GetAll();
        IDataResult<Users> GetUsersById(int userId);
        IResult Add(Users user);
        IResult Update(int userId);
        IResult Delete(int userId);
    }
}
