using System.Drawing;
using Core.DataAccess.IEntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramefork;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : EfEntityRepositoryBase<Color,CarsRentContext>,IColorDal
    {
       
    }
}
