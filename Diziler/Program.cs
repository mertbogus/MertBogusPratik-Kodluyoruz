using System;

namespace Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Panda","Kartal" };
            int[] dizi;
            dizi=new int[5];

            //değer atamaları
            renkler[0] ="Mavi";
            dizi[3] = 10;
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);
            Console.WriteLine(hayvanlar[0]);

            //Döngüler Diziler
            Console.Write("Lütfen Dizinin Eleman Sayısını Giriniz: ");
            int diziuzun=int.Parse(Console.ReadLine()); 
            int[] deger=new int[diziuzun];
            for (int i = 0; i < diziuzun; i++)
            {
                Console.Write("Lütfen {0}.sayıyı giriniz: ",i+1);
                deger[i] = int.Parse(Console.ReadLine());
            }

            int toplam = 0;
            foreach (int sayi in deger)
            {
                toplam += sayi;
            }
            Console.WriteLine("Ortalama :"+toplam/diziuzun);
        }
    }
}
