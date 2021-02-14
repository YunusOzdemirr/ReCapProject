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
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            _customerDal.Add(customer);
            return new SuccessResult(Messages.ObjectAdded);
        }

        public IResult Delete(int customerId)
        {
            var result = _customerDal.Get(c => c.UserId == customerId);
            _customerDal.Delete(result);
            return new SuccessResult(Messages.ObjectDeleted);
        }

        public IDataResult<List<Customer>> GetAll()
        {
           var result= _customerDal.GetAll();
            return new SuccessDataResult<List<Customer>>(result,Messages.ObjectList);

        }

        public IDataResult<Customer> GetCustomerById(int customerId)
        {
            var result = _customerDal.Get(p => p.UserId == customerId);
            return new SuccessDataResult<Customer>(result, Messages.ObjectList);
        }

        public IResult Update(int customerId)
        {
            var result = _customerDal.Get(p => p.UserId == customerId);
            _customerDal.Update(result);
            return new SuccessResult(Messages.ObjectUpdate);
        }
    }
}
