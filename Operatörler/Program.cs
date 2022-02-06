using System;

namespace Operatörler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************** Aritmetik İşlemli Atama ********************");
            //Aritmetik İşlemli Atama
            int y=3;
            int x=3;
            y=y+2;
            Console.WriteLine(y);
            y=+2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x*=2;
            Console.WriteLine(x);
            

            //Mantıksal Operatörler
            Console.WriteLine("*************** Mantıksal Operatörler Atama ********************");
            bool iSucess=true;
            bool iSCompleted=false;
            if(iSucess && iSCompleted)
             Console.WriteLine("Perfect");
             
            if(iSucess || iSCompleted)
             Console.WriteLine("Great");

             if(iSucess || iSCompleted)
             Console.WriteLine("Fine");

            Console.WriteLine("*************** İlişkisel Operatörler Atama ********************");
             int a=3;
             int b=4;
             bool sonuc=a>b;
             Console.WriteLine(sonuc);
             sonuc=a>b;
             Console.WriteLine(sonuc);
             sonuc=a>=b;
             Console.WriteLine(sonuc);
             sonuc=a<=b;
             Console.WriteLine(sonuc);
             sonuc=a!=b;

             int sayi=10;
             int sayi2=5;
             int sonucc=sayi/sayi2;
             Console.WriteLine(sonucc);
             int sonuc2=sayi+sayi2;
             Console.WriteLine(sonuc2);
             int sonuc3=sayi++;
             Console.WriteLine(sonuc3);
             int sonuc4=20%3;
             Console.WriteLine(sonuc4);





        }
    }
}
