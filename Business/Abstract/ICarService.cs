using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ICarService
    {
        IDataResult<List<Car>> GetById(int CarId);
        IDataResult<List<Car>> GetAll();
        IDataResult<List<Car>> GetCarsByBrandId(int Id);
        IDataResult<List<Car>> GetCarsByColorId(int Id);
        IDataResult<List<CarDetailDto>> GetCarDetails();

        IResult Add(Car car);
        IResult Delete(Car car);
        IResult Update(Car car);
    }
}
