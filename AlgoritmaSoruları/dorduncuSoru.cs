using System;

namespace AlgoritmaSoruları
{
    class dorduncuSoru
    {
        static void Main(string[] args)
        {

         /* Soru 4: Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. 
         Cümledeki toplam kelime ve harf sayısını console'a yazdırın.            
         */
            Console.Write("Lütfen bir cümle girin: ");
            string sentence = Console.ReadLine();
            string newsentence=FullTrim(sentence);
            int countwordss=CountWords(newsentence);
            Console.WriteLine("Kelime sayısı: "+countwordss);
            int countletter=Countletter(newsentence);
            Console.WriteLine("Harf Sayısı: "+countletter);
        }
        static string FullTrim( string value) 
	        {
             int index=0;
            string fullTrimmed = string.Empty;
            int spaceCounter = 0;
            while (index < value.Length) 
            {
                  if (value[index] != ' ')
                   {
                     if (spaceCounter > 0)
                        {
                              spaceCounter = 0;
                            
                            if (fullTrimmed.Length > 0)
                            {
                                 fullTrimmed = fullTrimmed + ' ';
                            }
                        }

                     fullTrimmed = fullTrimmed + value[index];
                    

                    }
                   else
                   { 
                     spaceCounter++; 
                   
                   }
                    index++; 
            }
                return fullTrimmed;
            }

            static int CountWords(string value)
            {
                int count=0;
                for (int i = 0; i < value.Length; i++)
                {
                    if(value[i]==' ')
                    {
                        count++;
                    }
                }
                    return count+1;
            }
            static int Countletter(string value)
            {       int count=0;
                    for (int i = 0; i < value.Length; i++)
                    {
                        if(value[i]!= ' '){
                            count++;
                        }
                    }
                    return count;
            }

    }
         
}