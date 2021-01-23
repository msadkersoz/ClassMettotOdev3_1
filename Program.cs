using System;
using System.Collections.Generic;

namespace ClassMetotDemo_Odev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri() { adi = "sadik", soyadi = "ersoz", yas = 29, id = 1 } ;
            Musteri musteri2 = new Musteri(){ adi = "eeeee", soyadi = "fffff", yas = 19, id = 2 } ;
            Musteri musteri3 = new Musteri(){ adi = "aaaa", soyadi = "cccc", yas = 20, id = 3 } ;
            Musteri musteri4 = new Musteri(){ adi = "dddd", soyadi = "rrrrr", yas = 22, id = 4 } ;


            List<Musteri> musteris = new List<Musteri>() { musteri1, musteri2, musteri3, musteri4};
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteris);
            musteriManager.Guncelle(musteris);


        }
    }
}
