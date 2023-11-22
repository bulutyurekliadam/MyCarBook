using MyCarBook.BusinessLayer.Abstract;
using MyCarBook.DataAccessLayer.Abstract;
using MyCarBookEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCarBook.BusinessLayer.Concrete
{
    public class CarManager : ICarService
    {
        private readonly ICarDal _carDal;

        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void TDelete(Car entity)
        {
            _carDal.Delete(entity);
        }

        public List<Car> TGetAllCarsWithBrands()
        {
            return _carDal.GetAllCarsWithBrands();
        }

        public Car TGetByID(int id)
        {
            if (id != null)
            {
                return _carDal.GetByID(id);
            }
            return _carDal.GetByID(0); //araba bulunamadı
        }

        public List<Car> TGetListAll()
        {
            //bu işlemi yapmaya yetkili ise
            return _carDal.GetListAll();
        }

        public void TInsert(Car entity)
        {
            if (entity.Year >= 2010 && entity.Prices.Count >0 && entity.Km <= 500000)
            {
                _carDal.Insert(entity);
            }
            //hata mesajı -----> fluent validation
        }

        public void TUpdate(Car entity)
        {
            _carDal.Update(entity);
        }
    }
}
