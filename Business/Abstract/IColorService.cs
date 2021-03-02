﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<List<Color>> GetById(int Id);

        IResult Add(Color entity);
        IResult Delete(Color entity);
        IResult Update(Color entity);

    }

}
