using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete
{
    public class Car:IEntity
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public int ColorId { get; set; }
        [Required(ErrorMessage ="Araba ismi gereklidir!")]
        public string CarName { get; set; }
        [Required(ErrorMessage ="Arabnın model yılı girmek zorunludur!")]
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
