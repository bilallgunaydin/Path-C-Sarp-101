using System;
using System.Collections;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bir cümle giriniz: ");
            string sentence=Console.ReadLine();
            char[] vowelList= {'a','e','ı','i','o','ö','u','ü'};
            string temp=string.Empty;
            ArrayList lettersList= new ArrayList();
            
            for (int i = 0; i < sentence.Length; i++)
            {
                for (int j = 0; j < vowelList.Length; j++)
                {
                    if(vowelList[j]==sentence[i])
                    lettersList.Add(sentence[i]);
                }
            }
            lettersList.Sort();
            for (int i = 0; i < lettersList.Count; i++)
            {
                if(i<lettersList.Count-1)
                    temp=temp+lettersList[i]+",";
                else
                    temp=temp+lettersList[i];
            }
            Console.Write("Girdiğiniz cümledeki sesli harfler: "+temp);

        }
    }
}
