using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Product added!";
        public static string ProductUpdated = "Product updated!";
        public static string ProductDeleted = "Product deleted!";
        public static string ProductNameInvalid = "Product name must be greater than 2 characters!";
        public static string MaintenanceTime = "System on maintenance!";
        public static string ProductsListed = "Products listed!";
        public static string ProductCountOfCategoryError = "A category must include less than 10 products!";
        public static string ProductNameAlreadyExists = "Product name already exists! Please choose a different name.";
        public static string CategoryLimitExceded = "Category limit exceded so we can't add your product!";
        public static string AuthorizationDenied = "You're not authorized!";
        public static string UserRegistered = "kullanıcı kayıt oldu";
        public static string UserNotFound="kullanıcı bulunamadı";
        public static string PasswordError = "şifre yanlış";
        public static string SuccessfulLogin = "giriş başarılı";
        public static string UserAlreadyExists="kullanıcı zaten mevcut";
        public static string AccessTokenCreated="erişim tokenı oluşturuldu";
    }
}
