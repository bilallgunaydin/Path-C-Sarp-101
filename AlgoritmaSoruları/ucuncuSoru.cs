using System;

namespace AlgoritmaSoruları
{
    class ucuncuSoru
    {
        static void Main(string[] args)
        {

            /*Soru 3: Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın. */
            Console.Write("Lütfen tersten sıralanmasını istediğiniz kelime sayısını giriniz: ");
            int n=int.Parse(Console.ReadLine());
            string [] dizi=new string[n];
            
            for (int i = 0; i < n; i++)
            {
                Console.Write("Lütfen "+(i+1)+".kelimeyi giriniz:");
                dizi[i]=Console.ReadLine();
            }

            Console.WriteLine("Girdiğiniz kelimelerin sıralanışı aşağıdaki gibidir: ");
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
               
                Console.WriteLine(item);
            }
        }

    }
         
}