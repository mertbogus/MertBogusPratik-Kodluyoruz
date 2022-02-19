using System;

namespace For_Dongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Sayı Giriniz:");
            int sayac = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine("Bu bir tek sayıdır.");
                }
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını yazdır.
            int tektoplam = 0;
            int cifttoplam = 0;
            for (int i = 0; i <=1000; i++)
            {
                if (i % 2 == 1)
                {
                    Console.WriteLine("Bu bir tek sayıdır.");
                    tektoplam += i;
                }
                else
                {
                    Console.WriteLine("Bu sayı çift sayıdır.");
                    cifttoplam += i;
                }
                Console.WriteLine("Tek Toplam:"+" "+tektoplam);
                Console.WriteLine("Çift Toplam:" + " " + cifttoplam);

                //break contine
                for (int j = 0; j < 10; j++)
                {
                    if (j==4)
                        break;
                  Console.WriteLine(j);

                }
            }
        }
    }
}
