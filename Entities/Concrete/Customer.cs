using System;
using System.Collections.Generic;
using System.Text;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Customer:IEntity
    {
        public int UserId { get; set; }
        public int CompanyName { get; set; }
        
    }
}
