using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
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

        public void Add(Car car)
        {
            if (car.CarName.Length < 2 && car.DailyPrice < 0)
            {
                Console.WriteLine("Araba ismi minimum 2 karakter ve günlük fiyatı 0'dan büyük olmalıdır. ");
            }
            else
            {
                _carDal.Add(car);
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
                //İş kodları.
                //Yetki kontrolü.
                //Geçer ise return e ulaşır ve ürünlere de ulaşmış olur.
            return _carDal.GetAll();
        }

        public List<Car> GetById(int CarId)
        {
            return _carDal.GetById(CarId);//ICarDal da ekleme yapılacak.
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carDal.GetCarDetails();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(p => p.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(p => p.ColorId == Id);
        }

        public void Update(Car car)
        {
            _carDal.Update(car);
        }
        
    }
}
