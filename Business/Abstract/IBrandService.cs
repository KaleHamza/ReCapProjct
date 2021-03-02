using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetById(int Id);

        IResult Add(Brand entity);
        IResult Delete(Brand entity);
        IResult Update(Brand entity);
    }
}
