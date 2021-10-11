using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1=new Ogrenci();
            ogrenci1.Isim="Ayşe";
            ogrenci1.Soyisim="Yılmaz";
            ogrenci1.OgrenciNo=293;
            ogrenci1.Sinif=3;

            ogrenci1.OgrenciBilgileriniGetir();

            ogrenci1.Sinifatlat();
            Console.WriteLine(ogrenci1.Sinif);
            ogrenci1.SinifDusur();
            Console.WriteLine(ogrenci1.Sinif);

            Ogrenci ogrenci2=new Ogrenci("Deniz","Şimşek",256,1);
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.SinifDusur();
            ogrenci2.SinifDusur();



        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { 
            // get => isim; 
            // set => isim = value; 
            get {   return isim;    }
            set { isim = value; }

            }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { get => sinif; 
        set { 
            sinif = value;
            if(value<=1)
            {
              Console.WriteLine("Sınıf En Az 1 Olabilir!");
              sinif=1;
            }
            else
            sinif=value;
             
            }

        
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){
            
        }

        public void OgrenciBilgileriniGetir()
        {
                Console.WriteLine("**********Öğrenci Bilgileri*********");
                Console.WriteLine("Öğrencinin Adı       :{0}",this.Isim);
                Console.WriteLine("Öğrencinin Soyadı       :{0}",this.Soyisim);
                Console.WriteLine("Öğrencinin Numarası       :{0}",this.OgrenciNo);
                Console.WriteLine("Öğrencinin Sınıfı        :{0}",this.Sinif);
        }

        public void Sinifatlat()
        {
            this.Sinif=this.Sinif+1;
        }

        public void SinifDusur()
        {
            this.Sinif=this.Sinif-1;
        }
    }
}
