using System;

namespace degisken_odev
{
    class Program
    {
        static void Main(string[] args)
        {
            byte cdc=12;
            sbyte cw=-100;
            short srt= 123;
            Int16 integere12=1231;
            Int32 ıntegere32=32234;
            uint uinttt=113;
            long lng=123123123;
            decimal a=123112;
            float f=123,d;
            double dd=123.3;
            char cc='b';
            bool booolll=3>50;
            object o=33;
            object o2="sadasd";
            object o3='a';
            object o4=4.3;

            String isim="Bilal";
            string Soyisim="Günaydın";
            string tamİsim=isim+ " "+ Soyisim;
            Console.WriteLine(tamİsim);

            string deger4="100";
            int intdeger4=12;
            string newdeger=deger4 + intdeger4.ToString();
            Console.WriteLine(newdeger);

            string date=DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(date);

            string da2=DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(da2);

            string hour=DateTime.Now.ToString("HH.mm");
            Console.WriteLine(hour);

            int yeni=intdeger4*Convert.ToInt32(deger4);

            int yenisayi=intdeger4+int.Parse(deger4);
            Console.WriteLine(yenisayi);
            Console.WriteLine(yeni);
            Console.Read();
        }
    }
}
