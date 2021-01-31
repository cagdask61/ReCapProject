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
            Console.ForegroundColor = ConsoleColor.Green;

            foreach (var car in carManager.GetByModelYearDescending())
            {
                
                Console.WriteLine(" Id : "+car.Id+" - Marka Id:" + car.BrandId+ " - Renk Id: " +car.ColorId+ " - Günlük Kullanım ücreti : " +car.DailyPrice+ " - Aracın modeli : "+car.ModelYear+" - Araba ile ilgili açıklama :  "+car.Description + Environment.NewLine);
                
            }


            

            
            
        }
    }
}
