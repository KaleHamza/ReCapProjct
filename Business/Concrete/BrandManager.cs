using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }
        public IResult Add(Brand entity)
        {
            _brandDal.Add(entity);
            return new SuccessResult(Messages.ObjectAdded);
        }

        public IResult Delete(Brand entity)
        {
            _brandDal.Delete(entity);
            return new SuccessResult(Messages.ObjectDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.GetAll());

        }

        public IDataResult<List<Brand>> GetById(int Id)
        {
            return new SuccessDataResult<List<Brand>>(_brandDal.Get(q => q.Id ==brand.Id));
        }

        public IResult Update(Brand entity)
        {
            _brandDal.Update(entity);
            return new SuccessResult(Messages.ObjectUpdated);
        }
    }
}
