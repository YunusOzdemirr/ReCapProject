using Business.Abstract;
using Business.Constants;
using Core.Entities.Concrete;
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
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userService)
        {
            _userDal = userService;
        }

        public IResult Add(User user)
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

        public IDataResult<List<User>> GetAll()
        {
            var result = _userDal.GetAll();
            return new SuccessDataResult<List<User>>(result, Messages.ObjectList);
        }

     
        public IDataResult<User> GetUsersById(int userId)
        {
            var result = _userDal.Get(p => p.Id == userId);
            return new SuccessDataResult<User>(result, Messages.ObjectDeleted);
        }

        public IResult Update(int userId)
        {
            var result = _userDal.Get(p => p.Id == userId);
            _userDal.Update(result);
            return new SuccessDataResult<User>(result, Messages.ObjectDeleted);
        }

        public List<OperationClaim> GetClaims(User user)
        {
            return _userDal.GetClaims(user);
        }


        public Core.Entities.Concrete.User GetByMail(string email)
        {
            return _userDal.Get(u => u.Email == email);
        }
    }
}
