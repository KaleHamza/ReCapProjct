﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
   /* public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
            
                new Car{Id = 1, BrandId = 1, ColorId=15,ModelYear=2014, DailyPrice=400, Description ="Aston Martin V8 Vantage - Bej"},
                new Car{Id = 2, BrandId = 4, ColorId=1,ModelYear=2018, DailyPrice=300, Description ="Peugeot V8 Vantage - siyah"},
                new Car{Id = 3, BrandId = 2, ColorId=2,ModelYear=2008, DailyPrice=2000, Description ="Ferrari 430 Scuderia - Kırmızı"},
                new Car{Id = 4, BrandId = 3, ColorId=1,ModelYear=1967, DailyPrice=1000, Description ="Ford Mustang  - Siyah"},
                new Car{Id = 5, BrandId = 5, ColorId=5,ModelYear=1980, DailyPrice=250, Description ="Buik Enclave - Sarı"},
                new Car{Id = 6, BrandId = 1, ColorId=8,ModelYear=2018, DailyPrice=600, Description ="Aston Martin V12 Zagato - Kahverengi"}
            };

        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }


        public void Delete(Car car)
        {
            Car carToDelete = null;

            carToDelete = _cars.SingleOrDefault(p =>p.Id == car.Id);

            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p => p.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUptade = _cars.SingleOrDefault(p => p.Id == car.Id);
            carToUptade.Id = car.Id;
            carToUptade.ColorId = car.ColorId;
            carToUptade.BrandId = car.BrandId;
            carToUptade.ColorId = car.ColorId;
            carToUptade.Description = car.Description;
            carToUptade.ModelYear = car.ModelYear;
        }

        
                
                
                
        }*/
    }

