using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " listeye eklendi."); //ekleme simülasyonu   
        }
        public void Cıkar(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " listeden çıkarıldı."); // çıkartma simülasyonu
        }

        public void List(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                Console.WriteLine(musteri.Adi + " " + musteri.Soyadi + " müşteri yaşı : " + musteri.Yasi);
            }

        }
    }
}
