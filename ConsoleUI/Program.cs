using Business.Concrete;
using DataAccess.Concrete.EntityFreamwork;
using DataAccess.Concrete.InMemory;
using System.Linq;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var allCars =
                from car in carManager.GetCarsByBrandId(2)
                where car.DailyPrice <= 700
                select car;

            foreach (var car in allCars)
            {
                Console.WriteLine(car.Description);
            }


        }
    }
}