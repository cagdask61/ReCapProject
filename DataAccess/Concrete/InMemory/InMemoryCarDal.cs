using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
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
                new Car(){Id=1,BrandId=1,ColorId=1,DailyPrice=150,ModelYear=2004,Description="Arabada kaza yok ve konforlu. Benzin Fazla yakıyor."},
                new Car(){Id=2,BrandId=2,ColorId=1,DailyPrice=250,ModelYear=2010,Description="Arabada kaza yok ve konforlu. Benzin Az yakıyor."},
                new Car(){Id=3,BrandId=3,ColorId=2,DailyPrice=100,ModelYear=2000,Description="Araba 100 geçince sarsılıyor"},
                new Car(){Id=4,BrandId=4,ColorId=2,DailyPrice=90,ModelYear=2005,Description="Ön tekerinde sorun var"},
                new Car(){Id=5,BrandId=5,ColorId=3,DailyPrice=200,ModelYear=2006,Description="Araba sadece 10 gün kiralanabilir"},
                new Car(){Id=6,BrandId=5,ColorId=3,DailyPrice=50,ModelYear=2007,Description="Araç sorunlu"},
                new Car(){Id=7,BrandId=5,ColorId=4,DailyPrice=100,ModelYear=2011,Description="Araçta hız sorunu var"},
                new Car(){Id=8,BrandId=6,ColorId=4,DailyPrice=300,ModelYear=2013,Description="Kullanılmaya hazır"},
                new Car(){Id=9,BrandId=7,ColorId=5,DailyPrice=400,ModelYear=1999,Description="Kullanılmaya hazır"},
                new Car(){Id=10,BrandId=8,ColorId=5,DailyPrice=500,ModelYear=2000,Description="Kullanılmaya hazır"},
                new Car(){Id=11,BrandId=9,ColorId=6,DailyPrice=40,ModelYear=20015,Description="Arabada kaza var ve konforu yok. Benzin Fazla yakıyor. virajlarda sıkıntılı"},
                new Car(){Id=12,BrandId=1,ColorId=6,DailyPrice=100,ModelYear=2020,Description="Bu aracın bilgisi yok"},
                new Car(){Id=13,BrandId=2,ColorId=7,DailyPrice=200,ModelYear=20012,Description="Arabada sorunlar var ama yola çıkmaya hazır."},
                new Car(){Id=14,BrandId=3,ColorId=7,DailyPrice=25,ModelYear=2005,Description="Arabada kaza yok ve konforlu. Benzin Fazla yakıyor."},
                new Car(){Id=15,BrandId=4,ColorId=7,DailyPrice=50,ModelYear=2019,Description="Arabada kaza var ve konforu yok. Benzin Fazla yakıyor."}
            };
        }

        //Listeye yeni araç ekleme methodu
        public void Add(Car car)
        {
            _cars.Add(car);
            Console.WriteLine(car.Id + " Id li araba eklendi");
        }

        //Listedeki Id ye göre bulup silme methodu
        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carDelete);
            Console.WriteLine(car.Id + " Id li araba silindi");
        }

        //Liste
        public List<Car> GetAll()
        {
            return _cars;
        }

        //Günlük araba kiralarını küçükten büyüğe sıralama methodu
        public List<Car> GetByDailyPrice()
        {
            List<Car> DailyPrice = _cars.OrderBy(c => c.DailyPrice).ToList();
            return DailyPrice;
        }

        //Günlük araba kiralarını büyüğe küçüğe sıralama methodu
        public List<Car> GetByDailyPriceDescending()
        {
            List<Car> DailyPriceDescending = _cars.OrderByDescending(c => c.DailyPrice).ToList();
            return DailyPriceDescending;
        }

        //Listedeki Id lere göre listeleme
        public List<Car> GetById(int Id)
        {
            return _cars.Where(c => c.Id == Id).ToList();
        }

        //Listedeki arabaların Model yıllarına göre küçükte büyüğe sıralama methodu 
        public List<Car> GetByModelYear()
        {
            List<Car> ModelYear = _cars.OrderBy(c=>c.ModelYear).ToList();
            return ModelYear;
        }

        //Listedeki arabaların Model yıllarına göre büyükten küçüğe sıralama methodu
        public List<Car> GetByModelYearDescending()
        {
            List<Car> ModelYearDescending = _cars.OrderByDescending(c => c.ModelYear).ToList();
            return ModelYearDescending;
        }

        //Listedeki Ararbaları güncelleme
        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.Id = car.Id;
            carUpdate.ColorId = car.ColorId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.Description = car.Description;
            Console.WriteLine(car.Id + " Id li araba Güncellendi");
        }
    }
}
