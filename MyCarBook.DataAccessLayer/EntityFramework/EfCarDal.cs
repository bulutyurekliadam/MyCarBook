using Microsoft.EntityFrameworkCore;
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
    public class EfCarDal : GenericRepository<Car>, ICarDal
    {
        public List<Car> GetAllCarsWithBrands()
        {
            var context = new CarBookContext();
            var values = context.Cars.Include(x=>x.Brand).ToList();
            return values;
        }
    }
}
