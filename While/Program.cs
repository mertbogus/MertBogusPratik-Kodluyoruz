using System;

namespace While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lÜTFEN BİR SAYI GİRİNİZ:");
            int sayi = int.Parse(Console.ReadLine());
            int sayac = 1;
            int toplam;
            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            // a'dan z'ye kadar tüm harfleri console yazdır
            char character = 'a';
            while (character<'z')
            {
                Console.Write(character);
                character++;
            }
            Console.WriteLine("*************ForEach Döngüsü*****************");
            string[] arabalar = { "Ford", "Toyota", "Volvo" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
