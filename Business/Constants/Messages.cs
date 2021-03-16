using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ObjectAdded = "Nesne eklendi";
        public static string ObjectNameInvalid = "Nesne eklenemedi";
        public static string ObjectList = "Nesneler Listelendi";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ObjectDeleted = "Nesne Silindi";
        public static string ObjectUpdate = "Nesne Güncellendi";
        public static string ErrorMessage = "Hata Var";
        public static string Exist = "Böyle bir Nesne zaten mevcut";
        public static string CarImageLimitExceeded = "Araba fotoğrafı limiti aşıldı";

        public static string AuthorizationDenied = "Yetki yok";

        public static string UserRegistered = "Kullanıcı kaydı oluşturuldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Başarılı giriş";
        public static string UserAlreadyExists = "Kullanıcı mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
