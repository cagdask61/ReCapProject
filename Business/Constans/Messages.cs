using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string CarAdded = " isimli Araba başarıyla eklendi.";
        public static string CarDeleted = " Araba başarıyla silindi. ";
        public static string CarUpdated = " Araba başarıyla güncellendi. ";
        public static string CarNameInValid = " Araba ismi geçersiz. ";
        public static string CarPriceInValid = " Araba günlük fiyatı uygun değil. ";
        public static string CarsListed = " Arabalar listelendi. ";
        public static string CarById = " İstenen Id ile eşleşen araba bulundu ";

        public static string BrandAdded = " Model başarıyla eklendi";
        public static string BrandDeleted = "Model başarıyla silindi";
        public static string BrandUpdated = "Model başarıyla güncellendi";
        public static string BrandsListed = " Modeller listelendi. ";
        public static string BrandById = " İstenen Id ile eşleşen araba bulundu ";

        public static string ColorAdded = "İstediğinz renk eklendi";
        public static string ColorDeleted = "İstediğinz renk silindi";
        public static string ColorUpdated = "İstediğinz renk güncellendi";
        public static string ColorsListed = " Renkler listelendi. ";
        public static string ColorById = " İstenen Id ile eşleşen araba bulundu ";

        public static string RentalAdded = " Kiranalabilir araba eklendi";
        public static string RentalDeleted = "Kiranalabilir araba silindi";
        public static string RentalUpdated = "Kiranalabilir araba güncellendi";
        public static string RentalListed = "Kiralayabileceğiniz arabalar listelendi";
        public static string RentalById = " İstenen Id ile eşleşen araba bulundu ";

        public static string NotFound = "İstediğiniz şeyi bulamadım";
        public static string MaintenanceTime = " Sistem bakımda. ";

        public static string UserAdded = " Kullanıcı başarıyla eklendi. ";
        public static string UserDeleted = " Kullanıcı başarıyla silindi. ";
        public static string UserUpdated = " Kullanıcı başarıyla güncellendi. ";
        public static string UserListed = " Kullanıcı başarıyla listelendi.";
        public static string UserById = " İstenen Id ile eşleşen araba bulundu ";

        public static string CustomerAdded = " Müşteri başarıyla eklendi.";
        public static string CustomerDeleted = " Müşteri başarıyla silindi. ";
        public static string CustomerUpdated = " Müşteri başarıyla güncellendi. ";
        public static string CustomerListed = " Müşteriler başarıyla listelendi.";
        public static string CustomerSingle = " İstediğiniz müşteri bulundu.";

        public static string CarNameAlreadyExists = "Lütfen başla bir isim giriniz. Bu isim alınmıştır.";

        public static string CarImageAdded = "Arabznızın fotoğrafı başarıyla eklendi";
        public static string CarImageDeleted = "Arabznızın fotoğrafı silindi eklendi";
        public static string CarImageUpdated = "Arabznızın fotoğrafı güncellendi eklendi";
        public static string CarImageLimitExceeded = "Arabanızın en fazla 5 fotoğrafı olabilir";

        public static string UserRegistered = "Kullanıcı başarıyla kayıt oldu";
        public static string UserNotFound = "Öyle bir kullanıcı yok";
        public static string PasswordError = "Girilen şifre hatalı";
        public static string SuccessfulLogin = "Başarıyla giriş yaptınız";
        public static string UserAlreadyExists = "Girilen değerde kullanıcı var";
        internal static string CreateAccessToken = "Başarıyla token oluşturuldu";
    }
}
