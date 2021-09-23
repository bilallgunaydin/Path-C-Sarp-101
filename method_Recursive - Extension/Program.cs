using System;

namespace method_Recursive___Extension
{
    class Program
    {
        static void Main(string[] args)
        {
            // Rekürsif - Öz yinemeli
            //3^4
            int result=1;
            for (int i = 1; i < 5; i++)
            {
                result=result*3;
            }
            Console.WriteLine(result);
            İslemler instance =new ();
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metotlar

            string ifade="Bilal Günaydın";
            bool sonuc=ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if(sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpace());
            Console.WriteLine(ifade.MakeUpperCase());
            Console.WriteLine(ifade.MakeLowerCase());

            int[] dizi={3,6,78,91,1,0};
            dizi.SortArray();
            dizi.EkranaYazdir();

            int sayii=5;
            Console.WriteLine(sayii.IsEvenNumber());
           
            Console.WriteLine(ifade.GetFirstCharacter());
        }

    }
    public class İslemler
    {
            public int Expo(int sayi, int üs)
            {
                if(üs<2)
                return sayi;
                return Expo(sayi, üs-1)*sayi;
            }
            //Expo(3,4)
            //Expo(3,3)*3
            //Expo(3,2)*3*3
            //Expo(3,1)*3*3*3
            //3*3*3*3=3^4
    }
    public static class Extension{
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpace(this string param)
        {
            string[] dizi=param.Split(" ");
            return string.Join("",dizi);
        }

         public static string MakeUpperCase(this string param)
        {
            return param.ToUpper();
        }

         public static string MakeLowerCase(this string param)
        {
            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
                Array.Sort(param);
                return param;
        }

        public static void EkranaYazdir(this int[] param)
        {
            foreach (var item in param)
            {
              Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param)
        {   
                return param%2==0;
        }

        public static string GetFirstCharacter(this string param)
        {
                return param.Substring(0,1);
        }
    }
}
