using System.Collections.Generic;
using System.Security.Cryptography;

namespace CalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsideOfCalculator();
        }

        static void InsideOfCalculator()
        {
            //Kullanıcıdan iki sayı alıyoruz sonra (+,-,*,/) giriyor ve işlem yapıyoruz. tüm işlemler için ayrı ayrı metot aç return.
            //Buna sadece girilen değerin metin olup olmamasını eklicem. gerisi tamam sanırım kontrol ederim yine.

            string sayi1, sayi2;
            double s1, s2;
            bool correctChar = true;


            calculatorFrame1();

            Console.WriteLine("| Lütfen işlem yapmak için sırayla iki sayı giriniz:  |");

            Console.Write("|");

            sayi1 = Console.ReadLine();
            bool sayiMi1 = double.TryParse(sayi1, out s1);

            Console.Write("|");

            sayi2 = Console.ReadLine();
            bool sayiMi2 = double.TryParse(sayi2, out s2);

            Console.WriteLine("| Lütfen yapılacak işlemi giriniz (+, -, * ,/)        |");
            char islem = Console.ReadKey(true).KeyChar;


            while (correctChar)
            {
                if (!sayiMi1 || !sayiMi2)
                {
                    Console.WriteLine("Lütfen sayısal değer giriniz:");
                    sayi1 = Console.ReadLine();
                    sayiMi1 = double.TryParse(sayi1, out s1);
                    sayi2 = Console.ReadLine();
                    sayiMi2 = double.TryParse(sayi2, out s2);
                }
                else
                {
                    if (!(islem == '+' || islem == '-' || islem == '*' || islem == '/'))
                    {
                        Console.WriteLine("| Lütfen geçerli bir işlem değeri giriniz (+, -, * ,/)  |");
                        islem = Console.ReadKey(true).KeyChar;
                    }
                    else if (islem == '+')
                    {
                        Console.WriteLine($"| Sonuc = {Plus(ref s1, ref s2, ref islem)}                                          |");
                        correctChar = false;

                    }
                    else if (islem == '-')
                    {
                        Console.WriteLine($"| Sonuc = {Minus(ref s1, ref s2, ref islem)}                                          |");
                        correctChar = false;
                    }
                    else if (islem == '*')
                    {
                        Console.WriteLine($"| Sonuc = {Cross(ref s1, ref s2, ref islem)}                                          |");
                        correctChar = false;
                    }
                    else if (islem == '/')
                    {
                        Console.WriteLine($"| Sonuc = {Division(ref sayi2, ref s1, ref s2, ref islem)}                                          |");
                        correctChar = false;
                    }
                }

            }

            calculatorFrame2();
        }

        
        static double Division(ref string sayi2, ref double s1, ref double s2, ref char islem)
        {
            if (s2 == 0)
            {
                Console.WriteLine("Lütfen payda için 0'dan farklı bir değer giriniz:");
                sayi2 = Console.ReadLine();
                bool sayiMi2 = double.TryParse(sayi2, out s2);
            }

            return (s1 / s2);
        }

        static double Cross(ref double s1, ref double s2, ref char islem)
        {
            return s1 * s2;
        }

        static double Minus(ref double s1, ref double s2, ref char islem)
        {
            return s1 - s2;
        }

        static double Plus(ref double s1, ref double s2, ref char islem)
        {
            return s1 + s2;
        }

        static void calculatorFrame1()
        {
            int edgeB = 55;  // Dikdörtgenin genişliği
            int edgeA = 4;

            Console.WriteLine("                ----Calculator----");
            Console.WriteLine(new string('-', edgeB));

            for (int i = 0; i < edgeA - 2; i++)
            {
                Console.Write('|');              // Sol kenar
                Console.Write(new string(' ', edgeB - 2));  // İç kısım (boşluk)
                Console.WriteLine('|');           // Sağ kenar
            }

        }
        static void calculatorFrame2()
        {
            int edgeB = 55;  // Dikdörtgenin genişliği
            int edgeA = 4;

            for (int i = 0; i < edgeA - 2; i++)
            {
                Console.Write('|');              // Sol kenar
                Console.Write(new string(' ', edgeB - 2));  // İç kısım (boşluk)
                Console.WriteLine('|');           // Sağ kenar
            }

            Console.WriteLine(new string('-', edgeB));
            Console.WriteLine("                ----Calculator----");


        }


    }
}
