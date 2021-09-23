using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {
            /*erisim_belirteci geri_donustipi metot_adi(parametreListesi/arguman)
            {
                Komutlar
                return;
            }
            */

            int a=2;
            int b=3;
            Console.WriteLine(a+b);
            int result=Topla(a,b);
            Console.WriteLine("Sonuc: "+result);

            static int Topla(int deger1, int deger2){
                
                return (deger1+deger2);
            }
             Metotlar metotlarrr=new Metotlar();
             metotlarrr.EkranaYazdir(Convert.ToString(result));

             
             int sonuc2=metotlarrr.ArttırveTopla(ref a,ref b);
             Console.WriteLine(Convert.ToString(sonuc2));
             metotlarrr.EkranaYazdir(Convert.ToString(a+b));

             
        }
        
    }

     class Metotlar
    {
        public void EkranaYazdir(string value){
            
           Console.WriteLine(value);
        }
        
        public int ArttırveTopla(ref int deger1, ref int deger2){
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}
