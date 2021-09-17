using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //1'den başlayarak console'dan girilen sayıya kadar ( sayı dahil) ortalama hesaplayıp consol'a yazdıran program.
            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi=int.Parse(Console.ReadLine());
            int sayac=1;
            int toplam=0;
            while(sayac<=sayi){
                toplam +=sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);

            // "a"'dan "z"'ye kadar olan tüm harfleri console'a yazdır.

            char character= 'a';
            while(character<='z'){
                Console.Write(character);
                character++;
            }

            //Foreach
            string [] arabalar={"bmw","mercedes"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
