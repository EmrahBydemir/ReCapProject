using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManagement : ICarService
    {
        ICarDal carDal;
        public CarManagement(ICarDal car)
        {
            carDal = car;
        }
        public List<Car> Cars()
        {
            return carDal.GetCars();
        }
    }
}
