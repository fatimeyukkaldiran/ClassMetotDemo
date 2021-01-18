using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        private List<Musteri> musteriler = new List<Musteri>(); //Müşteri listesi oluşturuldu
        public void MusteriEkle(Musteri musteri)
        {
            musteriler.Add(musteri);
            Console.WriteLine(musteri.musteriId + " " + "İd'li" +  musteri.musteriAdSoyad + " - " + musteri.musteriTuru + " - " + musteri.MusteriPuani + " müşterisi eklendi");
        }

     
        public void MusteriListele()
        {
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Müşteriler Listelendi !");
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.musteriId + "-" + musteri.musteriAdSoyad + "-"
                 + musteri.musteriTuru + "-" + musteri.MusteriPuani);
            }
            Console.WriteLine("--------------------------------------------");

        }
        

        public void MusteriSil(Musteri musteri)
        {
        
            musteriler.Remove(musteri);
            Console.WriteLine(musteri.musteriId + " İd' li " + musteri.musteriAdSoyad + " - "
                 + musteri.musteriTuru + " - " + musteri.MusteriPuani + " " + "Müşterisi silindi !");
        }
        

    }
}
