using System;

namespace hata_yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
            
            Console.WriteLine("Bir sayı giriniz.");
            int sayi=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı: "+sayi);
 
            }
            catch(Exception ex){
                    Console.WriteLine("Hata: "+ex.Message.ToString());
            }
            finally
            {
                Console.WriteLine("İşlem Tamamlandı!");
            }

           try
           {
              //int a=int.Parse(null);

              //int b=int.Parse("test");
              
              int c=int.Parse("1231231314151515");

           }
           catch (ArgumentNullException ex)
           {
               
               Console.WriteLine("Boş değer girdiniz");
               Console.WriteLine(ex);
           }
           catch(FormatException ex){
               Console.WriteLine("Veri tipi uygun değil");
               Console.WriteLine(ex);
           }
           catch(OverflowException ex){
               Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz.");
               Console.WriteLine(ex);
           }
           finally{
               System.Console.WriteLine("İşlem başarıyla tamamlandı");
           }
        }
    }
}
