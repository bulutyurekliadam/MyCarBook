﻿using MyCarBook.DataAccessLayer.Abstract;
using MyCarBook.DataAccessLayer.Repositories;
using MyCarBookEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarBook.DataAccessLayer.EntityFramework
{
    public class EfPriceDal:GenericRepository<Price>, IPriceDal
    {
    }
}
//Ders 18 bitti 