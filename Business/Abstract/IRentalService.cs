using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IRentalService
    {
        IDataResult<List<Rental>> GetById(int RentalId);
        IDataResult<List<Rental>> GetAll();


        IResult Add(Rental rental);
        IResult Delete(Rental rental);
        IResult Update(Rental rental);

    }
}
