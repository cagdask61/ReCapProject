using Business.Concrete;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new InMemoryCarDal());

            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkBlue; 

            carManager.GetCarAdd(new Car { Id = 16, BrandId = 9, ColorId = 2, DailyPrice = 300, ModelYear = 2020, Description = "araba sağlam" });
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(" - Id : " + car.Id + " - Marka Id:" + car.BrandId + " - Renk Id: " + car.ColorId + " - Günlük Kullanım ücreti : " + car.DailyPrice + " - Aracın modeli : " + car.ModelYear + " - Araba ile ilgili açıklama :  " + car.Description + Environment.NewLine);
            }

            Console.WriteLine("------------------------------------------------------");

             
            foreach (var car in carManager.GetByModelYearDescending())
            {
                
                Console.WriteLine(" - Aracın modeli : " + car.ModelYear + " - Id : " +car.Id+" - Marka Id:" + car.BrandId+ " - Renk Id: " +car.ColorId+ " - Günlük Kullanım ücreti : " +car.DailyPrice+  " - Araba ile ilgili açıklama :  "+car.Description + Environment.NewLine);
                
            }
            Console.WriteLine("-------------------------------------------------------");


            foreach (var carX in carManager.GetByDailyPrice())
            {
                Console.WriteLine(" - Günlük Kullanım ücreti : " + carX.DailyPrice +" - Id : " + carX.Id + " - Marka Id:" + carX.BrandId + " - Renk Id: " + carX.ColorId  + " - Aracın modeli : " + carX.ModelYear + " - Araba ile ilgili açıklama :  " + carX.Description + Environment.NewLine);
            }


            
            
        }
    }
}
