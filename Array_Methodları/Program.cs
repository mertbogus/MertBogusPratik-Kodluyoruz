using System;

namespace Array_Methodları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayidizisi = { 23, 12, 18, 44, 22, 7, 2, 31 };
            Console.WriteLine("Sırasız Dizi Listesi");
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("SıralıDizi Listesi");
            Array.Sort(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            //Clear
            Console.WriteLine("Array Clear");
            Array.Clear(sayidizisi, 2, 2);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            //Reverse
            Console.WriteLine("Array Reverse");
            Array.Reverse(sayidizisi);
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }

            //IndexOf
            Console.WriteLine("Index Of");
            Console.Write(Array.IndexOf(sayidizisi, 23));

            //Resize
            Console.WriteLine("Resize");
            Array.Resize<int>(ref sayidizisi, 9);
            sayidizisi[8] = 99;
            foreach (var sayi in sayidizisi)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
