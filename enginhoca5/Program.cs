using System;

namespace enginhoca5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sude Çetin

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Sude";
            musteri1.Soyadi = "Çetin";
            musteri1.TcNo = "123456789";

            //kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "12345678900";

            //Gerçek Müşteri - Tüzel Müşteri 

            Musteri musteri3 = new GercekMusteri(); // eğer bir yerde new görürsen o bellekteki referans no demek
            Musteri musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Ekle(musteri1);
            customerManager.Ekle(musteri2);
        }
    }
}
