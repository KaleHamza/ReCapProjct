using System;
using System.Collections.Generic;
using System.Text;
using Core.DataAccess.IEntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramefork;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal:EfEntityRepositoryBase<User,CarsRentContext>,IUserDal
    {
    }
}
