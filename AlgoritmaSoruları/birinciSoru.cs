using System;

namespace AlgoritmaSoruları
{
    class birinciSoru
    {
        static void Main(string[] args)
        {
            /*Soru 1:  Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın. */

            Console.Write("Lütfen çift olup olmadığını bilmek istediğiniz sayı adedini pozitif bir sayıyı tercih ederek yazınız: ");
            int n=int.Parse(Console.ReadLine());
            int [] dizi=new int[n];
            Console.WriteLine(n+" adet sayı giriniz");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen "+(i+1)+".pozitif sayıyı giriniz:");
                dizi[i]=int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < dizi.Length; i++)
            {
                if(dizi[i]%2==0)
                Console.WriteLine((i+1)+".çift sayı: "+dizi[i]);
            }
          
        }

    }
         
}
