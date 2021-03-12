using Business.Concrete;
using Business.Constans;
using DataAccess.Concrete.EnityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            RentalManager rentalManager = new RentalManager(new EfRentalDal());

            var result = rentalManager.GetRentalDetail();
            if (result.Success == true)
            {
                foreach (var rental in result.Data)
                {
                    Console.WriteLine(rental.CarName+"-/-"+rental.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(Messages.NotFound);
            }

            foreach (var rentalcar in rentalManager.GetRentalDetail().Data)
            {
                Console.WriteLine(rentalcar.CarName);
            }

            foreach (var car in carManager.GetCarDetail().Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }

            foreach (var brand in brandManager.GetBrandAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }

            foreach (var color in colorManager.GetColorAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }

        }
    }
}
