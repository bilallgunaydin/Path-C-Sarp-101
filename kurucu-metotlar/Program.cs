using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Çalışan 1 *******");
            Calisan calisan1=new Calisan("Bilal","Günaydın",1,"IT");
            calisan1.CalisanBilgileri();
            
            Console.WriteLine("****** Çalışan 2 *******");
            Calisan calisan2=new Calisan();
            calisan2.Ad="Muhittin";
            calisan2.Soyad="Topalak";
            calisan2.No=2;
            calisan2.Departman="İnsan Kaynakları";
            calisan2.CalisanBilgileri();

            Console.WriteLine("****** Çalışan 3 *******");
            Calisan calisan3 =new Calisan("Muhittin","Topolak");
            calisan3.CalisanBilgileri();

            Console.WriteLine("****** Çalışan 4 *******");
            Calisan calisan4 =new Calisan("Gamze","Yeliz");
            calisan4.CalisanBilgileri(calisan4.Ad,calisan4.Soyad);

        }
    }
    class Calisan
    {
        public Calisan(string ad, string soyad, int no, string departman){
            this.Ad=ad;
            this.Soyad=soyad;
            this.No=no;
            this.Departman=departman;

        }

        public Calisan(string ad, string soyad){
            this.Ad=ad;
            this.Soyad=soyad;

        }

        public Calisan(){

        }
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri()
        {
                Console.WriteLine("Çalışan Adı:"+Ad);
                Console.WriteLine("Çalışanın Soyadı:"+Soyad);
                Console.WriteLine("Çalışanın Numarası:"+No);
                Console.WriteLine("Çalışanın Departmanı:"+Departman);
        }

        public void CalisanBilgileri(string ad, string soyad)
        {
                Console.WriteLine("Çalışan Adı:"+ad);
                Console.WriteLine("Çalışanın Soyadı:"+soyad);
               
        }

    }
}
