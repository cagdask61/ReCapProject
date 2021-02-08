using Business.Concrete;
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


            foreach (var cardetail in carManager.GetCarDetail())
            {
                Console.WriteLine(cardetail.CarName + " " + cardetail.BrandName + " " + cardetail.ColorName + " " + cardetail.DailyPrice);
            }

            Car carAdd = new Car
            {
                Id = 1,
                BrandId = 4,
                ColorId = 4,
                CarName = "Fiat",
                DailyPrice = 400,
                ModelYear = 2010,
                Description = "Dene gör ve yaşa."
            };
            Car carUpdate = new Car
            {
                Id = 2,
                BrandId = 2,
                ColorId = 2,
                CarName = "Dodge X",
                DailyPrice = 900,
                ModelYear = 1990,
                Description = "Dene gör ve hisset..."
            };
            Car carDelete = new Car{Id = 1};

            carManager.GetCarAdd(carAdd);
            carManager.GetCarUpdate(carUpdate);
            carManager.GetCarDelete(carDelete);
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(" + Araba ismi : " + car.CarName + " + Araba'nın açıklaması : " + car.Description);
            }


            Brand brandAdd = new Brand { Id = 10, BrandName = "C1" };
            Brand brandUpdate = new Brand { Id = 1, BrandName = "A1..." };
            Brand brandDelete = new Brand { Id = 9 };

            brandManager.GetBrandAdd(brandAdd);
            brandManager.GetBrandUpdate(brandUpdate);
            brandManager.GetBrandDelete(brandDelete);
            foreach (var brand in brandManager.GetBrandAll())
            {
                Console.WriteLine("Brand=> " + brand.Id + " " + brand.BrandName);
            }

            Color colorAdd = new Color { Id = 10, ColorName = "Dark purple" };
            Color colorUpdate = new Color { Id = 9, ColorName = "Light Green" };
            Color colorDeleted = new Color { Id = 2 };

            colorManager.GetColorAdd(colorAdd);
            colorManager.GetColorUpdate(colorUpdate);
            colorManager.GetColorDelete(colorDeleted);

            foreach (var color in colorManager.GetColorAll())
            {
                Console.WriteLine(color.Id +" "+color.ColorName);
            }
        }

       
    }
}
