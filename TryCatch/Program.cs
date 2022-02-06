﻿using System;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Bir Sayı Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz Sayı Şudur: " + sayi);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata:"+ex.Message.ToString());
            }
            //finally
            //{
            //    Console.WriteLine("İşlem Tamamlandı.");
            //}

            try
            {
                //int a = int.Parse(null);
                //int a = int.Parse("Test");
                int a = int.Parse("20000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş Değer Girdiniz.");
                Console.WriteLine(ex);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Veri Tipi Uygun Değil.");
                Console.WriteLine(ex);
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Çok küçük veya Çok büyük değer girdiniz.");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("İşlem Başarıyla Tamamlandı.");
            }

        }
    }
}
