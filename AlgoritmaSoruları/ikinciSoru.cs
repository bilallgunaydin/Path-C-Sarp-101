using System;

namespace AlgoritmaSoruları
{
    class ikinciSoru
    {
        static void Main(string[] args)
        {
           
           /*Soru 2: Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
           Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
           Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın. */

            Console.WriteLine("Lütfen 2 adet pozitif tam sayı giriniz yazınız.");
            Console.Write("Birinci sayı: ");
            int nn=int.Parse(Console.ReadLine());
            Console.Write("İkinci sayı: ");
            int m=int.Parse(Console.ReadLine());
            int [] dizii=new int[nn];
            Console.WriteLine(nn+" adet sayı giriniz");
            for (int i = 0; i < nn; i++)
            {
                Console.Write("Lütfen "+(i+1)+".pozitif sayıyı giriniz:");
                dizii[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine(m+" sayısının tam bolenleri: ");
            for (int i = 0; i < dizii.Length; i++)
            {
                if(dizii[i]==m || dizii[i]%m==0)
                Console.WriteLine(dizii[i]);
            }

            
        }
    }
}
