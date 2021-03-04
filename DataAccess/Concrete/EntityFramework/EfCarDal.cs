using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Core.DataAccess.IEntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramefork;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsRentContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        
        {
            using (CarsRentContext context = new CarsRentContext())
            {
                var result = from c in context.Cars
                             join b in context.Brands on c.BrandId equals b.BrandId
                             join x in context.Colors on c.ColorId equals x.ColorId
                             join r in context.Rentals on c.CarId equals r.CarId

                             select new CarDetailDto
                             { CarId = c.CarId, BrandName = b.BrandName, ColorName = x.ColorName, ModelYear = c.ModelYear };
                            
                return result.ToList();
            }

        }
    }
}
