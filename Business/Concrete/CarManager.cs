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

        public bool Add(Car car)
        {
            if (car.Description.Length > 2 && car.DailyPrice > 0)
            {
                _carDal.Add(car);
                return true;
            }
            else
            {
                Console.WriteLine("Hatalı giriş tekrar deneyin.");
                return false;
            }
        }

        public List<Car> GetAll()
        {
                //İş kodları.
                //Yetki kontrolü.
                //Geçer ise return e ulaşır ve ürünlere de ulaşmış olur.
            return _carDal.GetAll();
        }

        public List<Car> GetCarsByBrandId(int Id)
        {
            return _carDal.GetAll(p => p.BrandId == Id);
        }

        public List<Car> GetCarsByColorId(int Id)
        {
            return _carDal.GetAll(p => p.ColorId == Id);
        }
    }
}
