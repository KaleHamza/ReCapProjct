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

        public List<Car> GetAll()
        {
                //İş kodları.
                //Yetki kontrolü.
                //Geçer ise return e ulaşır ve ürünlere de ulaşmış olur.
            return _carDal.GetAll();
        }
    }
}
