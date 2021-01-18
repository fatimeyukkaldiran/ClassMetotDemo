using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();

            musteri1.musteriId = 1;
            musteri1.musteriAdSoyad = "Emre Ersoy";
            musteri1.musteriTuru = "Banka Müşterisi";
            musteri1.MusteriPuani = 8765;

            Musteri musteri2 = new Musteri();

            musteri2.musteriId = 2;
            musteri2.musteriAdSoyad = "Aylin Topaç";
            musteri2.musteriTuru = "Kredi Müşterisi";
            musteri2.MusteriPuani = 75462;

            Musteri musteri3 = new Musteri();

            musteri3.musteriId = 3;
            musteri3.musteriAdSoyad = "Seren Dilek";
            musteri3.musteriTuru = "Maaş Müşterisi";
            musteri3.MusteriPuani = 54632;

            Musteri musteri4 = new Musteri();
            musteri4.musteriId = 4;
            musteri4.musteriAdSoyad = "Kenan Dere";
            musteri4.musteriTuru = "Emekli Müşterisi";
            musteri4.MusteriPuani = 456897;


            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            musteriManager.MusteriEkle(musteri4);

            musteriManager.MusteriListele();
            musteriManager.MusteriSil(musteri4);
            musteriManager.MusteriListele();

        }
    }
}
