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
    public class RentalsManager : IRentalsService
    {
        IRentalsDal _rentalsDal;

        public RentalsManager(IRentalsDal rentalsDal)
        {
            _rentalsDal = rentalsDal;
        }

        public IResult Add(Rentals rentals)
        {
            if (rentals.ReturnDate == null)
            {
                return new SuccessResult(Messages.ErrorMessage);
            }
            _rentalsDal.Add(rentals);
            return new SuccessResult(Messages.MaintenanceTime);
        }

        public IResult Delete(int rentalsId)
        {

            var result = _rentalsDal.Get(p => p.Id == rentalsId);
            if (result.RentDate == result.ReturnDate)
            {
                _rentalsDal.Delete(result);
                return new SuccessResult(Messages.ObjectDeleted);
            }
            return new ErrorResult(Messages.ErrorMessage);

        }

        public IDataResult<List<Rentals>> GetAll()
        {
            var result = _rentalsDal.GetAll();
            return new SuccessDataResult<List<Rentals>>(result, Messages.ObjectList);
        }

        public IDataResult<Rentals> GetRentalsById(int rentalsId)
        {
            var result = _rentalsDal.Get(p => p.Id == rentalsId);
            //Gelen Kiralamanın ne zaman kiralandığı ve ne zaman getirilmesi gerektiğini gösteriyor
            Console.WriteLine(result.RentDate);
            Console.WriteLine(result.ReturnDate);
            return new SuccessDataResult<Rentals>(result, Messages.ObjectList);
        }

        public IResult Update(int rentalsId)
        {
            var result = _rentalsDal.Get(p => p.Id == rentalsId);

            if (result!=null)
            {
                if (result.ReturnDate == null)
                {
                    //geri getiriliş tarihini şimdiye ayarlıyor
                    result.ReturnDate = DateTime.Now;
                    _rentalsDal.Update(result);
                    Console.WriteLine("Aracınız geri teslim edilmiştir");
                    return new SuccessResult(Messages.ObjectUpdate);
                }
            }

            return new ErrorResult(Messages.ErrorMessage);
        }
    }
}
