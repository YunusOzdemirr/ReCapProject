using Core.Entities.Concrete;
using Core.Utilites.DataResults;
using Core.Utilites.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetUsersById(int userId);
        IResult Add(User user);
        IResult Update(int userId);
        IResult Delete(int userId);
        List<OperationClaim> GetClaims(Core.Entities.Concrete.User user);
        User GetByMail(string email);
    }
}
