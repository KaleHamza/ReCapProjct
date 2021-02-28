using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetAll();
        Color GetById(int Id);

        void Add(Color entity);
        void Delete(Color entity);
        void Update(Color entity);

    }

}
