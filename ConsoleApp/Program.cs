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

            Car car1 = new Car 
            {
                
                Id=4,BrandId = 3, ColorId = 3, CarName = "Dodge", DailyPrice=800,ModelYear=1980, Description="Dene gör ve hisset." 
            };

            carManager.GetCarAdd(car1);
            carManager.GetCarUpdate(car1);
            carManager.GetCarDelete(car1);
            foreach (var cars in carManager.GetAll())
            {
                Console.WriteLine(" + Araba ismi : "+ cars.CarName +" + Araba'nın açıklaması : "+cars.Description);
            }
        }
    }
}
