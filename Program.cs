using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
           List<int> sayilistesi = new List<int> () ;
           sayilistesi.Add(20) ;
           sayilistesi.Add(12) ;
           sayilistesi.Add(45) ;
           sayilistesi.Add(56) ;
           sayilistesi.Add(78) ;
           sayilistesi.Add(36) ;

           List<string> renklistesi = new List<string> () ;
           renklistesi.Add("Yeşil") ;
           renklistesi.Add("Kırmızı") ;
           renklistesi.Add("Mavi") ;
           renklistesi.Add("Sarı") ;

           Console.WriteLine(sayilistesi.Count) ;
           Console.WriteLine(renklistesi.Count) ;

           //Foreach ile elemanlara erişim
        //    foreach (var sayi in sayilistesi)
        //    {
        //        Console.WriteLine(sayi) ;
        //    }

        //    foreach (var renk in renklistesi)
        //    {
        //        Console.WriteLine(renk) ;
        //    }

           sayilistesi.ForEach(sayi => Console.WriteLine(sayi)) ;
           renklistesi.ForEach(renk => Console.WriteLine(renk)) ;

           /// Listeden elaman çıkarma

           sayilistesi.Remove(56) ;            //yazılan elemanı çıkarma
           renklistesi.Remove("Kırmızı") ;

           sayilistesi.RemoveAt(2) ;           //yazılan indeksteki elemanı çıkarma
           renklistesi.RemoveAt(1) ;

           sayilistesi.ForEach(sayi => Console.WriteLine(sayi)) ;
           renklistesi.ForEach(renk => Console.WriteLine(renk)) ;

          //Liste içinde arama

          if(sayilistesi.Contains(36))
             Console.WriteLine("36 liste içerisinde bulundu");

        // Eleman ile indexe erişme

        Console.WriteLine(renklistesi.BinarySearch("Kırmızı")) ;

        //Diziyi List'e çevirme

        string[] hayvanlar = {"Kedi", "Köpek", "Kuş", "Aslan"} ;
        List<string> hayvanlarlistesi = new List<string>(hayvanlar) ;
        hayvanlarlistesi.ForEach(hayvan => Console.WriteLine(hayvan)) ;

        hayvanlarlistesi.Clear() ;    //Listeyi temizler
        hayvanlarlistesi.ForEach(hayvan => Console.WriteLine(hayvan)) ;
        Console.WriteLine("Liste temizlendi") ;

        //List içerisinde nesne tutmak

        List<Kullanıcılar> kullanıcılistesi = new List<Kullanıcılar> () ;
        Kullanıcılar kullanıcı1 = new Kullanıcılar() ;
        Kullanıcılar kullanıcı2= new Kullanıcılar() ;

        kullanıcı1.Isim ="Merve" ;
        kullanıcı1.Soyisim ="Özderin" ;
        kullanıcı1.Yas = 22 ;

        kullanıcı2.Isim = "Doğa" ;
        kullanıcı2.Soyisim = "Çiçek" ;
        kullanıcı2.Yas = 80 ;

        kullanıcılistesi.Add(kullanıcı1) ;
        kullanıcılistesi.Add(kullanıcı2) ;

        List<Kullanıcılar> yeniliste = new List<Kullanıcılar> () ;

        yeniliste.Add(new Kullanıcılar()
        {
           Isim = "Ali",
           Soyisim = "Veli" ,
           Yas = 20
        }) ;
        
        foreach (var kullanıcı in kullanıcılistesi)
        {
            Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Isim) ;
            Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.Soyisim) ;
            Console.WriteLine("Kullanıcı Yaşı: " + kullanıcı.Yas) ;
        }
         foreach (var kullanıcı in yeniliste)
        {
            Console.WriteLine("Kullanıcı Adı: " + kullanıcı.Isim) ;
            Console.WriteLine("Kullanıcı Soyadı: " + kullanıcı.Soyisim) ;
            Console.WriteLine("Kullanıcı Yaşı: " + kullanıcı.Yas) ;
        }
    

    

          
        }

        public class Kullanıcılar
        {
            private string isim ;
            private string soyisim ;
            private int yas ;

            public string Isim { get => isim ; set => isim =value ; }
            
            public string Soyisim { get => soyisim ; set => soyisim =value ; }
            
            public int Yas { get => yas ; set => yas =value ; }
        }
    }
}
