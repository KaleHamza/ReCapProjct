﻿using Core.DataAccess.IEntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramefork;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : EfEntityRepositoryBase<Brand, CarsRentContext>,IBrandDal
    {
        
    }
}
