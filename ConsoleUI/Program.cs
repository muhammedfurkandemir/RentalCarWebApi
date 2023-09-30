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
            //TestCar();
            
           
        }

        private static void TestCar()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result=carManager.GetCarDetails();
            Console.WriteLine(result.Success);
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.CarName+" / "+car.BrandName+" / "+car.ColorName+" / "+ car.DailyPrice);
            }
        }
    }
}