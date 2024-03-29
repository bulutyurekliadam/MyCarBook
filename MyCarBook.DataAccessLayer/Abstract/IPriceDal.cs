﻿using MyCarBookEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarBook.DataAccessLayer.Abstract
{
    public interface IPriceDal:IGenericDal<Price>
    {
        List<Price> GetPricesWithCars();
    }
}
