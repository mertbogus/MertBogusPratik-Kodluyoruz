using System;

namespace Degiskenler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b  = 5;//1byte
            sbyte c = 5;//1byte
            short s = 5; //2byte
            ushort us = 5; //2byte

            Int16 i16 = 2;
            int i = 2;
            Int32 i32 = 2;
            Int64 i64 = 8;

            uint ui = 2;
            long lg = 4;
            float f = 5;
            double d = 5;
            decimal dc = 5;

            char ch = 'y';
            string st = "kodluyoruz";

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;


            Console.WriteLine(dt);

            object o1 = "s";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //string ifadeler
            string str1 = string.Empty;
            str1 = "Kodluyoruz";
            string ad = "Mert";
            string soyad="Böğüş";
            string tamisim = ad + " " + soyad;

            int integer1 = 4;
            int integer2 = 3;
            int integer3 = integer1 * integer2;

            //boolen
            bool bl1 = 10 < 2;

            //Dönüşümler
            string str20 = "20";
            int i20 = 20;
            string yenideger = str20 + i20.ToString();
            Console.WriteLine(yenideger);

            int int20 = i20 + Convert.ToInt32(str20);
            Console.WriteLine(int20);

            int int22 = int20 + int.Parse(str20);

            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            string datetime3 = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(datetime3);


        }
    }
}
