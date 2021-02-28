using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBrandService
    {
        List<Brand> GetAll();
        Brand GetById(int Id);

        void Add(Brand entity);
        void Delete(Brand entity);
        void Update(Brand entity);
    }
}
