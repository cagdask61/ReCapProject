using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        List<Color> GetColorAll();

        void GetColorAdd(Color color);

        void GetColorDelete(Color color);

        void GetColorUpdate(Color color);
    }
}
