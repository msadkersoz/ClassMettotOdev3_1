using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo_Odev3
{
    class MusteriManager
    {
        int syc = 1;
       void Yazdir(List<Musteri> musteris)
        {

            foreach (var musteri in musteris)
            {           var x = musteri.id;
                Console.WriteLine("----- Musteri Id : " + musteri.id+" ---------");
                Console.WriteLine(x+ " .nci adı : "+musteri.adi);
             
                Console.WriteLine(x + " .nci Soyadı : " + musteri.soyadi);
              
                Console.WriteLine(x + " .nci Yaşı : " + musteri.yas);
           
               //Console.WriteLine(x + " .nci Id no : " + musteri.id);
                Console.WriteLine("----------------");
            }
           
            
        }
       public void Ekle( List<Musteri> musteris  )
        {
            //foreach (var musteri in musteris)
            //{
                
            //}
           Console.WriteLine(" \n ++++++++++++++++++  Eklenen :  ++++++++++++++++++++++ \n");
                  Yazdir(musteris);
        }
        public void Guncelle(List<Musteri> musteris)
        {
            
            Console.WriteLine(" \n++++++++++++++++++++ Guncellenen : " /*+ musteri.id +*/+ " +++++++++++++++++++ \n");
            Yazdir(musteris);
        }
    }
}
