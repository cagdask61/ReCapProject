using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _brandDal;
        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public void GetBrandAdd(Brand brand)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                _brandDal.Add(brand);
                Console.ResetColor();
                Console.WriteLine("Başarıyla Eklendi");
            }
            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error.Message);
                Console.ResetColor();
            }
        }

        public List<Brand> GetBrandAll()
        {
            return _brandDal.GetBrandAll();
        }

        public void GetBrandDelete(Brand brand)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                _brandDal.Delete(brand);
                Console.ResetColor();
                Console.WriteLine("Başarıyla Silindi");
            }
            catch (Exception error)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error.Message);
                Console.ResetColor();
            }
        }

        public void GetBrandUpdate(Brand brand)
        {
            try
            {

                Console.ForegroundColor = ConsoleColor.Green;
                _brandDal.Update(brand);
                Console.ResetColor();
                Console.WriteLine("Başarıyla Güncellendi");
            }
            catch (Exception error)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(error.Message);
                Console.ResetColor();
            }
        }
    }
}
