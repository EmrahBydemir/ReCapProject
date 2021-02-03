using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManagement car = new CarManagement(new InMemoryProductDal());
            foreach (var item in car.Cars())
            {
                Console.WriteLine(item.Description);
            }
        }
    }
}
