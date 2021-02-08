using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;
        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void GetColorAdd(Color color)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                _colorDal.Add(color);
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

        public List<Color> GetColorAll()
        {
            return _colorDal.GetColorAll();

        }

        public void GetColorDelete(Color color)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                _colorDal.Delete(color);
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

        public void GetColorUpdate(Color color)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                _colorDal.Update(color);
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
