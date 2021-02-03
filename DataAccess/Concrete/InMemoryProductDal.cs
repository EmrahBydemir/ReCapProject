using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryProductDal : ICarDal
    {
        List<Car> cars;
        public InMemoryProductDal()
        {
            cars = new List<Car>()
                {
                    new Car(){Id =1, BrandId = 1, ColorId = 1, ModelYear = "2020", DailyPrice = 300, Description = "Güzel araba"},
                    new Car(){Id =2, BrandId = 1, ColorId = 1, ModelYear = "2020", DailyPrice = 500, Description = "Daha Güzel araba"},
                     new Car(){Id =3, BrandId = 1, ColorId = 1, ModelYear = "2020", DailyPrice = 500, Description = "Daha Güzel araba"}
                };
        }
        public void Add(Car car)
        {
            cars.Add(car);
        }

        public List<Car> GetCars()
        {
            return cars.Where(i=>i.Id < 4).ToList();
        }

        public void Update(Car car)
        {
            var emrah = cars.SingleOrDefault(i => i.Id == car.Id);
            car.Description = emrah.Description;
            car.ModelYear = emrah.ModelYear;
        }
    }
}
