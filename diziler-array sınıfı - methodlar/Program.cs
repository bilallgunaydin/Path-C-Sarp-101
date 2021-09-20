using System;

namespace diziler_array_sınıfı___methodlar
{
    class Program
    {
        static void Main(string[] args)
        {
           //Sort

           Console.WriteLine("***** Sırasız Dizi *****");
           int [] sayiDizisi={22,5,61,7,9,13,9};
           foreach (var sayi in sayiDizisi)
           {
               Console.WriteLine(sayi);
           }

           Console.WriteLine("***** Sıralı Dizi *****");

           Array.Sort(sayiDizisi);
           foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

           //Clear


           Console.WriteLine("***** Array Clear *****");
           //sayiDizisi elamanlarını kullanarak 2.index'ten itibaren 2 tane elemanı 0'lar. 
           Array.Clear(sayiDizisi,2,2);
           foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

           //Reverse  
           Console.WriteLine("***** Array Reverse *****");
           
           Array.Reverse(sayiDizisi);   
           foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

           //Indexof

           Console.WriteLine("**** Array Indexof ****");

           Console.WriteLine(Array.IndexOf(sayiDizisi,22));

           //Resize
           Console.WriteLine("**** Array Resize ****");
           Array.Resize<int>(ref sayiDizisi,8);
           sayiDizisi[7]=900;

            foreach (var sayi in sayiDizisi)
            Console.WriteLine(sayi);
        }
    }
}
