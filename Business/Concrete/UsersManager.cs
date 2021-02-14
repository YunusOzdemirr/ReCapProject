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
using System.Text;

namespace Business.Concrete
{
    public class UsersManager : IUsersService
    {
        IUsersDal _userDal;

        public UsersManager(IUsersDal userService)
        {
            _userDal = userService;
        }

        public IResult Add(Users user)
        {
            _userDal.Add(user);
            return new SuccessResult(Messages.ObjectAdded);
        }

        public IResult Delete(int userId)
        {
            var result = _userDal.Get(p => p.Id == userId);
            _userDal.Delete(result);
            return new SuccessResult(Messages.ObjectDeleted);
        }

        public IDataResult<List<Users>> GetAll()
        {
            var result = _userDal.GetAll();
            return new SuccessDataResult<List<Users>>(result, Messages.ObjectList);
        }

     
        public IDataResult<Users> GetUsersById(int userId)
        {
            var result = _userDal.Get(p => p.Id == userId);
            return new SuccessDataResult<Users>(result, Messages.ObjectDeleted);
        }

        public IResult Update(int userId)
        {
            var result = _userDal.Get(p => p.Id == userId);
            _userDal.Update(result);
            return new SuccessDataResult<Users>(result, Messages.ObjectDeleted);
        }
    }
}
