using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AuthorizationDenied = "Yetkiniz yok.";

        public static string BrandAdded = "Markalar Eklendi";
        public static string BrandNameInvalid = "Markalar ismi geçersiz";
        public static string BrandListed = "Markalar listelendi";
        public static string BrandUpdated = "Markalar güncellendi";
        public static string BrandDeleted = "Markalar silindi";

        public static string CarAdded = "Araba eklendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUpdated = "Araba güncellendi";
        public static string CarNameInvalid = "Araba ismi en az iki karakter olmalıdır.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarListed = "Arabalar listelendi";

        public static string CarImageListed = "Araba resimleri listelendi";
        public static string CarImageAdded = "Araba resmi eklendi";
        public static string CarImageUpdated = "Araba resmi güncellendi";
        public static string CarImageLimitExceded = "Bir araba için 5'ten fazla resim eklenemez.";
        public static string CarPriceInvalid = "Lütfen Günlük Kiralama Ücretini giriniz.";

        public static string ColorAdded = "Renk Eklendi";
        public static string ColorNameInvalid = "Renk ismi geçersiz";
        public static string ColorListed = "Renkler listelendi";
        public static string ColorUpdated = "Renk güncellendi";
        public static string ColorDeleted = "Renk silindi";

        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerCompanyNameInvalid = "Müşteri firma ismi geçersiz";
        public static string CustomerListed = "Müşteri listelendi";
        public static string CustomerUpdated = "Müşteri güncellendi";
        public static string CustomerDeleted= "Müşteri silindi";

        public static string RentalAdded = "Kiralama eklendi";
        public static string RentalDeleted = "Kiralama silindi";
        public static string RentalRentDateInvalid = "Kiralama tarihi geçersiz";
        public static string RentalReturnDateInvalid = "Kiralama dönüş tarihi geçersiz";
        public static string RentalUndeliveredCar = "Araç henüz teslim edilmedi.";
        public static string RentalListed = "Kiralamalar listelendi";
        public static string RentalUpdated = "Kiralama güncellendi";

        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDescriptionInvalid = "Kullanıcı ismi geçersiz";
        public static string UserListed = "Kullanıcı listelendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserRegistered = "Kullanıcı kayıt oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";

        public static string PasswordError = "Parola hatası";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
