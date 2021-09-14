using System;

namespace tipdonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // İmplicit Conversion (Bilinçsiz Dönüşüm)
            Console.WriteLine("*****İmplicit Conversion*****");
            byte a=10;
            sbyte b=3;
            short c=40;

            int d=a+b+c;
            Console.WriteLine("d:"+d);

            long h=d;
            Console.WriteLine("h:"+h);

            float i=h;
            Console.WriteLine("i:"+i);

            string e="Bilal";
            char f='k';
            object g=e+f+d;
            Console.WriteLine("g: "+g);

            // Explicit Conversion (Bilinçli Dönüşüm)

            Console.WriteLine("*****Explicit Conversion*****");

            int x=43;
            byte y=(byte)x;
            Console.WriteLine("y:"+y);
           
            System.Console.WriteLine(ss);

            int z=100;
            byte t=(byte)z;
            Console.WriteLine("t:"+t);

            float w= 15.5f;
            byte v=(byte)w;
            Console.WriteLine("v:"+v);


            // *** ToString Methodu ****
            Console.WriteLine("***** ToString Methodu *****");

            int xx=6;
            string yy=xx.ToString();
            Console.WriteLine("yy"+yy);
            string zz=10.3f.ToString();
             Console.WriteLine("zz"+zz);

            //System.Convert
             Console.WriteLine("***** System.Convert Sınıfı *****");     
             string s1="10", s2="20";
             int sayi1, sayi2, Toplam;
             sayi1=Convert.ToInt32(s1);
             sayi2=Convert.ToInt32(s2);
             Toplam=sayi1+sayi2;
             Console.WriteLine("Toplam: "+Toplam);

            //Parse
            Console.WriteLine("***** Parse Methodu *****");  
            ParseMethod();

        }
        public static void ParseMethod()
        {
            string metin="1000";
            string metin2="13340,25";
            int rakam1;
            double double1;
            rakam1=Int32.Parse(metin);
            double1=double.Parse(metin2);
            Console.WriteLine("rakam1: "+rakam1);
            Console.WriteLine("double1: "+double1);
        }
    }
}
