using System;


namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumber=0;
            int number=0;
            int [] numbers=new int[20];
            int [] maxNumbers =new int[3];
            int [] minNumbers =new int[3];
            double minAvg=0;
            double maxAvg=0;
            string tempMin=string.Empty;
            string tempMax=string.Empty;
            Console.WriteLine("Lütfen bir sayı giriniz:");;
            while(countNumber<20)
            {
                Console.Write((countNumber+1)+".sayınız:");
                bool success=int.TryParse(Console.ReadLine(), out number);
                if(success)
                {
                  numbers[countNumber]=number;
                  countNumber++;
                }
                
            }
                Array.Sort(numbers);
                for (int i = 0; i < 3; i++)
                {
                    minNumbers[i]=numbers[i];
                    minAvg=minAvg+minNumbers[i];

                    if(i<2)
                        tempMin=tempMin+minNumbers[i]+",";
                    else
                        tempMin=tempMin+minNumbers[i];
                }

                Array.Reverse(numbers);
                for (int i = 0; i < 3; i++)
                {
                    maxNumbers[i]=numbers[i];
                    maxAvg=maxAvg+maxNumbers[i];

                    if(i<2)
                         tempMax=tempMax+maxNumbers[i]+",";
                    else
                         tempMax=tempMax+maxNumbers[i];
                         
                }
                double resultMax=maxAvg/3;
                double resultMin=minAvg/3;
                Console.WriteLine("En Büyük üç Sayı: "+tempMax);
                Console.WriteLine("En Küçük Üç Sayı: "+tempMin);
                Console.WriteLine("En Büyük Üç Sayının Ortalaması:"+resultMax);
                Console.WriteLine("En Küçük Üç Sayının Ortalaması:"+resultMin);
                Console.WriteLine("Ortalamaların Toplamı:"+Convert.ToDouble(resultMax+resultMin));

        }
    }
}
