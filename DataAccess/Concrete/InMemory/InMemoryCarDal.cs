using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car(){Id=1,BrandId=1,ColorId=1,CarName="Bmw",DailyPrice=150,ModelYear=2004,Description="Arabada kaza yok ve konforlu. Benzin Fazla yakıyor."},
                new Car(){Id=2,BrandId=2,ColorId=1,CarName="Mercedes",DailyPrice=250,ModelYear=2010,Description="Arabada kaza yok ve konforlu. Benzin Az yakıyor."},
                new Car(){Id=3,BrandId=3,ColorId=2,CarName="Fiat",DailyPrice=100,ModelYear=2000,Description="Araba 100 geçince sarsılıyor"},
                new Car(){Id=4,BrandId=4,ColorId=2,CarName="Ford",DailyPrice=90,ModelYear=2005,Description="Ön tekerinde sorun var"},
                new Car(){Id=5,BrandId=5,ColorId=3,CarName="Tofaş",DailyPrice=200,ModelYear=2006,Description="Araba sadece 10 gün kiralanabilir"},
                new Car(){Id=6,BrandId=5,ColorId=3,CarName="Renault",DailyPrice=50,ModelYear=2007,Description="Araç sorunlu"},
                new Car(){Id=7,BrandId=5,ColorId=4,CarName="Audi",DailyPrice=100,ModelYear=2011,Description="Araçta hız sorunu var"},
                new Car(){Id=8,BrandId=6,ColorId=4,CarName="Bugatti",DailyPrice=300,ModelYear=2013,Description="Kullanılmaya hazır"},
                new Car(){Id=9,BrandId=7,ColorId=5,CarName="Honda",DailyPrice=400,ModelYear=1999,Description="Kullanılmaya hazır"},
                new Car(){Id=10,BrandId=8,ColorId=5,CarName="Dodge",DailyPrice=500,ModelYear=2000,Description="Kullanılmaya hazır"},
                new Car(){Id=11,BrandId=9,ColorId=6,CarName="Subaru",DailyPrice=40,ModelYear=2015,Description="Arabada kaza var ve konforu yok. Benzin Fazla yakıyor. virajlarda sıkıntılı"},
                new Car(){Id=12,BrandId=1,ColorId=6,CarName="Suzuki",DailyPrice=100,ModelYear=2020,Description="Bu aracın bilgisi yok"},
                new Car(){Id=13,BrandId=2,ColorId=7,CarName="Toyota",DailyPrice=200,ModelYear=2012,Description="Arabada sorunlar var ama yola çıkmaya hazır."},
                new Car(){Id=14,BrandId=3,ColorId=7,CarName="Volvo",DailyPrice=25,ModelYear=2005,Description="Arabada kaza yok ve konforlu. Benzin Fazla yakıyor."},
                new Car(){Id=15,BrandId=4,ColorId=7,CarName="Volkswagen",DailyPrice=50,ModelYear=2019,Description="Arabada kaza var ve konforu yok. Benzin Fazla yakıyor."}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.Id + " Id li araba eklendi");
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carDelete);
            Console.WriteLine(car.Id + " Id li araba silindi");
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.Id = car.Id;
            carUpdate.ColorId = car.ColorId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.CarName = car.CarName;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.Description = car.Description;
            Console.WriteLine(car.Id + " Id li araba Güncellendi");
        }
    }
}
