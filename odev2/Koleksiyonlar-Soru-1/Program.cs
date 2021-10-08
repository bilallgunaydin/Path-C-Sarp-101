using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList primeNumberList =new ArrayList();
            ArrayList not_PrimeNumberList =new ArrayList();
            int number;
            int countNotPrime=0;
            int countNumber=1;
            int primeAvg=0;
            int notPrimeAvg=0;
            double result=0;
            string temp=string.Empty;
            
                Console.WriteLine("Lütfen 0'dan büyük bir sayı giriniz.");
                while(countNumber<=20)
                {
                Console.Write(countNumber+".sayınız:");
                bool success=int.TryParse(Console.ReadLine(),out number);
                if(success && number>0)
                {
                  for (int i = 2; i < number; i++)
                  {
                  if(number % i ==0)
                  {
                      countNotPrime++;
                     break;
                  }
                  
                  }
                  if(countNotPrime==0 && number!=1)
                  {
                  primeNumberList.Add(number);
                  primeAvg=primeAvg+number;
                  }
                  else
                  {
                  not_PrimeNumberList.Add(number);
                  notPrimeAvg=notPrimeAvg+number;
                  }
                  countNumber++;
                  countNotPrime=0;
                }
                
                }
                
                Console.WriteLine("****** Asal Sayılar ******");
                
                if(primeNumberList.Count>0)
                {
                Console.WriteLine("Asal Sayılar Dizisinin Elaman Sayısı: "+primeNumberList.Count);
                result=Convert.ToDouble(primeAvg)/(primeNumberList.Count);
                primeNumberList.Sort();
                primeNumberList.Reverse();
                Console.WriteLine("Asal Sayılar Dizisinin Ortalaması: "+result);
                
                
                for (int i = 0; i < primeNumberList.Count; i++)
                {
                    if(i<primeNumberList.Count-1)
                        temp=temp+primeNumberList[i]+",";
                    else
                        temp=temp+primeNumberList[i];
                }
                Console.WriteLine("Asal Sayılar Dizisi: "+temp);
                
                }
                else
                Console.WriteLine("Girdiğiniz sayılar arasında asal sayı yoktur.");

                temp=string.Empty;
                result=0;

                Console.WriteLine("****** Asal Olmayan Sayılar ******");
                
                if(not_PrimeNumberList.Count>0)
                {
                Console.WriteLine("Asal Olmayan Sayılar Dizisinin Elaman Sayısı: "+not_PrimeNumberList.Count);
                result=Convert.ToDouble(notPrimeAvg)/(not_PrimeNumberList.Count);
                not_PrimeNumberList.Sort();
                not_PrimeNumberList.Reverse();
                Console.WriteLine("Asal Olmayan Sayılar Dizisinin Ortalaması: "+result);
                
                for (int i = 0; i < not_PrimeNumberList.Count; i++)
                {
                    if(i<not_PrimeNumberList.Count-1)
                        temp=temp+not_PrimeNumberList[i]+",";
                    else
                        temp=temp+not_PrimeNumberList[i];
                }
                Console.Write("Asal Olmayan Sayılar Dizisi: "+temp);
                
                }
                else
                Console.WriteLine("Girdiğiniz sayılar arasında asal olmayan sayı yoktur.");
        }
    }
}
