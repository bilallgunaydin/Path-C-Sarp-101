using System;

namespace operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Atama ve İşlemli Atama Operatörleri *****");
           
           //Atama ve İşlemli Atama
           
           int x=3;
           int y=3;
           y= y+1;
           Console.WriteLine(y);
           y+=5;
           Console.WriteLine(y);
           y/=3;
           Console.WriteLine(y);
           x*=5;
           Console.WriteLine(x);


           Console.WriteLine("***** Mantıksal Operatörler *****");

           /* /Mantıklı Operatörler
            
            ||, &&, !
            
            */
        

           bool isSuccess=true;
           bool isCompleted=false;
           
           if(isSuccess && isCompleted)
                Console.WriteLine("Perfect!");
           if(isSuccess || isCompleted)
                Console.WriteLine("Great!");
           if(isSuccess && ! isCompleted)
                Console.WriteLine("Fine!");


            Console.WriteLine("***** İlişkisel Operatörler *****");

            /*İlişkisel Operatörler 
              
              <, >, <=, >=, ==, != 
              
            */

            int a= 6;
            int b=4;
            bool sonuc=a>b;

            Console.WriteLine(sonuc);
            sonuc=b>a;
            Console.WriteLine(sonuc);
            sonuc=b>=a;
            Console.WriteLine(sonuc);
            sonuc=a<=b;
            Console.WriteLine(sonuc);
            sonuc=a==b;
            Console.WriteLine(sonuc);
            sonuc=a!=b;
            Console.WriteLine(sonuc);


            Console.WriteLine("***** Aritmetik Operatörler *****");

            // /, *, + , -

            int sayi= 16;
            int sayi2=2;
            int sonuc1=sayi/sayi2;

            Console.WriteLine(sonuc1);
            sonuc1=sayi*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi-sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi++;
            Console.WriteLine(sonuc1);

            // % : mod alır
            int sonuc2=20%3;
            Console.WriteLine(sonuc2);
        }
    }
}
