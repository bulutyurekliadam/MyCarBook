﻿using Microsoft.EntityFrameworkCore;
using MyCarBook.DataAccessLayer.Abstract;
using MyCarBook.DataAccessLayer.Concrete;
using MyCarBook.DataAccessLayer.Repositories;
using MyCarBookEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarBook.DataAccessLayer.EntityFramework
{
    public class EfPriceDal : GenericRepository<Price>, IPriceDal
    {
        public List<Price> GetPricesWithCars()
        {
            var context = new CarBookContext();
            var values = context.Prices.Include(x => x.Car).ThenInclude(y => y.Brand).ToList();
            return values;
        }
    }
}
