using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Conrete;
using Entities.Concrete;

namespace Business.Constants
{
    public static class Messages
    {
        public static string PasswordError = "Hatalı şifre";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Giriş jetonu oluşturuldu";
        public static string UserNotFound = "kullanıcı bulunamadı";
        public static string UserRegistered = "Kullanıcı oluşturuldu";
        public static string AuthorizationDenied = "Doğrulama başarısız";
        public static string ProductNameAlreadyExist = "ürün ismi zaten var";
        public static string ProductCountOfCategoryError = "En fazla 15 kategori ekleyebilirsiniz";
        public static string MaintenanceTime = "Bakım arası";
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string ProductDeleted = "Ürün silindi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string ProductsListed = "Ürünler listelendi";
    }
}
