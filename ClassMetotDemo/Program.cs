using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 01;
            musteri1.Adi = "Yasin";
            musteri1.Soyadi = "Sandıkçı";
            musteri1.Yasi = 27;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 02;
            musteri2.Adi = "İrfan";
            musteri2.Soyadi = "Nişancı";
            musteri2.Yasi = 25;

            Musteri musteri3 = new Musteri();
            musteri3.Id = 03;
            musteri3.Adi = "Murat";
            musteri3.Soyadi = "Senol";
            musteri3.Yasi = 29;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 04;
            musteri4.Adi = "Duhan";
            musteri4.Soyadi = "İrfanoğlu";
            musteri4.Yasi = 28;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri3);
            musteriManager.Cıkar(musteri2);
            musteriManager.List(musteriler);
            musteriManager.Cıkar(musteri4);


        }
    }
}
