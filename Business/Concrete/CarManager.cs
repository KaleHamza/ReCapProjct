using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

namespace Business.Concrete
{//Business da asla entity veya framework yok!
    //Business da uygulanabilecek tek şey ICarDall.
    public class CarManager : ICarService
    {
        ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public IResult Add(Car car)
        {
            if (car.Description.Length >= 2 && car.DailyPrice >= 0)
            {
                _carDal.Add(car);
                return new ErrorResult(Messages.ObjectInvalid);
            }
            return new SuccessResult(Messages.ObjectAdded);
        }

        public IResult Delete(Car car)
        {
            _carDal.Delete(car);
            return new SuccessResult(Messages.ObjectDeleted);
        }

        public IDataResult<List<Car>> GetAll()
        {
                //İş kodları.
                //Yetki kontrolü.
                //Geçer ise return e ulaşır ve ürünlere de ulaşmış olur.
            return new SuccessDataResult<List<Car>>(_carDal.GetAll());
        }

        public IDataResult<List<Car>> GetById(int CarId)
        {
            return new SuccessDataResult<List<Car>>(_carDal.Get(a => a.Id ==car.Id));//ICarDal da ekleme yapılacak.
        }

        public IDataResult<List<CarDetailDto>> GetCarDetails()
        {
            return new SuccessDataResult<List<CarDetailDto>>(_carDal.GetCarDetails());
        }

        public IDataResult<List<Car>> GetCarsByBrandId(int Id)
        {
            return new SuccessDataResult<List<Car>>(_carDal.GetAll( p => p.BrandId == brand.Id));
        }

        public IDataResult<List<Car>> GetCarsByColorId(int Id)
        {
            return new SuccessDataResult <List<Car>>(_carDal.GetAll(p => p.ColorId == color.Id));
        }

        public IResult Update(Car car)
        {
            _carDal.Update(car);
            return new SuccessResult(Messages.ObjectUpdated);
            

        }

        
    }
}
