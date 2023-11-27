﻿using MyCarBookEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarBook.BusinessLayer.Abstract
{
    public interface IPriceService:IGenericService<Price>
    {
        public List<Price> TGetPricesWithCars();
    }
}
