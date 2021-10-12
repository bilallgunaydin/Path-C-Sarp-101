using System;

namespace csharp_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Cumartesi);

            int sicaklik=32;
            if(sicaklik<(int)HavaDurumu.Normal)
            Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            else if(sicaklik>=(int)HavaDurumu.CokSicak)
            Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün.");
            else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<=(int)HavaDurumu.Sicak)
            Console.WriteLine("Hadi dışarıya çıkalım!");
        }
    }

    enum Gunler
    {
        //Eğer sayı verirsek atama şeklinde devamı ardışık şekilde olur.

        //Örneğin Pazartesi=1 dediğimde artık 1'den 7'ye kadar sıralanmış olur.
        // Pazartesi,
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        // Cuma,
        //Cumayı 23 yaptığımda artık devamında 24, 25 şeklinde ilerler. Cuma'dan önce Pazartesi ile başlayan 1.sıralama Perşembe'de 4'te bitiyorken Cuma'da 23'de devam ediyor.
        Cuma=23,
        Cumartesi,
        Pazar
    }
    
    enum HavaDurumu
    {
        Soguk=5,
        Normal=20,
        Sicak=25,
        CokSicak=30

    }
}
