using System.Runtime.Serialization;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi."; 
        public static string ProductNameInvalid = "Ürün ismi geçersiz.";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string ProductsListed = "Ürünler listelendi.";
        public static string ProductCountOfCategoryError="Bir kategoride en fazla 10 ürün olabilir.";
        public static string ProductNameAlreadyExists="Bu isimde zaten başka bir ürün var.";
        public static string CategoryCountExceedsLimit= "Mevcut kategori sayısı 15'i geçtiyse sisteme yeni ürün eklenemez.";
        public static string CategoryLimitExceded="Kategori limiti aşıldığından yeni ürün eklenemez.";
        public static string AuthorizationDenied="Yetkiniz yoktur.";
    }
}
