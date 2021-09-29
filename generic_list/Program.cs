using System;
using System.Collections.Generic;

namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            //T=> Object türündedir.


            List<int> sayiListesi =new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(92);
            sayiListesi.Add(7);
            sayiListesi.Add(2);

            List<string> renkListesi=new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count

            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            //Foreach ve ListForeach ile elemanlara erişim
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }
            int toplam=0;
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));
            sayiListesi.ForEach(sayi=> toplam=toplam+sayi);

            Console.WriteLine(toplam);

            //Listeden eleman çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            
            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(0);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            renkListesi.ForEach(renk=> Console.WriteLine(renk));

            //Liste içerisinde Arama

            if(sayiListesi.Contains(10))
              Console.WriteLine("10 Liste içerisinde bulundu!");

            //Eleman ile Index'e erişme

            Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Dizi List'e çevirme

            string[] hayvanlar={"Kedi", "Köpek", "Kuş"};

            List<string> hayvanListesi=new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz?

            hayvanListesi.Clear();

            //List içerisinde nesne tutmak

            List<Kullanıcılar> kullaniciList=new List<Kullanıcılar>();
            
            Kullanıcılar kullanici1=new Kullanıcılar();
            kullanici1.Isim="Bilal";
            kullanici1.Soyisim="Günaydın";
            kullanici1.Yas=29;

            Kullanıcılar kullanici2=new Kullanıcılar();
            kullanici2.Isim="Muhittin";
            kullanici2.Soyisim="Topalak";
            kullanici2.Yas=20;

            kullaniciList.Add(kullanici1);
            kullaniciList.Add(kullanici2);

            List<Kullanıcılar> yeniListe=new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                Isim="Şükrü",
                Soyisim="Baba",
                Yas=23
            });
            
            foreach (Kullanıcılar kullanıcı in yeniListe)
            {
                Console.WriteLine("Kullanıcı Adı:"+kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:"+kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı:"+kullanıcı.Yas);
            }

            yeniListe.Clear();
        }
    }

    public class Kullanıcılar
    {
       private string isim;
       private string soyisim;
       private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
