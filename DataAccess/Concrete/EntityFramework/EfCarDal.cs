using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramefork;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarsInfoContext>, ICarDal
    {
        public List<CarDetailDto> GetCarDetails()
        
        {
            using (CarsInfoContext context = new CarsInfoContext())
            {
                var result = from a in context.Cars
                             join b in context.Colors
                             on a.ColorId equals b.Id
                             select new CarDetailDto
                             {
                                 CarId = a.Id,
                                 BrandId = a.Id,
                                 ColorId = b.Id,
                                 ModelYear = a.ModelYear
                             };
                return result.ToList();
            }

        }
    }
}
